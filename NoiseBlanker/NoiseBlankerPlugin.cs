using System;
using System.Windows.Forms;
using System.ComponentModel;
using SDRSharp.Common;
using SDRSharp.Radio;

namespace SDRSharp.NoiseBlanker
{
    public class NoiseBlankerPlugin: ISharpPlugin
    {
        private const string _displayName = "Noise Blanker";
        private ISharpControl _control;
        private NoiseBlankerProcessor _processor;
                        
        private ProcessorPanel _guiControl;
        
        public string DisplayName
        {
            get { return _displayName; }
        }

        public bool HasGui
        {
            get { return true; }
        }

        public UserControl GuiControl
        {
            get { return _guiControl; }
        }

        public void Initialize(ISharpControl control)
        {
            _control = control;

            _processor = new NoiseBlankerProcessor();
            _processor.Enabled = Utils.GetBooleanSetting("NBEnabled");
            _processor.NoiseThreshold = Utils.GetIntSetting("NBThreshold", 80);
            _processor.PulseWidth = Utils.GetDoubleSetting("NBPulseWidth", 10);          
            _guiControl = new ProcessorPanel(_processor);

            _control.RegisterStreamHook(_processor, ProcessorType.RawIQ);
        }

        public void Close()
        {
            Utils.SaveSetting("NBEnabled", _processor.Enabled);
            Utils.SaveSetting("NBThreshold", _processor.NoiseThreshold);
            Utils.SaveSetting("NBPulseWidth", _processor.PulseWidth);
        }        
    }
}
