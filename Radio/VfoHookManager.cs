using System.Collections.Generic;
using System.Threading;

namespace SDRSharp.Radio
{
    public enum ProcessorType
    {
        RawIQ,
        FrequencyTranslatedIQ,
        DecimatedAndFilteredIQ,
        DemodulatorOutput,
        FilteredAudioOutput
    }

    public unsafe class VfoHookManager
    {
        #region Private fields

        private readonly List<IRealProcessor> _filteredAudioProcessors = new List<IRealProcessor>();
        private readonly List<IRealProcessor> _demodulatorOutputProcessors = new List<IRealProcessor>();
        private readonly List<IIQProcessor> _rawIQProcessors = new List<IIQProcessor>();
        private readonly List<IIQProcessor> _frequencyTranslatedIQProcessors = new List<IIQProcessor>();
        private readonly List<IIQProcessor> _decimatedAndFilteredIQProcessors = new List<IIQProcessor>();

        #endregion

        public Vfo Vfo { get; set; }

        #region Setup methods

        public void RegisterStreamHook(object hook, ProcessorType processorType)
        {
            switch (processorType)
            {
                case ProcessorType.RawIQ:
                    lock (_rawIQProcessors)
                    {
                        _rawIQProcessors.Add((IIQProcessor) hook);
                    }
                    break;

                case ProcessorType.FrequencyTranslatedIQ:
                    lock (_frequencyTranslatedIQProcessors)
                    {
                        _frequencyTranslatedIQProcessors.Add((IIQProcessor) hook);
                    }
                    break;

                case ProcessorType.DecimatedAndFilteredIQ:
                    lock (_decimatedAndFilteredIQProcessors)
                    {
                        _decimatedAndFilteredIQProcessors.Add((IIQProcessor) hook);
                    }
                    break;

                case ProcessorType.DemodulatorOutput:
                    lock (_demodulatorOutputProcessors)
                    {
                        _demodulatorOutputProcessors.Add((IRealProcessor) hook);
                    }
                    break;

                case ProcessorType.FilteredAudioOutput:
                    lock (_filteredAudioProcessors)
                    {
                        _filteredAudioProcessors.Add((IRealProcessor) hook);
                    }
                    break;
            }
        }

        public void UnregisterStreamHook(object hook)
        {
            if (hook == null)
            {
                return;
            }

            if (hook is IIQProcessor)
            {
                var h = (IIQProcessor) hook;
                lock (_rawIQProcessors)
                {
                    _rawIQProcessors.Remove(h);
                }
                lock (_frequencyTranslatedIQProcessors)
                {
                    _frequencyTranslatedIQProcessors.Remove(h);
                }
                lock (_decimatedAndFilteredIQProcessors)
                {
                    _decimatedAndFilteredIQProcessors.Remove(h);
                }
            }
            else if (hook is IRealProcessor)
            {
                var h = (IRealProcessor)hook;
                lock (_demodulatorOutputProcessors)
                {
                    _demodulatorOutputProcessors.Remove(h);
                }
                lock (_filteredAudioProcessors)
                {
                    _filteredAudioProcessors.Remove(h);
                }
            }
        }

        public void SetProcessorSampleRate(ProcessorType processorType, double sampleRate)
        {
            switch (processorType)
            {
                case ProcessorType.RawIQ:
                    SetSampleRate(_rawIQProcessors, sampleRate);
                    break;

                case ProcessorType.FrequencyTranslatedIQ:
                    SetSampleRate(_frequencyTranslatedIQProcessors, sampleRate);
                    break;

                case ProcessorType.DecimatedAndFilteredIQ:
                    SetSampleRate(_decimatedAndFilteredIQProcessors, sampleRate);
                    break;

                case ProcessorType.DemodulatorOutput:
                    SetSampleRate(_demodulatorOutputProcessors, sampleRate);
                    break;

                case ProcessorType.FilteredAudioOutput:
                    SetSampleRate(_filteredAudioProcessors, sampleRate);
                    break;
            }
        }
        
        #endregion

        #region Hooks

        public void ProcessRawIQ(Complex* buffer, int length)
        {
            ProcessHooks(_rawIQProcessors, buffer, length);
        }

        public void ProcessDecimatedAndFilteredIQ(Complex* buffer, int length)
        {
            ProcessHooks(_decimatedAndFilteredIQProcessors, buffer, length);
        }

        public void ProcessFrequencyTranslatedIQ(Complex* buffer, int length)
        {
            ProcessHooks(_frequencyTranslatedIQProcessors, buffer, length);
        }

        public void ProcessDemodulatorOutput(float* buffer, int length)
        {
            ProcessHooks(_demodulatorOutputProcessors, buffer, length);
        }

        public void ProcessFilteredAudioOutput(float* buffer, int length)
        {
            ProcessHooks(_filteredAudioProcessors, buffer, length);
        }

        #endregion

        #region Utils

        private void SetSampleRate(List<IIQProcessor> processors, double sampleRate)
        {
            lock (processors)
            {
                for (int i = 0; i < processors.Count; i++)
                {
                    processors[i].SampleRate = sampleRate;
                }
            }
        }

        private void SetSampleRate(List<IRealProcessor> processors, double sampleRate)
        {
            lock (processors)
            {
                for (int i = 0; i < processors.Count; i++)
                {
                    processors[i].SampleRate = sampleRate;
                }
            }
        }

        private void ProcessHooks(List<IIQProcessor> processors, Complex* buffer, int length)
        {
            lock (processors)
            {
                for (int i = 0; i < processors.Count; i++)
                {
                    if (processors[i].Enabled)
                    {
                        processors[i].Process(buffer, length);
                    }
                }
            }
        }

        private void ProcessHooks(List<IRealProcessor> processors, float* buffer, int length)
        {
            lock (processors)
            {
                for (int i = 0; i < processors.Count; i++)
                {
                    if (processors[i].Enabled)
                    {
                        processors[i].Process(buffer, length);
                    }
                }
            }
        }

        #endregion
    }
}
