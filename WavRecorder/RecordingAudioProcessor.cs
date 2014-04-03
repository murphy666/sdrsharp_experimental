using SDRSharp.Radio;

namespace SDRSharp.WavRecorder
{    
    public unsafe class RecordingAudioProcessor: IRealProcessor
    {
        public delegate void AudioReadyDelegate(float* audio, int length);

        private double _sampleRate;
        private bool _enabled;

        public event AudioReadyDelegate AudioReady;

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public double SampleRate
        {
            get { return _sampleRate; }
            set { _sampleRate = value; }
        }

        public void Process(float* audio, int length)
        {
            var handler = AudioReady;
            if (handler != null)
            {
                handler(audio, length);
            }
        }
    }
}
