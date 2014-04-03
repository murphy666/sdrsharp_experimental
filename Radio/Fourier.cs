using System;

namespace SDRSharp.Radio
{
    public static unsafe class Fourier
    {
        private const int MaxLutBits = 16; // 64k
        private const int MaxLutBins = 1 << MaxLutBits;
        private const int LutSize = MaxLutBins / 2;
        private const double TwoPi = 2.0 * Math.PI;

        private static UnsafeBuffer _lutBuffer = UnsafeBuffer.Create(LutSize, sizeof(Complex));
        private static Complex* _lut;

        static Fourier()
        {
            _lut = (Complex*) _lutBuffer;

            const double angle = TwoPi / MaxLutBins;

            for (var i = 0; i < LutSize; i++)
            {
                _lut[i] = Complex.FromAngle(angle * i).Conjugate();
            }
        }
        
        public static void SpectrumPower(Complex* buffer, float* power, int length, float offset = 0.0f)
        {
            for (var i = 0; i < length; i++)
            {
                var m = buffer[i].Real * buffer[i].Real + buffer[i].Imag * buffer[i].Imag;
                var strength = (float) (10.0 * Math.Log10(1e-60 + m)) + offset;
                power[i] = strength;
            }
        }

        public static void ScaleFFT(float* src, byte* dest, int length, float minPower, float maxPower)
        {
            var scale = byte.MaxValue / (maxPower - minPower);
            for (var i = 0; i < length; i++)
            {
                var magnitude = src[i];
                if (magnitude < minPower)
                {
                    magnitude = minPower;
                }
                else if (magnitude > maxPower)
                {
                    magnitude = maxPower;
                }
                dest[i] = (byte) ((magnitude - minPower) *  scale);
            }
        }

        /// <summary>
        /// Copies the spectrum density between arrays of different size with zoom and offset
        /// </summary>
        /// <param name="srcPtr">Source buffer</param>
        /// <param name="dstPtr">Destination buffer</param>
        /// <param name="sourceLength">Source length</param>
        /// <param name="destinationLength">Destination length</param>
        /// <param name="zoom">The zoom factor</param>
        /// <param name="offset">The relative offset to the center -0.5 .. +0.5</param>
        public static void SmoothCopy(float* srcPtr, float* dstPtr, int sourceLength, int destinationLength, float zoom = 1.0f, float offset = 0.0f)
        {
            if (zoom < 1.0f)
            {
                zoom = 1.0f;
            }

            var r = sourceLength / (zoom * destinationLength);
            
            var offsetBins = sourceLength * (offset + 0.5f * (1.0f - 1.0f / zoom));

            if (r > 1.0f)
            {
                var n = (int) Math.Ceiling(r);
                for (var i = 0; i < destinationLength; i++)
                {
                    var k = (int) (r * (i - 0.5f) + offsetBins);
                    var max = -600.0f;
                    for (var j = 0; j < n; j++)
                    {
                        var index = k + j;
                        if (index >= 0 && index < sourceLength)
                        {
                            if (max < srcPtr[index])
                            {
                                max = srcPtr[index];
                            }
                        }
                    }
                    dstPtr[i] = max;
                }
            }
            else
            {
                for (var i = 0; i < destinationLength; i++)
                {
                    var index = (int) (r * i + offsetBins);
                    if (index >= 0 && index < sourceLength)
                    {
                        dstPtr[i] = srcPtr[index];
                    }
                }
            }
        }

        public static void ApplyFFTWindow(Complex* buffer, float* window, int length)
        {
            for (var i = 0; i < length; i++)
            {
                buffer[i].Real *= window[i];
                buffer[i].Imag *= window[i];
            }
        }
        
        public static void ForwardTransform(Complex* buffer, int length, bool rearrange = true)
        {
            if (length <= MaxLutBins)
            {
                ForwardTransformLut(buffer, length);
            }
            else
            {
                ForwardTransformRot(buffer, length);
            }

            if (rearrange)
            {
                int nd2 = length / 2;
                int nd4 = nd2 / 2;
                for (var i = 0; i < nd4; i++)
                {
                    var t = buffer[i];
                    buffer[i] = buffer[nd2 - i - 1];
                    buffer[nd2 - i - 1] = t;

                    t = buffer[nd2 + i];
                    buffer[nd2 + i] = buffer[nd2 + nd2 - i - 1];
                    buffer[nd2 + nd2 - i - 1] = t;
                }
            }
        }
        public static void InverseTransform(Complex* samples, int length)
        {
            for (int i = 0; i < length; i++)
            {
                samples[i].Imag = -samples[i].Imag;
            }

            ForwardTransform(samples, length, false);

            var factor = 1.0f / length;

            for (int i = 0; i < length; i++)
            {
                samples[i].Real = samples[i].Real * factor;
                samples[i].Imag = -samples[i].Imag * factor;
            }
        }

        private static void ForwardTransformLut(Complex* buffer, int length)
        {
            int nm1 = length - 1;
            int nd2 = length / 2;
            int i, j, jm1, k, l, m, n, le, le2, ip;
            Complex u, t;

            m = 0;
            i = length;
            while (i > 1)
            {
                ++m;
                i = (i >> 1);
            }

            j = nd2;

            for (i = 1; i < nm1; ++i)
            {
                if (i < j)
                {
                    t = buffer[j];
                    buffer[j] = buffer[i];
                    buffer[i] = t;
                }

                k = nd2;

                while (k <= j)
                {
                    j = j - k;
                    k = k / 2;
                }

                j += k;
            }

            for (l = 1; l <= m; ++l)
            {
                le = 1 << l;
                le2 = le / 2;

                n = MaxLutBits - l;

                for (j = 1; j <= le2; ++j)
                {
                    jm1 = j - 1;

                    u = _lut[jm1 << n];

                    for (i = jm1; i <= nm1; i += le)
                    {
                        ip = i + le2;

                        t = u * buffer[ip];
                        buffer[ip] = buffer[i] - t;
                        buffer[i] += t;
                    }
                }
            }
        }

        private static void ForwardTransformRot(Complex* buffer, int length)
        {
            int nm1 = length - 1;
            int nd2 = length / 2;
            int i, j, jm1, k, l, m, le, le2, ip;
            Complex u, t;

            m = 0;
            i = length;
            while (i > 1)
            {
                ++m;
                i = (i >> 1);
            }

            j = nd2;

            for (i = 1; i < nm1; ++i)
            {
                if (i < j)
                {
                    t = buffer[j];
                    buffer[j] = buffer[i];
                    buffer[i] = t;
                }

                k = nd2;

                while (k <= j)
                {
                    j = j - k;
                    k = k / 2;
                }

                j += k;
            }

            for (l = 1; l <= m; ++l)
            {
                le = 1 << l;
                le2 = le / 2;

                var angle = Math.PI / le2;

                for (j = 1; j <= le2; ++j)
                {
                    jm1 = j - 1;

                    u = Complex.FromAngle(angle * jm1).Conjugate();

                    for (i = jm1; i <= nm1; i += le)
                    {
                        ip = i + le2;

                        t = u * buffer[ip];
                        buffer[ip] = buffer[i] - t;
                        buffer[i] += t;
                    }
                }
            }
        }
    }
}
