using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace SDRSharp.SDRIP
{
    public partial class SDRIPClientDialog : Form
    {
        private const int Max24BitRate = 1333333;

        private readonly SdrIpIO _owner;

        public string Host
        {
            get { return hostNameTb.Text; }
            set { hostNameTb.Text = value; }
        }

        public int Port
        {
            get { return (int)portNumberUpDown.Value; }
            set { portNumberUpDown.Value = value; }
        }

        public bool Use16Bit
        {
            get { return sampleFormatCombo.SelectedIndex == 1; }
        }

        public int SamepleRateIndex
        {
            get { return samplerateComboBox.SelectedIndex; }
            set { samplerateComboBox.SelectedIndex = value; }
        }

        public int SampleFormatIndex
        {
            get { return sampleFormatCombo.SelectedIndex; }
            set { sampleFormatCombo.SelectedIndex = value; }
        }

        public SDRIPClientDialog(SdrIpIO owner)
        {
            _owner = owner;
            InitializeComponent();

            samplerateComboBox.SelectedIndex = 9;
            sampleFormatCombo.SelectedIndex = 0;
            rfAttenTrackBar.Value = 3;
        }

        private void SDRIPClientDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void samplerateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var samplerateString = samplerateComboBox.Items[samplerateComboBox.SelectedIndex].ToString().Split(' ')[0];
            var sampleRate = double.Parse(samplerateString, CultureInfo.InvariantCulture);
            _owner.Samplerate = (uint)(sampleRate * 1000000.0);
            
            if (_owner.Samplerate > Max24BitRate)
            {
                sampleFormatCombo.SelectedIndex = 1;
            }
            sampleFormatCombo.Enabled = (_owner.Samplerate < Max24BitRate);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            ConfigureGUI();
        }

        private void SDRIPClientDialog_VisibleChanged(object sender, EventArgs e)
        {
            refreshTimer.Enabled = Visible;
            if (Visible)
            {
                ConfigureGUI();
            }            
        }

        private void ConfigureGUI()
        {
            samplerateComboBox.Enabled = !_owner.IsStreaming;
            sampleFormatCombo.Enabled = !_owner.IsStreaming && (_owner.Samplerate < Max24BitRate);
            hostNameTb.Enabled = !_owner.IsStreaming;
            portNumberUpDown.Enabled = !_owner.IsStreaming;

            rfAttenTrackBar.Enabled = _owner.IsStreaming;
            debugLbl.Text = string.Format("Debug: Missed {0} packets", _owner.LostPacketCount);
        }

        private void rfAttenTrackBar_Scroll(object sender, EventArgs e)
        {
            var gain = (rfAttenTrackBar.Maximum - rfAttenTrackBar.Value) * -10;
            _owner.NetworkedDevice.Attentuator = (sbyte)gain;
            rfAttenLabel.Text = gain + " dB";
        }

        private void sampleFormatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _owner.Is16Bit = (sampleFormatCombo.SelectedIndex == 1);
        }
    }
}
