using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using SDRSharp.Radio;

namespace SDRSharp.SDRIP
{
    public unsafe class SdrIpIO: IFrontendController, IDisposable
    {
        private const long DefaultFrequency = 15000000;
        private const string DefaultHost = "127.0.0.1";
        private const int DefaultPort = 50000;        
        private const int UdpBufferCount = 128;
        private const int UdpBufferSize = 1444;

        private string _hostName;
        private int _port;
        private double _sampleRate;
        private long _frequency = DefaultFrequency;

        private SdrIpClient _client;
        
        private Socket _udpSocket;
        private bool _udpThreadRunning;
        private Thread _udpThread;
        private Thread _workerThread;
        private bool _workerThreadRunning;        
        
        private byte[][] _circularBuffers = new byte[UdpBufferCount][];
        private int _circularBufferHead;
        private int _circularBufferTail;
                
        UnsafeBuffer _sampleBuffer;
        Complex* _sampleBufferPtr;
        Complex* _workingSamplePtr;
        
        private readonly System.Timers.Timer _tuneTimer = new System.Timers.Timer(100);
        private bool _needRetune;
        private bool _is16Bit;
        private long _lostPacketsCount;
        ushort _nextSequence;
        private int _sampleCount;

        private readonly SharpEvent _bufferEvt = new SharpEvent(false);
        private readonly SDRIPClientDialog _gui;
        private SamplesAvailableDelegate _callback;
        
        #region Public Properties

        public bool IsSoundCardBased
        {
            get { return false; }
        }

        public string SoundCardHint
        {
            get { return string.Empty; }
        }

        public double Samplerate
        {
            get { return _sampleRate; }
            set { _sampleRate = value; }
        }

        public long Frequency
        {
            get { return _frequency; }
            set
            {
                if (_frequency != value)
                {
                    _frequency = value;
                    _needRetune = true;
                }
            }
        }

        public SdrIpClient NetworkedDevice
        {
            get { return _client; }
        }

        public bool IsStreaming
        {
            get { return _workerThread != null; }
        }

        public long LostPacketCount
        {
            get { return _lostPacketsCount; }
        }

        public bool Is16Bit
        {
            get { return _is16Bit; }
            set { _is16Bit = value; }
        }

        #endregion

        #region Initialization / Termination

        public SdrIpIO()
        {
            _gui = new SDRIPClientDialog(this);
            _gui.Host = Utils.GetStringSetting("SDRIPHost", DefaultHost);
            _gui.Port = Utils.GetIntSetting("SDRIPPort", DefaultPort);
            _gui.SamepleRateIndex = Utils.GetIntSetting("SDRIPRateIndex", 9);
            _gui.SampleFormatIndex = Utils.GetIntSetting("SDRIPFormatIndex", 0);
            
            _tuneTimer.Elapsed += new ElapsedEventHandler(TuneTimerElapsed);

            for (var i = 0; i < _circularBuffers.Length; i++)
            {
                _circularBuffers[i] = new byte[UdpBufferSize];
            }
        }

        ~SdrIpIO()
        {
            Dispose();   
        }

        #endregion

        public void Dispose()
        {
            if (_sampleBuffer != null)
            {
                _sampleBuffer.Dispose();
                _sampleBufferPtr = null;
                _workingSamplePtr = null;
            }
        }
      
        public void Open()
        {
           
        }

        public void Close()
        {

        }
        
        public void Start(SDRSharp.Radio.SamplesAvailableDelegate callback)
        {
            _callback = callback;
            _hostName = _gui.Host;
            _port = _gui.Port;
            _is16Bit = _gui.Use16Bit;

            _lostPacketsCount = 0;
            _circularBufferHead = 0;
            _circularBufferTail = 0;
            _sampleCount = 0;

            _sampleBuffer = UnsafeBuffer.Create(256 * 2, sizeof(Complex));
            _sampleBufferPtr = (Complex*)_sampleBuffer;
            _workingSamplePtr = _sampleBufferPtr;

            _client = new SdrIpClient();            
            _client.Connect(_hostName, _port);
            _client.Samplerate = _sampleRate;
            _client.Frequency = _frequency;
            _client.Use16Bit = _is16Bit;
                        
            _udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _udpSocket.ReceiveBufferSize = 65535;
            var remoteIpEndPoint = new IPEndPoint(IPAddress.Any, _port);
            _udpSocket.Bind(remoteIpEndPoint);
            _udpThread = new Thread(UdpReceiverThread);
            _udpThread.Priority = ThreadPriority.Highest;
            _udpThreadRunning = true;
            _udpThread.Start();

            _workerThread = new Thread(WorkerThread);
            _workerThreadRunning = true;
            _workerThread.Start();

            _client.StartStreaming();
            _tuneTimer.Start(); 
           
            Utils.SaveSetting("SDRIPHost", _hostName);
            Utils.SaveSetting("SDRIPPort", _port);
            Utils.SaveSetting("SDRIPRateIndex", _gui.SamepleRateIndex);
            Utils.SaveSetting("SDRIPFormatIndex", _gui.SampleFormatIndex);
        }

