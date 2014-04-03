using System;
using System.Windows.Forms;

namespace SDRSharp.NoiseBlanker
{
    public partial class ProcessorPanel : UserControl
    {
        private NoiseBlankerProcessor _processor;

        public ProcessorPanel(NoiseBlankerProcessor processor)
        {
            _processor = processor;
            
            InitializeComponent();

            enableCheckBox.Checked = _processor.Enabled;
            thresholdTrackBar.Value = _processor.NoiseThreshold;
            pulseWidthTrackBar.Value = (int) (_processor.PulseWidth * 10.0);

            thresholdTrackBar_Scroll(null, null);
            pulseWidthTrackBar_Scroll(null, null);
        }
        
        private void enableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _processor.Enabled = enableCheckBox.Checked;
        }

        private void thresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            _processor.NoiseThreshold = thresholdTrackBar.Value;
            thresholdLabel.Text = _processor.NoiseThreshold.ToString();
        }

        private void pulseWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            _processor.PulseWidth = pulseWidthTrackBar.Value * 0.1f;
            pulseWidthLabel.Text = _processor.PulseWidth.ToString("0.00") + " µS";
        }
    }
}
