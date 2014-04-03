using System;
using SDRSharp.Radio;

namespace SDRSharp.NoiseBlanker
{
    public unsafe class NoiseBlankerProcessor : IIQProcessor
    {
        private const int SizeFactor = 2;
        private static readonly int AveragingWindow = Utils.GetIntSetting("NBAveragingWindow", 1000); // in µS
 
        private double _sampleRate;
        private bool _enabled;
        private bool _needConfigure;
        private int _averagingWindowLength;
        private int _blankingWindowLength;
        private int _index;
        private int _threshold;
        private double _pulseWidth;
        private float _ratio;
        private float _sum;
        private float _norm;
        private float _alpha;
        private UnsafeBuffer _delay;
        private Complex* _delayPtr;
        
        public double SampleRate
        {
            get { return _sampleRate; }
            set
            {
                _sampleRate = value;
                _needConfigure = true;
            }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public int NoiseThreshold
        {
            get { return _threshold; }
            set
            {
                _threshold = value;
                _ratio = ((100 - _threshold) * 0.1f + 1) * _norm;
            }
        }

        public double PulseWidth
        {
            get { return _pulseWidth; }
            set
            {
                _pulseWidth = value;
                var length = Math.Min(Math.Max(_pulseWidth * 1e-6 * _sampleRate, 1), _averagingWindowLength);
                _blankingWindowLength = (int) length;
                _alpha = 1.0f / _blankingWindowLength;
            }
        }

        private void Configure()
        {
            _index = 0;
            _sum = 0;
            _averagingWindowLength = (int) (AveragingWindow * 1e-6 * _sampleRate);
            _norm = 1.0f / _averagingWindowLength;
            _ratio = ((100 - _threshold) * 0.1f + 1) * _norm;
            _delay = UnsafeBuffer.Create((2 * _averagingWindowLength + 1) * SizeFactor, sizeof(Complex));
            _delayPtr = (Complex*) _delay;

            var length = Math.Min(Math.Max(_pulseWidth * 1e-6 * _sampleRate, 1), _averagingWindowLength);
            _blankingWindowLength = (int) length;
            _alpha = 1.0f / _blankingWindowLength;
        }

        public void Process(Complex* buffer, int length)
        {
            if (_needConfigure)
            {
                Configure();
                _needConfigure = false;
            }

            for (var i = 0; i < length; i++)
            {
                var delay = _delayPtr + _index;

                delay[0] = buffer[i];

                var sample = delay[_averagingWindowLength].FastMagnitude();

                _sum -= sample;
                _sum += delay[0].FastMagnitude();

                if (sample > _ratio * _sum)
                {
                    var blank = delay + _averagingWindowLength;
                    for (var j = 0; j < _blankingWindowLength; j++)
                    {
                        blank[j] *= j * _alpha;
                    }
                }

                buffer[i] = delay[_averagingWindowLength * 2];

                if (--_index < 0)
                {
                    _index = (2 * _averagingWindowLength + 1) * (SizeFactor - 1);
                    Utils.Memcpy(_delayPtr + _index + 1, _delayPtr, (2 * _averagingWindowLength) * sizeof(Complex));
                }
            }
        }
    }

    static class ComplexHelper
    {
        public static float FastMagnitude(this Complex c)
        {
            var r = Math.Abs(c.Real);
            var i = Math.Abs(c.Imag);
            return Math.Max(r, i);
        }
    }
}