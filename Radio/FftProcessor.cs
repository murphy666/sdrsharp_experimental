using System;
using SDRSharp.Radio;

namespace SDRSharp.Radio
{
    public unsafe abstract class FftProcessor
    {
        private readonly int _fftSize;
        private readonly int _halfSize;
        private readonly int _overlapSize;
        private readonly float _blendFactor;

        private int _fftBufferPos;
        private int _sampleBufferHead;
        private int _sampleBufferTail;

        private UnsafeBuffer _fftBuffer;
        private Complex* _fftBufferPtr;
                
        private UnsafeBuffer _overlapBuffer;
        private Complex* _overlapBufferPtr;

        private UnsafeBuffer _outOverlapBuffer;
        private Complex* _outOverlapPtr;

        private UnsafeBuffer _sampleBuffer;
        private Complex* _sampleBufferPtr;    
        
        public FftProcessor(int fftSize, float overlapRatio = 0.0f)
        {            
            _fftSize = fftSize;
            _halfSize = fftSize / 2;
            _overlapSize = (int) Math.Ceiling(_fftSize * overlapRatio);
            _fftBufferPos = _halfSize;

            _blendFactor = 1.0f / _overlapSize;

            _fftBuffer = UnsafeBuffer.Create(fftSize, sizeof(Complex));
            _fftBufferPtr = (Complex*)_fftBuffer;

            _outOverlapBuffer = UnsafeBuffer.Create(_overlapSize, sizeof(Complex));
            _outOverlapPtr = (Complex*) _outOverlapBuffer;

            _overlapBuffer = UnsafeBuffer.Create(fftSize / 2, sizeof(Complex));
            _overlapBufferPtr = (Complex*) _overlapBuffer;

            _sampleBuffer = UnsafeBuffer.Create(fftSize, sizeof(Complex));
            _sampleBufferPtr = (Complex*) _sampleBuffer;

            _sampleBufferHead = _halfSize;
        }

        public void Process(Complex* buffer, int length)
        {
            var inOffset = 0;
            var outOffset = 0;            
            while (inOffset < length)
            {
                _fftBufferPtr[_fftBufferPos++] = buffer[inOffset];

                if (_fftBufferPos == _fftSize)
                {
                    for (int i = _halfSize, j = 0; i < _fftSize; i++, j++)
                    {
                        _overlapBufferPtr[j] = _fftBufferPtr[i];
                    }
                    
                    while (outOffset < length && _sampleBufferHead != _sampleBufferTail)
                    {
                        buffer[outOffset] = _sampleBufferPtr[_sampleBufferTail];
                        _sampleBufferTail = (_sampleBufferTail + 1) & (_fftSize - 1);
                        outOffset++;
                    }

                    Fourier.ForwardTransform(_fftBufferPtr, _fftSize, false);
                    
                    ProcessFft(_fftBufferPtr, _fftSize);
                    
                    Fourier.InverseTransform(_fftBufferPtr, _fftSize);

                    for (int i = 0, j = _halfSize - _overlapSize; i < _halfSize; i++, j++)
                    {
                        if (i < _overlapSize)
                        {
                            var alpha = i * _blendFactor;
                            _sampleBufferPtr[_sampleBufferHead] = alpha * _fftBufferPtr[j] + (1.0f - alpha) * _outOverlapPtr[i];
                        }
                        else
                        {
                            _sampleBufferPtr[_sampleBufferHead] = _fftBufferPtr[j];
                        }

                        _sampleBufferHead = (_sampleBufferHead + 1) & (_fftSize - 1);
                    }

                    for (int i = 0, j = _fftSize - _overlapSize; i < _overlapSize; i++, j++)
                    {
                        _outOverlapPtr[i] = _fftBufferPtr[j];
                    }

                    for (var i = 0; i < _halfSize; i++)
                    {
                        _fftBufferPtr[i] = _overlapBufferPtr[i];
                    }
                    _fftBufferPos = _halfSize;
                }

                inOffset++;                
            }

            while (outOffset < length && _sampleBufferHead != _sampleBufferTail)
            {
                buffer[outOffset] = _sampleBufferPtr[_sampleBufferTail];
                _sampleBufferTail = (_sampleBufferTail + 1) & (_fftSize - 1);
                outOffset++;
            }                       
        }

        public void Process(float* buffer, int length, int step = 1)
        {
            var inOffset = 0;
            var outOffset = 0;
            while (inOffset < length)
            {
                _fftBufferPtr[_fftBufferPos++] = buffer[inOffset];

                if (_fftBufferPos == _fftSize)
                {
                    for (int i = _halfSize, j = 0; i < _fftSize; i++, j++)
                    {
                        _overlapBufferPtr[j] = _fftBufferPtr[i].Real;
                    }

                    while (outOffset < length && _sampleBufferHead != _sampleBufferTail)
                    {
                        buffer[outOffset] = _sampleBufferPtr[_sampleBufferTail].Real;
                        _sampleBufferTail = (_sampleBufferTail + 1) & (_fftSize - 1);
                        outOffset += step;
                    }

                    Fourier.ForwardTransform(_fftBufferPtr, _fftSize, false);

                    ProcessFft(_fftBufferPtr, _fftSize);

                    Fourier.InverseTransform(_fftBufferPtr, _fftSize);

                    for (int i = 0, j = _halfSize - _overlapSize; i < _halfSize; i++, j++)
                    {
                        if (i < _overlapSize)
                        {
                            var alpha = i * _blendFactor;
                            _sampleBufferPtr[_sampleBufferHead] = alpha * _fftBufferPtr[j].Real + (1.0f - alpha) * _outOverlapPtr[i];
                        }
                        else
                        {
                            _sampleBufferPtr[_sampleBufferHead] = _fftBufferPtr[j].Real;
                        }

                        _sampleBufferHead = (_sampleBufferHead + 1) & (_fftSize - 1);
                    }

                    for (int i = 0, j = _fftSize - _overlapSize; i < _overlapSize; i++, j++)
                    {
                        _outOverlapPtr[i] = _fftBufferPtr[j].Real;
                    }

                    for (var i = 0; i < _halfSize; i++)
                    {
                        _fftBufferPtr[i] = _overlapBufferPtr[i];
                    }
                    _fftBufferPos = _halfSize;
                }

                inOffset += step;
            }

            while (outOffset < length && _sampleBufferHead != _sampleBufferTail)
            {
                buffer[outOffset] = _sampleBufferPtr[_sampleBufferTail].Real;
                _sampleBufferTail = (_sampleBufferTail + 1) & (_fftSize - 1);
                outOffset += step;
            }
        }

        protected abstract void ProcessFft(Complex* buffer, int length);
    }
}
