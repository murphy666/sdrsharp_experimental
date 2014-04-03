using SDRSharp.Radio;

namespace SDRSharp.DNR
{
    public unsafe class IFProcessor : INoiseProcessor, IIQProcessor
    {              
        private double _sampleRate;             
        private bool _enabled;
                
        private NoiseFilter _filter;

        private bool _needNewFilter;
        
        public double SampleRate
        {
            get { return _sampleRate; }
            set
            {
                _sampleRate = value;
                _needNewFilter = true;
            }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public int NoiseThreshold { get; set; }

        public void Process(Complex* buffer, int length)
        {
            if (_needNewFilter)
            {
                _filter = new NoiseFilter();

                _needNewFilter = false;
            }

            _filter.NoiseThreshold = NoiseThreshold;

            _filter.Process(buffer, length);
        }
    }
}