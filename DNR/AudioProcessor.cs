using SDRSharp.Radio;

namespace SDRSharp.DNR
{
    public unsafe class AudioProcessor : INoiseProcessor, IRealProcessor
    {              
        private double _sampleRate;             
        private bool _enabled;
                
        private NoiseFilter _filter1;
        private NoiseFilter _filter2;

        private bool _needNewFilters;
        
        public double SampleRate
        {
            get { return _sampleRate; }
            set
            {
                _sampleRate = value;
                _needNewFilters = true;
            }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public int NoiseThreshold { get; set; }

        public void Process(float* buffer, int length)
        {
            if (_needNewFilters)
            {
                _filter1 = new NoiseFilter();
                _filter2 = new NoiseFilter();

                _needNewFilters = false;
            }

            _filter1.NoiseThreshold = NoiseThreshold;
            _filter2.NoiseThreshold = NoiseThreshold;

            _filter1.Process(buffer, length, 2);
            _filter2.Process(buffer + 1, length, 2);
        }
    }
}