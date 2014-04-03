using System;
using System.Windows.Forms;

namespace SDRSharp.DNR
{
    public partial class ProcessorPanel : UserControl
    {
        private INoiseProcessor _aControl;
        private INoiseProcessor _iControl;

        public ProcessorPanel(INoiseProcessor iControl, INoiseProcessor aControl)
        {
            _iControl = iControl;
            _aControl = aControl;
            
            InitializeComponent();

            ifThresholdTrackBar.Value = _iControl.NoiseThreshold;
            ifEnableCheckBox.Checked = _iControl.Enabled;

            audioThresholdTrackBar.Value = _aControl.NoiseThreshold;
            audioEnableCheckBox.Checked = _aControl.Enabled;

            ifThresholdTrackBar_Scroll(null, null);
            audioThresholdTrackBar_Scroll(null, null);
        }
        
        private void ifEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _iControl.Enabled = ifEnableCheckBox.Checked;
            ifThresholdTrackBar_Scroll(null, null);
        }

        private void audioEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _aControl.Enabled = audioEnableCheckBox.Checked;
            audioThresholdTrackBar_Scroll(null, null);
        }

        private void ifThresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            ifThresholdLabel.Text = ifThresholdTrackBar.Value + " dB";
            _iControl.NoiseThreshold = ifThresholdTrackBar.Value;
        }

        private void audioThresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            audioThresholdLabel.Text = audioThresholdTrackBar.Value + " dB";
            _aControl.NoiseThreshold = audioThresholdTrackBar.Value;
        }
    }
}
