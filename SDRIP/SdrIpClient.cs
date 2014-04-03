using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SDRSharp.SDRIP
{    
    public class SdrIpClient
    {
        private const int CI_RX_OUT_SAMPLE_RATE = 0x00B8;
        private const int CI_RX_STATE = 0x0018;
        private const int CI_RX_FREQUENCY = 0x0020;
        private const int CI_RX_RF_GAIN = 0x0038;

        private const int RX_STATE_IDLE = 0x01;
        private const int RX_STATE_ON = 0x02;

        private readonly TcpClient _tcpClient = new TcpClient();
        private double _sampleRate;
        private long _frequency;
        private sbyte _attenuator;
        private string _host;
        private int _port;
        private bool _use16Bit;

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public string Host
        {
            get { return _host; }
            set { _host = value; }
        }

        public sbyte Attentuator
        {
            get { return _attenuator; }
            set
            {
                SetRFAttentuator(value);
                _attenuator = value;
            }
        }

        public double Samplerate
        {
            get { return _sampleRate; }
            set
            {
                SetOutSampleRate((uint)value); 
                _sampleRate = value;
            }
        }

        public long Frequency
        {
            get { return _frequency; }
            set
            {
                SetFrequency(value); 
                _frequency = value;
            }
        }

        public bool Use16Bit
        {
            get { return _use16Bit; }
            set { _use16Bit = value; }
        }

        public void Connect(string hostName, int port)
        {            
            _tcpClient.Connect(hostName, port);
        }

        public void Disconnect()
        {
            try
            {
                _tcpClient.Client.Close(100);
                _tcpClient.Close();
            }
            catch
            {
            }            
        }

        public void StartStreaming()
        {
            byte[] buf = new byte[4];

            buf[0] = 0x80;
            buf[1] = RX_STATE_ON;
            buf[2] = (byte)(_use16Bit? 0x00:0x80);
            buf[3] = 0x00;

            SetControlItem(CI_RX_STATE, buf);
        }

        public void StopStreaming()
        {
            byte[] buf = new byte[4];

            buf[0] = 0x80;
            buf[1] = RX_STATE_IDLE;
            buf[2] = 0x00;
            buf[3] = 0x00;

            SetControlItem(CI_RX_STATE, buf);
        }

        #region TCP Client Private Methods
                
        private void SetControlItem(int item, byte[] data)
        {

            if (_tcpClient == null || !_tcpClient.Connected)
            {
                return;
            }

            var buf = new byte[4 + data.Length];
            var length = buf.Length;

            buf[0] = (byte)(length & 0xff);
            buf[1] = (byte)(0 | ((length >> 8) & 0x1f));
            buf[2] = (byte)(item & 0xff);
            buf[3] = (byte)((item >> 8) & 0xff);

            for (var i = 0; i < length - 4; i++)
            {
                buf[4 + i] = data[i];
            }

            try
            {
                var stream = _tcpClient.GetStream();
                stream.Write(buf, 0, buf.Length);
            }
            catch
            {

            }
        }

        private void SetOutSampleRate(uint sampleRate)
        {
            byte[] buf = new byte[5];

            buf[0] = 0;
            buf[1] = (byte)((sampleRate >> 0) & 0xff);
            buf[2] = (byte)((sampleRate >> 8) & 0xff);
            buf[3] = (byte)((sampleRate >> 16) & 0xff);
            buf[4] = (byte)((sampleRate >> 24) & 0xff);

            SetControlItem(CI_RX_OUT_SAMPLE_RATE, buf);
        }

        private void SetFrequency(long frequency)
        {
            byte[] buf = new byte[6];

            buf[0] = 0xff;
            buf[1] = (byte)((frequency >> 0) & 0xff);
            buf[2] = (byte)((frequency >> 8) & 0xff);
            buf[3] = (byte)((frequency >> 16) & 0xff);
            buf[4] = (byte)((frequency >> 24) & 0xff);
            buf[5] = (byte)((frequency >> 32) & 0xff);

            SetControlItem(CI_RX_FREQUENCY, buf);
        }

        private void SetRFAttentuator(sbyte value)
        {
            byte[] buf = new byte[2];

            buf[0] = 0xff;
            buf[1] = (byte)value;

            SetControlItem(CI_RX_RF_GAIN, buf);
        }
        
        #endregion
    }
}
