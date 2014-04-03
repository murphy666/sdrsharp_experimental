using System;
using System.Windows.Forms;
using System.ComponentModel;
using SDRSharp.Common;
using SDRSharp.Radio;

namespace SDRSharp.DNR
{
    public class DNRPlugin: ISharpPlugin
    {
        private const string _displayName = "Digital Noise Reduction";
        private ISharpControl _control;
        private AudioProcessor _audioProcessor;
        private IFProcessor _ifProcessor;
                        
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
            _audioProcessor = new AudioProcessor();
            _control.RegisterStreamHook(_audioProcessor, ProcessorType.FilteredAudioOutput);

            _ifProcessor = new IFProcessor();
            _control.RegisterStreamHook(_ifProcessor, ProcessorType.DecimatedAndFilteredIQ);
            
            _ifProcessor.NoiseThreshold = Utils.GetIntSetting("DNRIThreshold", -30);
            _ifProcessor.Enabled = Utils.GetBooleanSetting("DNRIEnabled");
            _audioProcessor.NoiseThreshold = Utils.GetIntSetting("DNRAThreshold", -70);
            _audioProcessor.Enabled = Utils.GetBooleanSetting("DNRAEnabled");
            
            _guiControl = new ProcessorPanel(_ifProcessor, _audioProcessor);
        }

        public void Close()
        {
            Utils.SaveSetting("DNRIThreshold", _ifProcessor.NoiseThreshold);
            Utils.SaveSetting("DNRIEnabled", _ifProcessor.Enabled);
            Utils.SaveSetting("DNRAThreshold", _audioProcessor.NoiseThreshold);
            Utils.SaveSetting("DNRAEnabled", _audioProcessor.Enabled);
        }        
    }
}
