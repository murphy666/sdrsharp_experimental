using System;

namespace SDRSharp.Radio
{
    public unsafe class Resampler
    {
        const double ProtectedPassband = 0.45;

        private int _phase;
        private readonly int _interpolationFactor;
        private readonly int _decimationFactor;
        private readonly int _tapsPerPhase;
        private readonly UnsafeBuffer _firKernelBuffer;
        private readonly float* _firKernel;
        private readonly UnsafeBuffer _firQueueBuffer;
        private readonly float* _firQueue;

        public Resampler(double inputSampleRate, double outputSampleRate, int taps)
        {
            DoubleToFraction(outputSampleRate / inputSampleRate, out _interpolationFactor, out _decimationFactor);
            var filterLenght = (int) (500.0 / 32000 * inputSampleRate) / _interpolationFactor * _interpolationFactor;
            _tapsPerPhase = filterLenght / _interpolationFactor;
            _firKernelBuffer = UnsafeBuffer.Create(filterLenght, sizeof(float));
            _firKernel = (float*) _firKernelBuffer;
            var cutoff = Math.Min(inputSampleRate, outputSampleRate) * ProtectedPassband;
            var kernel = FilterBuilder.MakeLowPassKernel(inputSampleRate * _interpolationFactor, filterLenght - 1, cutoff, WindowType.BlackmanHarris4);
            fixed (float* ptr = kernel)
            {
                for (var i = 0; i < kernel.Length; i++)
                {
                    ptr[i] *= _interpolationFactor;
                }
                Utils.Memcpy(_firKernel, ptr, filterLenght * sizeof(float));
            }
            _firQueueBuffer = UnsafeBuffer.Create(filterLenght, sizeof(float));
            _firQueue = (float*) _firQueueBuffer;
        }

        private static void DoubleToFraction(double value, out int num, out int den)
        {
            var a = 1;
            var b = 1;
            var f = 1.0;

            while (Math.Abs(f - value) > 1e-15)
            {
                if (f > value)
                {
                    b++;
                }
                else
                {
                    a++;
                }
                f = a / (double) b;
            }
            num = a;
            den = b;
        }

        public int Process(float* input, float* output, int inputLength)
        {
            var outputLength = 0;
            while (inputLength > 0)
            {
                var newSamples = 0;
                while (_phase >= _interpolationFactor)
                {
                    _phase -= _interpolationFactor;
                    newSamples++;
                    if (--inputLength == 0)
                    {
                        break;
                    }
                }

                if (newSamples >= _tapsPerPhase)
                {
                    input += (newSamples - _tapsPerPhase);
                    newSamples = _tapsPerPhase;
                }

                for (var tap = _tapsPerPhase - 1; tap >= newSamples; tap--)
                {
                    _firQueue[tap] = _firQueue[tap - newSamples];
                }

                for (var tap = newSamples - 1; tap >= 0; tap--)
                {
                    _firQueue[tap] = *input++;
                }

                while (_phase < _interpolationFactor)
                {
                    var coeff = _firKernel + _phase;

                    var sum = 0.0f;
                    for (var tap = 0; tap < _tapsPerPhase; tap++)
                    {
                        sum += *coeff * _firQueue[tap];
                        coeff += _interpolationFactor;
                    }
                    *output++ = sum;
                    outputLength++;

                    _phase += _decimationFactor;
                }
            }

            return outputLength;
        }

        public int ProcessInterleaved(float* input, float* output, int inputLength)
        {
            var outputLength = 0;
            while (inputLength > 0)
            {
                var newSamples = 0;
                while (_phase >= _interpolationFactor)
                {
                    _phase -= _interpolationFactor;
                    newSamples++;
                    if (--inputLength == 0)
                    {
                        break;
                    }
                }

                if (newSamples >= _tapsPerPhase)
                {
                    input += (newSamples - _tapsPerPhase) * 2;
                    newSamples = _tapsPerPhase;
                }

                for (var tap = _tapsPerPhase - 1; tap >= newSamples; tap--)
                {
                    _firQueue[tap] = _firQueue[tap - newSamples];
                }

                for (var tap = newSamples - 1; tap >= 0; tap--)
                {
                    _firQueue[tap] = *input;
                    input += 2;
                }

                while (_phase < _interpolationFactor)
                {
                    var coeff = _firKernel + _phase;

                    var sum = 0.0f;
                    for (var tap = 0; tap < _tapsPerPhase; tap++)
                    {
                        sum += *coeff * _firQueue[tap];
                        coeff += _interpolationFactor;
                    }
                    *output = sum;
                    output += 2;
                    outputLength++;

                    _phase += _decimationFactor;
                }
            }

            return outputLength;
        }
    }
}