        public void Stop()
        {
            _tuneTimer.Stop();

            _client.StopStreaming();
            _client.Disconnect();
            _client = null;
            if (_udpSocket != null)
            {
                _udpSocket.Close();
                _udpSocket = null;
            }            
            _udpThreadRunning = false;
            if (_udpThread != null)
            {
                _udpThread.Join();
                _udpThread = null;
            }
            _workerThreadRunning = false;
            if (_workerThread != null)
            {
                _bufferEvt.Set();
                _workerThread.Join();
                _workerThread = null;
            }

            if (_sampleBuffer != null)
            {
                _sampleBuffer.Dispose();
                _sampleBufferPtr = null;
                _workingSamplePtr = null;
            }
        }

        public void ShowSettingGUI(IWin32Window parent)
        {
            if (!_gui.IsDisposed)
            {
                _gui.Show();
            }            
        }

        public void HideSettingGUI()
        {
            if (!_gui.IsDisposed)
            {
                _gui.Hide();
            }
        }
        
        private void ProcessSamples(byte[] buffer, int actualLength)
        {           
            const float scale24 = 1.0f / 2147483647.0f;
            const float scale16 = 1.0f / 32768.0f;

            var seq = (ushort)buffer[3] << 8 | buffer[2];
            if (seq != _nextSequence && _nextSequence != 0)
            {
                _lostPacketsCount++;
            }
            _nextSequence = (ushort)(seq + 1);

            if (!_is16Bit)
            {
                for (var i = 4; i < actualLength; i += 6)
                {
                    _workingSamplePtr->Imag = (float)((int)(buffer[i + 2] << 24 | buffer[i + 1] << 16 | buffer[i] << 8)) * scale24;
                    _workingSamplePtr->Real = (float)((int)(buffer[i + 5] << 24 | buffer[i + 4] << 16 | buffer[i + 3] << 8)) * scale24;
                    _workingSamplePtr++;
                    _sampleCount++;
                }

                if (_sampleCount >= 240 * 2)
                {
                    _callback(this, _sampleBufferPtr, _sampleCount);
                    _workingSamplePtr = (Complex*)_sampleBufferPtr;
                    _sampleCount = 0;
                }
            }
            else
            {
                for (var i = 4; i < actualLength; i += 4)
                {
                    _workingSamplePtr->Imag = (float)((short)((buffer[i + 1] << 8) | buffer[i])) * scale16;
                    _workingSamplePtr->Real = (float)((short)((buffer[i + 3] << 8) | buffer[i + 2])) * scale16;
                    _workingSamplePtr++;
                    _sampleCount++;
                }

                if (_sampleCount >= 256 * 2)
                {
                    _callback(this, _sampleBufferPtr, _sampleCount);
                    _workingSamplePtr = (Complex*)_sampleBufferPtr;
                    _sampleCount = 0;
                }
            }
        }

        private void UdpReceiverThread()
        {
            EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, _port);
            _udpSocket.UseOnlyOverlappedIO = true;
            
            while (_udpSocket != null && _udpThreadRunning)
            {
                try
                {                    
                    var result = _udpSocket.ReceiveFrom(_circularBuffers[_circularBufferHead], ref remoteEndPoint);
                    if (result > 0)
                    {
                        _circularBufferHead++;
                        _circularBufferHead &= UdpBufferCount - 1;
                        _bufferEvt.Set();
                    }
                }
                catch
                {
                    Close();
                    return;
                }
            }
        }

        private void WorkerThread()
        {
            while (_workerThreadRunning)
            {
                if (_circularBufferHead == _circularBufferTail)
                {
                    _bufferEvt.WaitOne();
                }

                if (_workerThreadRunning && _circularBufferHead != _circularBufferTail)
                {
                    ProcessSamples(_circularBuffers[_circularBufferTail], _is16Bit? 1028 : 1444);
                    _circularBufferTail++;
                    _circularBufferTail &= UdpBufferCount - 1;
                }
            }
        }

        #region Tune Timer

        void TuneTimerElapsed(object sender, ElapsedEventArgs e)
        {
            lock (_tuneTimer)
            {
                if (_needRetune)
                {                    
                    _client.Frequency = _frequency;
                    _needRetune = false;
                }
            }
        }

        #endregion
    }
}
