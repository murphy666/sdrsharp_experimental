using System.Windows.Forms;
using SDRSharp.CollapsiblePanel;
using SDRSharp.PanView;

namespace SDRSharp
{
    public partial class MainForm
    {
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.panSplitContainer = new System.Windows.Forms.SplitContainer();
            this.spectrumAnalyzer = new SDRSharp.PanView.SpectrumAnalyzer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.waterfall = new SDRSharp.PanView.Waterfall();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWaterfallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iqTimer = new System.Windows.Forms.Timer(this.components);
            this.useSquelchCheckBox = new System.Windows.Forms.CheckBox();
            this.fmStereoCheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cwShiftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.squelchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.unityGainCheckBox = new System.Windows.Forms.CheckBox();
            this.latencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filterAudioCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sampleRateComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.outputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.inputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.frequencyShiftCheckBox = new System.Windows.Forms.CheckBox();
            this.filterBandwidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.audioGainTrackBar = new System.Windows.Forms.TrackBar();
            this.rawRadioButton = new System.Windows.Forms.RadioButton();
            this.cwRadioButton = new System.Windows.Forms.RadioButton();
            this.nfmRadioButton = new System.Windows.Forms.RadioButton();
            this.dsbRadioButton = new System.Windows.Forms.RadioButton();
            this.wfmRadioButton = new System.Windows.Forms.RadioButton();
            this.amRadioButton = new System.Windows.Forms.RadioButton();
            this.lsbRadioButton = new System.Windows.Forms.RadioButton();
            this.usbRadioButton = new System.Windows.Forms.RadioButton();
            this.iqSourceComboBox = new System.Windows.Forms.ComboBox();
            this.FrequencyUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.stepSizeComboBox = new System.Windows.Forms.ComboBox();
            this.configureSourceButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MemFreq7 = new System.Windows.Forms.NumericUpDown();
            this.MemFreq8 = new System.Windows.Forms.NumericUpDown();
            this.MemFreq9 = new System.Windows.Forms.NumericUpDown();
            this.MemFreq0 = new System.Windows.Forms.NumericUpDown();
            this.MemFreq6 = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.MemFreq2 = new System.Windows.Forms.NumericUpDown();
            this.MemFreq3 = new System.Windows.Forms.NumericUpDown();
            this.MemFreq4 = new System.Windows.Forms.NumericUpDown();
            this.MemFreq5 = new System.Windows.Forms.NumericUpDown();
            this.MemFreq1 = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterOrderNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.agcUseHangCheckBox = new System.Windows.Forms.CheckBox();
            this.agcSlopeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.agcCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.agcThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.agcDecayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label43 = new System.Windows.Forms.Label();
            this.ScanDb = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.frequencyShiftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.snapFrequencyCheckBox = new System.Windows.Forms.CheckBox();
            this.swapIQCheckBox = new System.Windows.Forms.CheckBox();
            this.correctIQCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.viewComboBox = new System.Windows.Forms.ComboBox();
            this.fftWindowComboBox = new System.Windows.Forms.ComboBox();
            this.markPeaksCheckBox = new System.Windows.Forms.CheckBox();
            this.useTimestampsCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gradientButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.fftResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.fftZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.fftContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.fftOffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fftSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.fftRangeTrackBar = new System.Windows.Forms.TrackBar();
            this.sAttackTrackBar = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.wDecayTrackBar = new System.Windows.Forms.TrackBar();
            this.label25 = new System.Windows.Forms.Label();
            this.wAttackTrackBar = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.sDecayTrackBar = new System.Windows.Forms.TrackBar();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.displayCollapsiblePanel = new SDRSharp.CollapsiblePanel.CollapsiblePanel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.vfoFrequencyEdit = new SDRSharp.FrequencyEdit.FrequencyEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.panSplitContainer.Panel1.SuspendLayout();
            this.panSplitContainer.Panel2.SuspendLayout();
            this.panSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cwShiftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squelchNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBandwidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioGainTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterOrderNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agcSlopeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agcThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agcDecayNumericUpDown)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScanDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyShiftNumericUpDown)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fftZoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftOffsetTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fftSpeedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftRangeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAttackTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wDecayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAttackTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDecayTrackBar)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDlg
            // 
            this.openDlg.DefaultExt = "wav";
            this.openDlg.Filter = "WAV files|*.wav";
            // 
            // panSplitContainer
            // 
            this.panSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSplitContainer.Location = new System.Drawing.Point(10, 115);
            this.panSplitContainer.Name = "panSplitContainer";
            this.panSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panSplitContainer.Panel1
            // 
            this.panSplitContainer.Panel1.Controls.Add(this.spectrumAnalyzer);
            this.panSplitContainer.Panel1.Controls.Add(this.trackBar1);
            this.panSplitContainer.Panel1MinSize = 10;
            // 
            // panSplitContainer.Panel2
            // 
            this.panSplitContainer.Panel2.Controls.Add(this.waterfall);
            this.panSplitContainer.Panel2MinSize = 10;
            this.panSplitContainer.Size = new System.Drawing.Size(1410, 340);
            this.panSplitContainer.SplitterDistance = 80;
            this.panSplitContainer.TabIndex = 13;
            // 
            // spectrumAnalyzer
            // 
            this.spectrumAnalyzer.Attack = 0.9F;
            this.spectrumAnalyzer.BandType = SDRSharp.PanView.BandType.Center;
            this.spectrumAnalyzer.CenterFrequency = ((long)(0));
            this.spectrumAnalyzer.Decay = 0.3F;
            this.spectrumAnalyzer.DisplayOffset = 0;
            this.spectrumAnalyzer.DisplayRange = 130;
            this.spectrumAnalyzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrumAnalyzer.EnableFilter = true;
            this.spectrumAnalyzer.FilterBandwidth = 10000;
            this.spectrumAnalyzer.FilterOffset = 100;
            this.spectrumAnalyzer.Frequency = ((long)(0));
            this.spectrumAnalyzer.Location = new System.Drawing.Point(0, 0);
            this.spectrumAnalyzer.MarkPeaks = false;
            this.spectrumAnalyzer.Name = "spectrumAnalyzer";
            this.spectrumAnalyzer.Size = new System.Drawing.Size(1410, 80);
            this.spectrumAnalyzer.SpectrumWidth = 48000;
            this.spectrumAnalyzer.StatusText = null;
            this.spectrumAnalyzer.StepSize = 1000;
            this.spectrumAnalyzer.TabIndex = 0;
            this.spectrumAnalyzer.UseSmoothing = true;
            this.spectrumAnalyzer.UseSnap = false;
            this.spectrumAnalyzer.Zoom = 0;
            this.spectrumAnalyzer.FrequencyChanged += new SDRSharp.PanView.ManualFrequencyChange(this.panview_FrequencyChanged);
            this.spectrumAnalyzer.CenterFrequencyChanged += new SDRSharp.PanView.ManualFrequencyChange(this.panview_CenterFrequencyChanged);
            this.spectrumAnalyzer.BandwidthChanged += new SDRSharp.PanView.ManualBandwidthChange(this.panview_BandwidthChanged);
            this.spectrumAnalyzer.Load += new System.EventHandler(this.spectrumAnalyzer_Load);
            this.spectrumAnalyzer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spectrumAnalyzer_KeyDown);
            this.spectrumAnalyzer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spectrumAnalyzer_KeyPress);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(461, -22);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(105, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 30;
            this.trackBar1.ValueChanged += new System.EventHandler(this.audioGainTrackBar_ValueChanged);
            // 
            // waterfall
            // 
            this.waterfall.AllowDrop = true;
            this.waterfall.Attack = 0.9F;
            this.waterfall.BandType = SDRSharp.PanView.BandType.Center;
            this.waterfall.CenterFrequency = ((long)(0));
            this.waterfall.ContextMenuStrip = this.contextMenuStrip1;
            this.waterfall.Contrast = 0;
            this.waterfall.Decay = 0.5F;
            this.waterfall.DisplayOffset = 0;
            this.waterfall.DisplayRange = 130;
            this.waterfall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterfall.FilterBandwidth = 10000;
            this.waterfall.FilterOffset = 0;
            this.waterfall.Frequency = ((long)(0));
            this.waterfall.Location = new System.Drawing.Point(0, 0);
            this.waterfall.Name = "waterfall";
            this.waterfall.Size = new System.Drawing.Size(1410, 256);
            this.waterfall.SpectrumWidth = 48000;
            this.waterfall.StepSize = 0;
            this.waterfall.TabIndex = 0;
            this.waterfall.TimestampInterval = 100;
            this.waterfall.UseSmoothing = true;
            this.waterfall.UseSnap = false;
            this.waterfall.UseTimestamps = false;
            this.waterfall.Zoom = 0;
            this.waterfall.FrequencyChanged += new SDRSharp.PanView.ManualFrequencyChange(this.panview_FrequencyChanged);
            this.waterfall.CenterFrequencyChanged += new SDRSharp.PanView.ManualFrequencyChange(this.panview_CenterFrequencyChanged);
            this.waterfall.BandwidthChanged += new SDRSharp.PanView.ManualBandwidthChange(this.panview_BandwidthChanged);
            this.waterfall.Load += new System.EventHandler(this.waterfall_Load);
            this.waterfall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.waterfall_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.saveWaterfallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 52);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.testToolStripMenuItem.Text = "Save Frequency...";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // saveWaterfallToolStripMenuItem
            // 
            this.saveWaterfallToolStripMenuItem.Name = "saveWaterfallToolStripMenuItem";
            this.saveWaterfallToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.saveWaterfallToolStripMenuItem.Text = "Save Waterfall...";
            // 
            // iqTimer
            // 
            this.iqTimer.Enabled = true;
            this.iqTimer.Interval = 500;
            this.iqTimer.Tick += new System.EventHandler(this.iqTimer_Tick);
            // 
            // useSquelchCheckBox
            // 
            this.useSquelchCheckBox.Location = new System.Drawing.Point(388, 11);
            this.useSquelchCheckBox.Name = "useSquelchCheckBox";
            this.useSquelchCheckBox.Size = new System.Drawing.Size(83, 26);
            this.useSquelchCheckBox.TabIndex = 17;
            this.useSquelchCheckBox.Text = "Squelch";
            this.useSquelchCheckBox.UseVisualStyleBackColor = true;
            this.useSquelchCheckBox.CheckedChanged += new System.EventHandler(this.useSquelchCheckBox_CheckedChanged);
            // 
            // fmStereoCheckBox
            // 
            this.fmStereoCheckBox.Enabled = false;
            this.fmStereoCheckBox.Location = new System.Drawing.Point(248, 30);
            this.fmStereoCheckBox.Name = "fmStereoCheckBox";
            this.fmStereoCheckBox.Size = new System.Drawing.Size(113, 20);
            this.fmStereoCheckBox.TabIndex = 24;
            this.fmStereoCheckBox.Text = "FM Stereo";
            this.fmStereoCheckBox.UseVisualStyleBackColor = true;
            this.fmStereoCheckBox.CheckedChanged += new System.EventHandler(this.fmStereoCheckBox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(403, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "CW Shift";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cwShiftNumericUpDown
            // 
            this.cwShiftNumericUpDown.Enabled = false;
            this.cwShiftNumericUpDown.Location = new System.Drawing.Point(477, 37);
            this.cwShiftNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.cwShiftNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.cwShiftNumericUpDown.Name = "cwShiftNumericUpDown";
            this.cwShiftNumericUpDown.Size = new System.Drawing.Size(51, 22);
            this.cwShiftNumericUpDown.TabIndex = 19;
            this.cwShiftNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cwShiftNumericUpDown.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.cwShiftNumericUpDown.ValueChanged += new System.EventHandler(this.cwShiftNumericUpDown_ValueChanged);
            // 
            // squelchNumericUpDown
            // 
            this.squelchNumericUpDown.Enabled = false;
            this.squelchNumericUpDown.Location = new System.Drawing.Point(477, 11);
            this.squelchNumericUpDown.Name = "squelchNumericUpDown";
            this.squelchNumericUpDown.Size = new System.Drawing.Size(51, 22);
            this.squelchNumericUpDown.TabIndex = 18;
            this.squelchNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.squelchNumericUpDown.ValueChanged += new System.EventHandler(this.squelchNumericUpDown_ValueChanged);
            // 
            // unityGainCheckBox
            // 
            this.unityGainCheckBox.Location = new System.Drawing.Point(723, 43);
            this.unityGainCheckBox.Name = "unityGainCheckBox";
            this.unityGainCheckBox.Size = new System.Drawing.Size(104, 20);
            this.unityGainCheckBox.TabIndex = 5;
            this.unityGainCheckBox.Text = "Unity Gain";
            this.unityGainCheckBox.UseVisualStyleBackColor = true;
            this.unityGainCheckBox.CheckStateChanged += new System.EventHandler(this.unityGainCheckBox_CheckStateChanged);
            // 
            // latencyNumericUpDown
            // 
            this.latencyNumericUpDown.Location = new System.Drawing.Point(322, 6);
            this.latencyNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.latencyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.latencyNumericUpDown.Name = "latencyNumericUpDown";
            this.latencyNumericUpDown.Size = new System.Drawing.Size(65, 22);
            this.latencyNumericUpDown.TabIndex = 4;
            this.latencyNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.latencyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // filterAudioCheckBox
            // 
            this.filterAudioCheckBox.Location = new System.Drawing.Point(405, 43);
            this.filterAudioCheckBox.Name = "filterAudioCheckBox";
            this.filterAudioCheckBox.Size = new System.Drawing.Size(104, 20);
            this.filterAudioCheckBox.TabIndex = 6;
            this.filterAudioCheckBox.Text = "Filter Audio";
            this.filterAudioCheckBox.UseVisualStyleBackColor = true;
            this.filterAudioCheckBox.CheckedChanged += new System.EventHandler(this.filterAudioCheckBox_CheckStateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Latency (ms)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Samplerate";
            // 
            // sampleRateComboBox
            // 
            this.sampleRateComboBox.FormattingEnabled = true;
            this.sampleRateComboBox.Items.AddRange(new object[] {
            "8000 sample/sec",
            "11025 sample/sec",
            "16000 sample/sec",
            "22050 sample/sec",
            "24000 sample/sec",
            "32000 sample/sec",
            "44100 sample/sec",
            "48000 sample/sec",
            "80000 sample/sec",
            "96000 sample/sec",
            "120000 sample/sec",
            "125000 sample/sec",
            "150000 sample/sec",
            "192000 sample/sec"});
            this.sampleRateComboBox.Location = new System.Drawing.Point(92, 9);
            this.sampleRateComboBox.Name = "sampleRateComboBox";
            this.sampleRateComboBox.Size = new System.Drawing.Size(125, 24);
            this.sampleRateComboBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Output";
            // 
            // outputDeviceComboBox
            // 
            this.outputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDeviceComboBox.DropDownWidth = 300;
            this.outputDeviceComboBox.FormattingEnabled = true;
            this.outputDeviceComboBox.Location = new System.Drawing.Point(60, 48);
            this.outputDeviceComboBox.Name = "outputDeviceComboBox";
            this.outputDeviceComboBox.Size = new System.Drawing.Size(209, 24);
            this.outputDeviceComboBox.TabIndex = 3;
            // 
            // inputDeviceComboBox
            // 
            this.inputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDeviceComboBox.DropDownWidth = 300;
            this.inputDeviceComboBox.FormattingEnabled = true;
            this.inputDeviceComboBox.Location = new System.Drawing.Point(60, 9);
            this.inputDeviceComboBox.Name = "inputDeviceComboBox";
            this.inputDeviceComboBox.Size = new System.Drawing.Size(209, 24);
            this.inputDeviceComboBox.TabIndex = 2;
            this.inputDeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDeviceComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Input";
            // 
            // frequencyShiftCheckBox
            // 
            this.frequencyShiftCheckBox.AutoSize = true;
            this.frequencyShiftCheckBox.Location = new System.Drawing.Point(248, 9);
            this.frequencyShiftCheckBox.Name = "frequencyShiftCheckBox";
            this.frequencyShiftCheckBox.Size = new System.Drawing.Size(130, 21);
            this.frequencyShiftCheckBox.TabIndex = 10;
            this.frequencyShiftCheckBox.Text = "HF Upconverter";
            this.frequencyShiftCheckBox.UseVisualStyleBackColor = true;
            this.frequencyShiftCheckBox.CheckedChanged += new System.EventHandler(this.frequencyShiftCheckBox_CheckStateChanged);
            // 
            // filterBandwidthNumericUpDown
            // 
            this.filterBandwidthNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.filterBandwidthNumericUpDown.Location = new System.Drawing.Point(91, 6);
            this.filterBandwidthNumericUpDown.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.filterBandwidthNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.filterBandwidthNumericUpDown.Name = "filterBandwidthNumericUpDown";
            this.filterBandwidthNumericUpDown.Size = new System.Drawing.Size(88, 22);
            this.filterBandwidthNumericUpDown.TabIndex = 15;
            this.filterBandwidthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.filterBandwidthNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.filterBandwidthNumericUpDown.ValueChanged += new System.EventHandler(this.filterBandwidthNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bandwidth";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // audioGainTrackBar
            // 
            this.audioGainTrackBar.Location = new System.Drawing.Point(187, 72);
            this.audioGainTrackBar.Maximum = 40;
            this.audioGainTrackBar.Minimum = 15;
            this.audioGainTrackBar.Name = "audioGainTrackBar";
            this.audioGainTrackBar.RightToLeftLayout = true;
            this.audioGainTrackBar.Size = new System.Drawing.Size(138, 56);
            this.audioGainTrackBar.TabIndex = 0;
            this.audioGainTrackBar.TickFrequency = 5;
            this.audioGainTrackBar.Value = 30;
            this.audioGainTrackBar.Scroll += new System.EventHandler(this.audioGainTrackBar_Scroll);
            this.audioGainTrackBar.ValueChanged += new System.EventHandler(this.audioGainTrackBar_ValueChanged);
            // 
            // rawRadioButton
            // 
            this.rawRadioButton.AutoSize = true;
            this.rawRadioButton.Location = new System.Drawing.Point(185, 29);
            this.rawRadioButton.Name = "rawRadioButton";
            this.rawRadioButton.Size = new System.Drawing.Size(61, 21);
            this.rawRadioButton.TabIndex = 7;
            this.rawRadioButton.Text = "RAW";
            this.rawRadioButton.UseVisualStyleBackColor = true;
            this.rawRadioButton.CheckedChanged += new System.EventHandler(this.modeRadioButton_CheckStateChanged);
            // 
            // cwRadioButton
            // 
            this.cwRadioButton.AutoSize = true;
            this.cwRadioButton.Location = new System.Drawing.Point(69, 29);
            this.cwRadioButton.Name = "cwRadioButton";
            this.cwRadioButton.Size = new System.Drawing.Size(51, 21);
            this.cwRadioButton.TabIndex = 6;
            this.cwRadioButton.Text = "CW";
            this.cwRadioButton.UseVisualStyleBackColor = true;
            this.cwRadioButton.CheckedChanged += new System.EventHandler(this.modeRadioButton_CheckStateChanged);
            // 
            // nfmRadioButton
            // 
            this.nfmRadioButton.AutoSize = true;
            this.nfmRadioButton.Location = new System.Drawing.Point(6, 8);
            this.nfmRadioButton.Name = "nfmRadioButton";
            this.nfmRadioButton.Size = new System.Drawing.Size(58, 21);
            this.nfmRadioButton.TabIndex = 0;
            this.nfmRadioButton.Text = "NFM";
            this.nfmRadioButton.UseVisualStyleBackColor = true;
            this.nfmRadioButton.CheckedChanged += new System.EventHandler(this.modeRadioButton_CheckStateChanged);
            // 
            // dsbRadioButton
            // 
            this.dsbRadioButton.AutoSize = true;
            this.dsbRadioButton.Location = new System.Drawing.Point(126, 29);
            this.dsbRadioButton.Name = "dsbRadioButton";
            this.dsbRadioButton.Size = new System.Drawing.Size(57, 21);
            this.dsbRadioButton.TabIndex = 5;
            this.dsbRadioButton.Text = "DSB";
            this.dsbRadioButton.UseVisualStyleBackColor = true;
            this.dsbRadioButton.CheckedChanged += new System.EventHandler(this.modeRadioButton_CheckStateChanged);
            // 
            // wfmRadioButton
            // 
            this.wfmRadioButton.AutoSize = true;
            this.wfmRadioButton.Location = new System.Drawing.Point(6, 29);
            this.wfmRadioButton.Name = "wfmRadioButton";
            this.wfmRadioButton.Size = new System.Drawing.Size(61, 21);
            this.wfmRadioButton.TabIndex = 4;
            this.wfmRadioButton.Text = "WFM";
            this.wfmRadioButton.UseVisualStyleBackColor = true;
            this.wfmRadioButton.CheckedChanged += new System.EventHandler(this.modeRadioButton_CheckStateChanged);
            // 
            // amRadioButton
            // 
            this.amRadioButton.AutoSize = true;
            this.amRadioButton.Location = new System.Drawing.Point(69, 8);
            this.amRadioButton.Name = "amRadioButton";
            this.amRadioButton.Size = new System.Drawing.Size(49, 21);
            this.amRadioButton.TabIndex = 1;
            this.amRadioButton.Text = "AM";
            this.amRadioButton.UseVisualStyleBackColor = true;
            this.amRadioButton.CheckedChanged += new System.EventHandler(this.modeRadioButton_CheckStateChanged);
            // 
            // lsbRadioButton
            // 
            this.lsbRadioButton.AutoSize = true;
            this.lsbRadioButton.Location = new System.Drawing.Point(126, 8);
            this.lsbRadioButton.Name = "lsbRadioButton";
            this.lsbRadioButton.Size = new System.Drawing.Size(55, 21);
            this.lsbRadioButton.TabIndex = 2;
            this.lsbRadioButton.Text = "LSB";
            this.lsbRadioButton.UseVisualStyleBackColor = true;
            this.lsbRadioButton.CheckedChanged += new System.EventHandler(this.modeRadioButton_CheckStateChanged);
            // 
            // usbRadioButton
            // 
            this.usbRadioButton.AutoSize = true;
            this.usbRadioButton.Location = new System.Drawing.Point(185, 8);
            this.usbRadioButton.Name = "usbRadioButton";
            this.usbRadioButton.Size = new System.Drawing.Size(57, 21);
            this.usbRadioButton.TabIndex = 3;
            this.usbRadioButton.Text = "USB";
            this.usbRadioButton.UseVisualStyleBackColor = true;
            this.usbRadioButton.CheckedChanged += new System.EventHandler(this.modeRadioButton_CheckStateChanged);
            // 
            // iqSourceComboBox
            // 
            this.iqSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iqSourceComboBox.DropDownWidth = 135;
            this.iqSourceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iqSourceComboBox.FormattingEnabled = true;
            this.iqSourceComboBox.Location = new System.Drawing.Point(566, 22);
            this.iqSourceComboBox.Name = "iqSourceComboBox";
            this.iqSourceComboBox.Size = new System.Drawing.Size(143, 28);
            this.iqSourceComboBox.TabIndex = 2;
            this.iqSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.iqSourceComboBox_SelectedIndexChanged);
            // 
            // FrequencyUpDown
            // 
            this.FrequencyUpDown.BackColor = System.Drawing.Color.Black;
            this.FrequencyUpDown.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyUpDown.ForeColor = System.Drawing.Color.Lime;
            this.FrequencyUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FrequencyUpDown.Location = new System.Drawing.Point(10, 16);
            this.FrequencyUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.FrequencyUpDown.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.FrequencyUpDown.Name = "FrequencyUpDown";
            this.FrequencyUpDown.Size = new System.Drawing.Size(255, 49);
            this.FrequencyUpDown.TabIndex = 34;
            this.FrequencyUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FrequencyUpDown.ThousandsSeparator = true;
            this.FrequencyUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.FrequencyUpDown.Value = new decimal(new int[] {
            123,
            0,
            0,
            0});
            this.FrequencyUpDown.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.FrequencyUpDown.Validated += new System.EventHandler(this.FrequencyUpDown_Validated);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(266, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "KHz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(239, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Gain";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(322, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1218, 107);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.squelchNumericUpDown);
            this.tabPage1.Controls.Add(this.useSquelchCheckBox);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.fmStereoCheckBox);
            this.tabPage1.Controls.Add(this.cwShiftNumericUpDown);
            this.tabPage1.Controls.Add(this.wfmRadioButton);
            this.tabPage1.Controls.Add(this.dsbRadioButton);
            this.tabPage1.Controls.Add(this.frequencyShiftCheckBox);
            this.tabPage1.Controls.Add(this.cwRadioButton);
            this.tabPage1.Controls.Add(this.rawRadioButton);
            this.tabPage1.Controls.Add(this.usbRadioButton);
            this.tabPage1.Controls.Add(this.lsbRadioButton);
            this.tabPage1.Controls.Add(this.amRadioButton);
            this.tabPage1.Controls.Add(this.nfmRadioButton);
            this.tabPage1.Controls.Add(this.iqSourceComboBox);
            this.tabPage1.Controls.Add(this.configureSourceButton);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1210, 78);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Receiver";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.filterBandwidthNumericUpDown);
            this.panel3.Controls.Add(this.stepSizeComboBox);
            this.panel3.Location = new System.Drawing.Point(3, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 32);
            this.panel3.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(207, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "Seek";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stepSizeComboBox
            // 
            this.stepSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepSizeComboBox.FormattingEnabled = true;
            this.stepSizeComboBox.Location = new System.Drawing.Point(245, 4);
            this.stepSizeComboBox.Name = "stepSizeComboBox";
            this.stepSizeComboBox.Size = new System.Drawing.Size(92, 24);
            this.stepSizeComboBox.TabIndex = 21;
            this.stepSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.stepSizeComboBox_SelectedIndexChanged);
            // 
            // configureSourceButton
            // 
            this.configureSourceButton.FlatAppearance.BorderSize = 0;
            this.configureSourceButton.Image = global::SDRSharp.Properties.Resources.configure_4;
            this.configureSourceButton.Location = new System.Drawing.Point(715, 18);
            this.configureSourceButton.Name = "configureSourceButton";
            this.configureSourceButton.Size = new System.Drawing.Size(41, 35);
            this.configureSourceButton.TabIndex = 3;
            this.configureSourceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.configureSourceButton.UseVisualStyleBackColor = true;
            this.configureSourceButton.Click += new System.EventHandler(this.frontendGuiButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MemFreq7);
            this.tabPage2.Controls.Add(this.MemFreq8);
            this.tabPage2.Controls.Add(this.MemFreq9);
            this.tabPage2.Controls.Add(this.MemFreq0);
            this.tabPage2.Controls.Add(this.MemFreq6);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.label42);
            this.tabPage2.Controls.Add(this.MemFreq2);
            this.tabPage2.Controls.Add(this.MemFreq3);
            this.tabPage2.Controls.Add(this.MemFreq4);
            this.tabPage2.Controls.Add(this.MemFreq5);
            this.tabPage2.Controls.Add(this.MemFreq1);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.ImageIndex = 5;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1210, 78);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Bookmarks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MemFreq7
            // 
            this.MemFreq7.Location = new System.Drawing.Point(212, 43);
            this.MemFreq7.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq7.Name = "MemFreq7";
            this.MemFreq7.Size = new System.Drawing.Size(134, 22);
            this.MemFreq7.TabIndex = 30;
            this.MemFreq7.ThousandsSeparator = true;
            // 
            // MemFreq8
            // 
            this.MemFreq8.Location = new System.Drawing.Point(384, 43);
            this.MemFreq8.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq8.Name = "MemFreq8";
            this.MemFreq8.Size = new System.Drawing.Size(134, 22);
            this.MemFreq8.TabIndex = 29;
            this.MemFreq8.ThousandsSeparator = true;
            // 
            // MemFreq9
            // 
            this.MemFreq9.Location = new System.Drawing.Point(557, 43);
            this.MemFreq9.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq9.Name = "MemFreq9";
            this.MemFreq9.Size = new System.Drawing.Size(134, 22);
            this.MemFreq9.TabIndex = 28;
            this.MemFreq9.ThousandsSeparator = true;
            // 
            // MemFreq0
            // 
            this.MemFreq0.Location = new System.Drawing.Point(730, 43);
            this.MemFreq0.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq0.Name = "MemFreq0";
            this.MemFreq0.Size = new System.Drawing.Size(134, 22);
            this.MemFreq0.TabIndex = 27;
            this.MemFreq0.ThousandsSeparator = true;
            this.MemFreq0.ValueChanged += new System.EventHandler(this.MemFreq0_ValueChanged);
            // 
            // MemFreq6
            // 
            this.MemFreq6.Location = new System.Drawing.Point(39, 43);
            this.MemFreq6.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq6.Name = "MemFreq6";
            this.MemFreq6.Size = new System.Drawing.Size(134, 22);
            this.MemFreq6.TabIndex = 26;
            this.MemFreq6.ThousandsSeparator = true;
            this.MemFreq6.Value = new decimal(new int[] {
            11111110,
            0,
            0,
            0});
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(697, 45);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(27, 17);
            this.label36.TabIndex = 25;
            this.label36.Text = "M0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(352, 45);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(27, 17);
            this.label38.TabIndex = 24;
            this.label38.Text = "M8";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(524, 45);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(27, 17);
            this.label40.TabIndex = 23;
            this.label40.Text = "M9";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(179, 45);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(27, 17);
            this.label41.TabIndex = 22;
            this.label41.Text = "M7";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 45);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(27, 17);
            this.label42.TabIndex = 21;
            this.label42.Text = "M6";
            // 
            // MemFreq2
            // 
            this.MemFreq2.Location = new System.Drawing.Point(212, 11);
            this.MemFreq2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq2.Name = "MemFreq2";
            this.MemFreq2.Size = new System.Drawing.Size(134, 22);
            this.MemFreq2.TabIndex = 20;
            this.MemFreq2.ThousandsSeparator = true;
            // 
            // MemFreq3
            // 
            this.MemFreq3.Location = new System.Drawing.Point(384, 11);
            this.MemFreq3.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq3.Name = "MemFreq3";
            this.MemFreq3.Size = new System.Drawing.Size(134, 22);
            this.MemFreq3.TabIndex = 19;
            this.MemFreq3.ThousandsSeparator = true;
            // 
            // MemFreq4
            // 
            this.MemFreq4.Location = new System.Drawing.Point(557, 11);
            this.MemFreq4.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq4.Name = "MemFreq4";
            this.MemFreq4.Size = new System.Drawing.Size(134, 22);
            this.MemFreq4.TabIndex = 18;
            this.MemFreq4.ThousandsSeparator = true;
            // 
            // MemFreq5
            // 
            this.MemFreq5.Location = new System.Drawing.Point(730, 11);
            this.MemFreq5.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq5.Name = "MemFreq5";
            this.MemFreq5.Size = new System.Drawing.Size(134, 22);
            this.MemFreq5.TabIndex = 16;
            this.MemFreq5.ThousandsSeparator = true;
            // 
            // MemFreq1
            // 
            this.MemFreq1.Location = new System.Drawing.Point(39, 11);
            this.MemFreq1.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MemFreq1.Name = "MemFreq1";
            this.MemFreq1.Size = new System.Drawing.Size(134, 22);
            this.MemFreq1.TabIndex = 15;
            this.MemFreq1.ThousandsSeparator = true;
            this.MemFreq1.Value = new decimal(new int[] {
            11111110,
            0,
            0,
            0});
            this.MemFreq1.ValueChanged += new System.EventHandler(this.MemFreq1_ValueChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(697, 13);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(27, 17);
            this.label37.TabIndex = 14;
            this.label37.Text = "M5";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(352, 13);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 17);
            this.label39.TabIndex = 12;
            this.label39.Text = "M3";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(524, 13);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(27, 17);
            this.label35.TabIndex = 7;
            this.label35.Text = "M4";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(491, 13);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 17);
            this.label34.TabIndex = 6;
            this.label34.Text = "M4";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(179, 13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(27, 17);
            this.label33.TabIndex = 5;
            this.label33.Text = "M2";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 13);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(27, 17);
            this.label32.TabIndex = 4;
            this.label32.Text = "M1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.filterTypeComboBox);
            this.tabPage3.Controls.Add(this.filterOrderNumericUpDown);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.agcUseHangCheckBox);
            this.tabPage3.Controls.Add(this.agcSlopeNumericUpDown);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.agcCheckBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.agcThresholdNumericUpDown);
            this.tabPage3.Controls.Add(this.agcDecayNumericUpDown);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.unityGainCheckBox);
            this.tabPage3.Controls.Add(this.latencyNumericUpDown);
            this.tabPage3.Controls.Add(this.filterAudioCheckBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.sampleRateComboBox);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1210, 78);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Audio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "Filter type";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filterTypeComboBox
            // 
            this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeComboBox.FormattingEnabled = true;
            this.filterTypeComboBox.Items.AddRange(new object[] {
            "Hamming",
            "Blackman",
            "Blackman-Harris 4",
            "Blackman-Harris 7",
            "Hann-Poisson",
            "Youssef"});
            this.filterTypeComboBox.Location = new System.Drawing.Point(92, 40);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(125, 24);
            this.filterTypeComboBox.TabIndex = 39;
            this.filterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.filterTypeComboBox_SelectedIndexChanged);
            // 
            // filterOrderNumericUpDown
            // 
            this.filterOrderNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.filterOrderNumericUpDown.Location = new System.Drawing.Point(322, 43);
            this.filterOrderNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.filterOrderNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.filterOrderNumericUpDown.Name = "filterOrderNumericUpDown";
            this.filterOrderNumericUpDown.Size = new System.Drawing.Size(65, 22);
            this.filterOrderNumericUpDown.TabIndex = 40;
            this.filterOrderNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.filterOrderNumericUpDown.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.filterOrderNumericUpDown.ValueChanged += new System.EventHandler(this.filterOrderNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Filter order";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // agcUseHangCheckBox
            // 
            this.agcUseHangCheckBox.AutoSize = true;
            this.agcUseHangCheckBox.Location = new System.Drawing.Point(833, 42);
            this.agcUseHangCheckBox.Name = "agcUseHangCheckBox";
            this.agcUseHangCheckBox.Size = new System.Drawing.Size(93, 21);
            this.agcUseHangCheckBox.TabIndex = 32;
            this.agcUseHangCheckBox.Text = "Use Hang";
            this.agcUseHangCheckBox.UseVisualStyleBackColor = true;
            // 
            // agcSlopeNumericUpDown
            // 
            this.agcSlopeNumericUpDown.Location = new System.Drawing.Point(833, 8);
            this.agcSlopeNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.agcSlopeNumericUpDown.Name = "agcSlopeNumericUpDown";
            this.agcSlopeNumericUpDown.Size = new System.Drawing.Size(53, 22);
            this.agcSlopeNumericUpDown.TabIndex = 35;
            this.agcSlopeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.agcSlopeNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(741, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 17);
            this.label22.TabIndex = 38;
            this.label22.Text = "Slope (dB)";
            // 
            // agcCheckBox
            // 
            this.agcCheckBox.AutoSize = true;
            this.agcCheckBox.Location = new System.Drawing.Point(405, 7);
            this.agcCheckBox.Name = "agcCheckBox";
            this.agcCheckBox.Size = new System.Drawing.Size(88, 21);
            this.agcCheckBox.TabIndex = 31;
            this.agcCheckBox.Text = "Use AGC";
            this.agcCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Decay (ms)";
            // 
            // agcThresholdNumericUpDown
            // 
            this.agcThresholdNumericUpDown.Location = new System.Drawing.Point(615, 8);
            this.agcThresholdNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.agcThresholdNumericUpDown.Minimum = new decimal(new int[] {
            160,
            0,
            0,
            -2147483648});
            this.agcThresholdNumericUpDown.Name = "agcThresholdNumericUpDown";
            this.agcThresholdNumericUpDown.Size = new System.Drawing.Size(95, 22);
            this.agcThresholdNumericUpDown.TabIndex = 33;
            this.agcThresholdNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // agcDecayNumericUpDown
            // 
            this.agcDecayNumericUpDown.Location = new System.Drawing.Point(615, 40);
            this.agcDecayNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.agcDecayNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.agcDecayNumericUpDown.Name = "agcDecayNumericUpDown";
            this.agcDecayNumericUpDown.Size = new System.Drawing.Size(95, 22);
            this.agcDecayNumericUpDown.TabIndex = 34;
            this.agcDecayNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.agcDecayNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Threshold (dB)";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.label43);
            this.tabPage4.Controls.Add(this.ScanDb);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.frequencyShiftNumericUpDown);
            this.tabPage4.Controls.Add(this.snapFrequencyCheckBox);
            this.tabPage4.Controls.Add(this.swapIQCheckBox);
            this.tabPage4.Controls.Add(this.correctIQCheckBox);
            this.tabPage4.Controls.Add(this.inputDeviceComboBox);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.outputDeviceComboBox);
            this.tabPage4.ImageIndex = 3;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1210, 78);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Configuration";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(566, 12);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(108, 17);
            this.label43.TabIndex = 38;
            this.label43.Text = "Scan Threshold";
            this.label43.Click += new System.EventHandler(this.label43_Click);
            // 
            // ScanDb
            // 
            this.ScanDb.Location = new System.Drawing.Point(680, 11);
            this.ScanDb.Name = "ScanDb";
            this.ScanDb.Size = new System.Drawing.Size(120, 22);
            this.ScanDb.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "UpConverter Shift";
            // 
            // frequencyShiftNumericUpDown
            // 
            this.frequencyShiftNumericUpDown.Enabled = false;
            this.frequencyShiftNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyShiftNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frequencyShiftNumericUpDown.Location = new System.Drawing.Point(401, 11);
            this.frequencyShiftNumericUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.frequencyShiftNumericUpDown.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.frequencyShiftNumericUpDown.Name = "frequencyShiftNumericUpDown";
            this.frequencyShiftNumericUpDown.Size = new System.Drawing.Size(134, 22);
            this.frequencyShiftNumericUpDown.TabIndex = 11;
            this.frequencyShiftNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequencyShiftNumericUpDown.ThousandsSeparator = true;
            this.frequencyShiftNumericUpDown.ValueChanged += new System.EventHandler(this.frequencyShiftNumericUpDown_ValueChanged);
            // 
            // snapFrequencyCheckBox
            // 
            this.snapFrequencyCheckBox.Location = new System.Drawing.Point(529, 45);
            this.snapFrequencyCheckBox.Name = "snapFrequencyCheckBox";
            this.snapFrequencyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.snapFrequencyCheckBox.Size = new System.Drawing.Size(113, 30);
            this.snapFrequencyCheckBox.TabIndex = 20;
            this.snapFrequencyCheckBox.Text = "Snap to grid";
            this.snapFrequencyCheckBox.UseVisualStyleBackColor = true;
            this.snapFrequencyCheckBox.CheckedChanged += new System.EventHandler(this.stepSizeComboBox_SelectedIndexChanged);
            // 
            // swapIQCheckBox
            // 
            this.swapIQCheckBox.Location = new System.Drawing.Point(401, 51);
            this.swapIQCheckBox.Name = "swapIQCheckBox";
            this.swapIQCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.swapIQCheckBox.Size = new System.Drawing.Size(113, 20);
            this.swapIQCheckBox.TabIndex = 23;
            this.swapIQCheckBox.Text = "Swap I && Q";
            this.swapIQCheckBox.UseVisualStyleBackColor = true;
            this.swapIQCheckBox.CheckedChanged += new System.EventHandler(this.swapIQCheckBox_CheckedChanged);
            // 
            // correctIQCheckBox
            // 
            this.correctIQCheckBox.Location = new System.Drawing.Point(275, 51);
            this.correctIQCheckBox.Name = "correctIQCheckBox";
            this.correctIQCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.correctIQCheckBox.Size = new System.Drawing.Size(113, 20);
            this.correctIQCheckBox.TabIndex = 22;
            this.correctIQCheckBox.Text = "Correct IQ";
            this.correctIQCheckBox.UseVisualStyleBackColor = true;
            this.correctIQCheckBox.CheckedChanged += new System.EventHandler(this.autoCorrectIQCheckBox_CheckStateChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.viewComboBox);
            this.tabPage5.Controls.Add(this.fftWindowComboBox);
            this.tabPage5.Controls.Add(this.markPeaksCheckBox);
            this.tabPage5.Controls.Add(this.useTimestampsCheckBox);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.gradientButton);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.fftResolutionComboBox);
            this.tabPage5.ImageIndex = 1;
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1210, 78);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Display";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "View";
            // 
            // viewComboBox
            // 
            this.viewComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewComboBox.FormattingEnabled = true;
            this.viewComboBox.Items.AddRange(new object[] {
            "Spectrum Analyzer",
            "Waterfall",
            "Both"});
            this.viewComboBox.Location = new System.Drawing.Point(66, 7);
            this.viewComboBox.Name = "viewComboBox";
            this.viewComboBox.Size = new System.Drawing.Size(162, 24);
            this.viewComboBox.TabIndex = 0;
            this.viewComboBox.SelectedIndexChanged += new System.EventHandler(this.viewComboBox_SelectedIndexChanged);
            // 
            // fftWindowComboBox
            // 
            this.fftWindowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fftWindowComboBox.FormattingEnabled = true;
            this.fftWindowComboBox.Items.AddRange(new object[] {
            "None",
            "Hamming",
            "Blackman",
            "Blackman-Harris 4",
            "Blackman-Harris 7",
            "Hann-Poisson",
            "Youssef"});
            this.fftWindowComboBox.Location = new System.Drawing.Point(66, 37);
            this.fftWindowComboBox.Name = "fftWindowComboBox";
            this.fftWindowComboBox.Size = new System.Drawing.Size(162, 24);
            this.fftWindowComboBox.TabIndex = 1;
            this.fftWindowComboBox.SelectedIndexChanged += new System.EventHandler(this.fftWindowComboBox_SelectedIndexChanged);
            // 
            // markPeaksCheckBox
            // 
            this.markPeaksCheckBox.Location = new System.Drawing.Point(524, 41);
            this.markPeaksCheckBox.Name = "markPeaksCheckBox";
            this.markPeaksCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.markPeaksCheckBox.Size = new System.Drawing.Size(113, 20);
            this.markPeaksCheckBox.TabIndex = 33;
            this.markPeaksCheckBox.Text = "Mark Peaks";
            this.markPeaksCheckBox.UseVisualStyleBackColor = true;
            this.markPeaksCheckBox.CheckedChanged += new System.EventHandler(this.markPeaksCheckBox_CheckedChanged);
            // 
            // useTimestampsCheckBox
            // 
            this.useTimestampsCheckBox.Location = new System.Drawing.Point(249, 45);
            this.useTimestampsCheckBox.Name = "useTimestampsCheckBox";
            this.useTimestampsCheckBox.Size = new System.Drawing.Size(128, 20);
            this.useTimestampsCheckBox.TabIndex = 3;
            this.useTimestampsCheckBox.Text = "Use time markers";
            this.useTimestampsCheckBox.UseVisualStyleBackColor = true;
            this.useTimestampsCheckBox.CheckedChanged += new System.EventHandler(this.useTimestampCheckBox_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(392, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Gradient";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Window";
            // 
            // gradientButton
            // 
            this.gradientButton.Location = new System.Drawing.Point(461, 37);
            this.gradientButton.Name = "gradientButton";
            this.gradientButton.Size = new System.Drawing.Size(30, 26);
            this.gradientButton.TabIndex = 4;
            this.gradientButton.Text = "...";
            this.gradientButton.UseVisualStyleBackColor = true;
            this.gradientButton.Click += new System.EventHandler(this.gradientButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(246, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 17);
            this.label21.TabIndex = 18;
            this.label21.Text = "Resolution";
            // 
            // fftResolutionComboBox
            // 
            this.fftResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fftResolutionComboBox.FormattingEnabled = true;
            this.fftResolutionComboBox.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768",
            "65536",
            "131072",
            "262144",
            "524288",
            "1048576",
            "2097152",
            "4194304"});
            this.fftResolutionComboBox.Location = new System.Drawing.Point(327, 10);
            this.fftResolutionComboBox.Name = "fftResolutionComboBox";
            this.fftResolutionComboBox.Size = new System.Drawing.Size(162, 24);
            this.fftResolutionComboBox.TabIndex = 2;
            this.fftResolutionComboBox.SelectedIndexChanged += new System.EventHandler(this.fftResolutionComboBox_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.panel2);
            this.tabPage6.Controls.Add(this.panel1);
            this.tabPage6.Controls.Add(this.sAttackTrackBar);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.wDecayTrackBar);
            this.tabPage6.Controls.Add(this.label25);
            this.tabPage6.Controls.Add(this.wAttackTrackBar);
            this.tabPage6.Controls.Add(this.label23);
            this.tabPage6.Controls.Add(this.sDecayTrackBar);
            this.tabPage6.Controls.Add(this.label26);
            this.tabPage6.Controls.Add(this.label24);
            this.tabPage6.ImageIndex = 4;
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1210, 78);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "FFT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.fftZoomTrackBar);
            this.panel2.Controls.Add(this.fftContrastTrackBar);
            this.panel2.Controls.Add(this.fftOffsetTrackBar);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Location = new System.Drawing.Point(214, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 91);
            this.panel2.TabIndex = 43;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(262, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(61, 17);
            this.label31.TabIndex = 41;
            this.label31.Text = "Contrast";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 17);
            this.label29.TabIndex = 40;
            this.label29.Text = "Zoom";
            // 
            // fftZoomTrackBar
            // 
            this.fftZoomTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fftZoomTrackBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fftZoomTrackBar.Location = new System.Drawing.Point(74, 39);
            this.fftZoomTrackBar.Maximum = 50;
            this.fftZoomTrackBar.Name = "fftZoomTrackBar";
            this.fftZoomTrackBar.RightToLeftLayout = true;
            this.fftZoomTrackBar.Size = new System.Drawing.Size(142, 56);
            this.fftZoomTrackBar.TabIndex = 32;
            this.fftZoomTrackBar.TickFrequency = 5;
            this.fftZoomTrackBar.Scroll += new System.EventHandler(this.fftZoomTrackBar_Scroll);
            this.fftZoomTrackBar.ValueChanged += new System.EventHandler(this.fftZoomTrackBar_ValueChanged);
            // 
            // fftContrastTrackBar
            // 
            this.fftContrastTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fftContrastTrackBar.Location = new System.Drawing.Point(222, 38);
            this.fftContrastTrackBar.Maximum = 24;
            this.fftContrastTrackBar.Minimum = -24;
            this.fftContrastTrackBar.Name = "fftContrastTrackBar";
            this.fftContrastTrackBar.RightToLeftLayout = true;
            this.fftContrastTrackBar.Size = new System.Drawing.Size(142, 56);
            this.fftContrastTrackBar.TabIndex = 31;
            this.fftContrastTrackBar.TickFrequency = 6;
            this.fftContrastTrackBar.RightToLeftLayoutChanged += new System.EventHandler(this.fftContrastTrackBar_Scroll);
            this.fftContrastTrackBar.ValueChanged += new System.EventHandler(this.fftContrastTrackBar_Changed);
            // 
            // fftOffsetTrackBar
            // 
            this.fftOffsetTrackBar.Location = new System.Drawing.Point(74, 0);
            this.fftOffsetTrackBar.Maximum = 15;
            this.fftOffsetTrackBar.Name = "fftOffsetTrackBar";
            this.fftOffsetTrackBar.Size = new System.Drawing.Size(142, 56);
            this.fftOffsetTrackBar.TabIndex = 37;
            this.fftOffsetTrackBar.Scroll += new System.EventHandler(this.fftOffsetTrackBar_Scroll);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(155, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "Contrast";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 17);
            this.label28.TabIndex = 39;
            this.label28.Text = "Offset";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.fftSpeedTrackBar);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.fftRangeTrackBar);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 72);
            this.panel1.TabIndex = 42;
            // 
            // fftSpeedTrackBar
            // 
            this.fftSpeedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fftSpeedTrackBar.Location = new System.Drawing.Point(66, 38);
            this.fftSpeedTrackBar.Maximum = 100;
            this.fftSpeedTrackBar.Minimum = 1;
            this.fftSpeedTrackBar.Name = "fftSpeedTrackBar";
            this.fftSpeedTrackBar.RightToLeftLayout = true;
            this.fftSpeedTrackBar.Size = new System.Drawing.Size(142, 56);
            this.fftSpeedTrackBar.TabIndex = 35;
            this.fftSpeedTrackBar.TickFrequency = 10;
            this.fftSpeedTrackBar.Value = 50;
            this.fftSpeedTrackBar.Scroll += new System.EventHandler(this.fftSpeedTrackBar_ValueChanged);
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 39);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 17);
            this.label30.TabIndex = 41;
            this.label30.Text = "Speed";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 5);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 17);
            this.label27.TabIndex = 40;
            this.label27.Text = "Range";
            // 
            // fftRangeTrackBar
            // 
            this.fftRangeTrackBar.LargeChange = 10;
            this.fftRangeTrackBar.Location = new System.Drawing.Point(66, 3);
            this.fftRangeTrackBar.Maximum = 15;
            this.fftRangeTrackBar.Minimum = 2;
            this.fftRangeTrackBar.Name = "fftRangeTrackBar";
            this.fftRangeTrackBar.Size = new System.Drawing.Size(142, 56);
            this.fftRangeTrackBar.TabIndex = 38;
            this.fftRangeTrackBar.Value = 13;
            this.fftRangeTrackBar.Scroll += new System.EventHandler(this.fftRangeTrackBar_Scroll);
            this.fftRangeTrackBar.ValueChanged += new System.EventHandler(this.fftRangeTrackBar_ValueChanged);
            // 
            // sAttackTrackBar
            // 
            this.sAttackTrackBar.Location = new System.Drawing.Point(872, 42);
            this.sAttackTrackBar.Maximum = 50;
            this.sAttackTrackBar.Name = "sAttackTrackBar";
            this.sAttackTrackBar.Size = new System.Drawing.Size(128, 56);
            this.sAttackTrackBar.TabIndex = 5;
            this.sAttackTrackBar.TickFrequency = 5;
            this.sAttackTrackBar.ValueChanged += new System.EventHandler(this.sAttackTrackBar_ValueChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(333, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "Zoom";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(129, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "Speed";
            // 
            // wDecayTrackBar
            // 
            this.wDecayTrackBar.Location = new System.Drawing.Point(659, 41);
            this.wDecayTrackBar.Maximum = 50;
            this.wDecayTrackBar.Name = "wDecayTrackBar";
            this.wDecayTrackBar.Size = new System.Drawing.Size(130, 56);
            this.wDecayTrackBar.TabIndex = 8;
            this.wDecayTrackBar.TickFrequency = 5;
            this.wDecayTrackBar.ValueChanged += new System.EventHandler(this.wDecayTrackBar_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(587, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 17);
            this.label25.TabIndex = 26;
            this.label25.Text = "W-Decay";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // wAttackTrackBar
            // 
            this.wAttackTrackBar.Location = new System.Drawing.Point(658, 3);
            this.wAttackTrackBar.Maximum = 50;
            this.wAttackTrackBar.Name = "wAttackTrackBar";
            this.wAttackTrackBar.Size = new System.Drawing.Size(130, 56);
            this.wAttackTrackBar.TabIndex = 7;
            this.wAttackTrackBar.TickFrequency = 5;
            this.wAttackTrackBar.ValueChanged += new System.EventHandler(this.wAttackTrackBar_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(805, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 17);
            this.label23.TabIndex = 23;
            this.label23.Text = "S-Attack";
            // 
            // sDecayTrackBar
            // 
            this.sDecayTrackBar.Location = new System.Drawing.Point(871, 3);
            this.sDecayTrackBar.Maximum = 50;
            this.sDecayTrackBar.Name = "sDecayTrackBar";
            this.sDecayTrackBar.Size = new System.Drawing.Size(128, 56);
            this.sDecayTrackBar.TabIndex = 6;
            this.sDecayTrackBar.TickFrequency = 5;
            this.sDecayTrackBar.ValueChanged += new System.EventHandler(this.sDecayTrackBar_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(587, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 17);
            this.label26.TabIndex = 25;
            this.label26.Text = "W-Attack";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(804, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 17);
            this.label24.TabIndex = 24;
            this.label24.Text = "S-Decay";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.displayCollapsiblePanel);
            this.tabPage7.Controls.Add(this.controlPanel);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1210, 78);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Plugins";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // displayCollapsiblePanel
            // 
            this.displayCollapsiblePanel.ExpandedHeight = 350;
            this.displayCollapsiblePanel.Location = new System.Drawing.Point(65, 11);
            this.displayCollapsiblePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayCollapsiblePanel.Name = "displayCollapsiblePanel";
            this.displayCollapsiblePanel.NextPanel = null;
            this.displayCollapsiblePanel.PanelTitle = "Panel title";
            this.displayCollapsiblePanel.Size = new System.Drawing.Size(975, 375);
            this.displayCollapsiblePanel.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.AutoScroll = true;
            this.controlPanel.AutoSize = true;
            this.controlPanel.Location = new System.Drawing.Point(6, 13);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1023, 415);
            this.controlPanel.TabIndex = 1;
            this.controlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "network-wireless-3.png");
            this.imageList1.Images.SetKeyName(1, "video-display.png");
            this.imageList1.Images.SetKeyName(2, "audio-card.png");
            this.imageList1.Images.SetKeyName(3, "system-settings.png");
            this.imageList1.Images.SetKeyName(4, "test.png");
            this.imageList1.Images.SetKeyName(5, "bookmark-new-list-4.png");
            // 
            // vfoFrequencyEdit
            // 
            this.vfoFrequencyEdit.AutoSize = true;
            this.vfoFrequencyEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vfoFrequencyEdit.BackColor = System.Drawing.Color.Transparent;
            this.vfoFrequencyEdit.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vfoFrequencyEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.vfoFrequencyEdit.Frequency = ((long)(0));
            this.vfoFrequencyEdit.Location = new System.Drawing.Point(20, 38);
            this.vfoFrequencyEdit.Name = "vfoFrequencyEdit";
            this.vfoFrequencyEdit.Size = new System.Drawing.Size(234, 25);
            this.vfoFrequencyEdit.StepSize = 0;
            this.vfoFrequencyEdit.TabIndex = 30;
            this.vfoFrequencyEdit.Visible = false;
            this.vfoFrequencyEdit.FrequencyChanged += new System.EventHandler(this.vfoFrequencyEdit_FrequencyChanged);
            this.vfoFrequencyEdit.FrequencyChanging += new System.EventHandler<SDRSharp.FrequencyEdit.FrequencyChangingEventArgs>(this.vfoFrequencyEdit_FrequencyChanging);
            this.vfoFrequencyEdit.Load += new System.EventHandler(this.vfoFrequencyEdit_Load);
            this.vfoFrequencyEdit.VisibleChanged += new System.EventHandler(this.vfoFrequencyEdit_VisibleChanged);
            // 
            // button2
            // 
            this.button2.Image = global::SDRSharp.Properties.Resources.arrow_right_double;
            this.button2.Location = new System.Drawing.Point(149, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 39);
            this.button2.TabIndex = 44;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::SDRSharp.Properties.Resources.arrow_left_double1;
            this.button1.Location = new System.Drawing.Point(100, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RecordBtn
            // 
            this.RecordBtn.Enabled = false;
            this.RecordBtn.Image = global::SDRSharp.Properties.Resources._2014033006462198_easyicon_net_32;
            this.RecordBtn.Location = new System.Drawing.Point(51, 66);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(43, 40);
            this.RecordBtn.TabIndex = 42;
            this.RecordBtn.UseVisualStyleBackColor = true;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Image = global::SDRSharp.Properties.Resources.Play_1_Hot_Icon_321;
            this.PlayBtn.Location = new System.Drawing.Point(2, 66);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(43, 39);
            this.PlayBtn.TabIndex = 41;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.AltKey = "sdf";
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.AltKey = "dfdsf";
            this.ribbonButton1.Image = global::SDRSharp.Properties.Resources.Play_1_Hot_Icon_32;
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1299, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.FrequencyUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.vfoFrequencyEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panSplitContainer);
            this.Controls.Add(this.audioGainTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(840, 462);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SDR# - SEB TESTING";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panSplitContainer.Panel1.ResumeLayout(false);
            this.panSplitContainer.Panel1.PerformLayout();
            this.panSplitContainer.Panel2.ResumeLayout(false);
            this.panSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cwShiftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squelchNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBandwidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioGainTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemFreq1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterOrderNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agcSlopeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agcThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agcDecayNumericUpDown)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScanDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyShiftNumericUpDown)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fftZoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftOffsetTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fftSpeedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftRangeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAttackTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wDecayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAttackTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDecayTrackBar)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.IContainer components;
        private OpenFileDialog openDlg;
        private SpectrumAnalyzer spectrumAnalyzer;
        private Waterfall waterfall;
        private Label label12;
        private ComboBox outputDeviceComboBox;
        private Label label11;
        private ComboBox inputDeviceComboBox;
        private Label label13;
        private ComboBox sampleRateComboBox;
        private SplitContainer panSplitContainer;
        private Timer iqTimer;
        private RadioButton nfmRadioButton;
        private RadioButton rawRadioButton;
        private RadioButton cwRadioButton;
        private RadioButton amRadioButton;
        private RadioButton dsbRadioButton;
        private RadioButton wfmRadioButton;
        private Button configureSourceButton;
        private RadioButton lsbRadioButton;
        private RadioButton usbRadioButton;
        private NumericUpDown filterBandwidthNumericUpDown;
        private Label label1;
        private NumericUpDown squelchNumericUpDown;
        private ComboBox iqSourceComboBox;
        private NumericUpDown latencyNumericUpDown;
        private Label label6;
        private Label label15;
        private NumericUpDown cwShiftNumericUpDown;
        private TrackBar audioGainTrackBar;
        private CheckBox fmStereoCheckBox;
        private CheckBox filterAudioCheckBox;
        private CheckBox useSquelchCheckBox;
        private CheckBox frequencyShiftCheckBox;
        private FrequencyEdit.FrequencyEdit vfoFrequencyEdit;
        private CheckBox unityGainCheckBox;
        private NumericUpDown FrequencyUpDown;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private TrackBar trackBar1;
        private ToolStripMenuItem saveWaterfallToolStripMenuItem;
        private Timer timer1;
        private Label label2;
        private Label label9;
        private RibbonOrbMenuItem ribbonOrbMenuItem1;
        private RibbonButton ribbonButton1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private CheckBox agcUseHangCheckBox;
        private NumericUpDown agcSlopeNumericUpDown;
        private Label label22;
        private CheckBox agcCheckBox;
        private Label label10;
        private NumericUpDown agcThresholdNumericUpDown;
        private NumericUpDown agcDecayNumericUpDown;
        private Label label4;
        private TabPage tabPage4;
        private Label label3;
        private Label label18;
        private NumericUpDown frequencyShiftNumericUpDown;
        private ComboBox stepSizeComboBox;
        private CheckBox snapFrequencyCheckBox;
        private CheckBox swapIQCheckBox;
        private CheckBox correctIQCheckBox;
        private Label label16;
        private ComboBox filterTypeComboBox;
        private NumericUpDown filterOrderNumericUpDown;
        private Label label5;
        private Label label7;
        private ComboBox viewComboBox;
        private ComboBox fftWindowComboBox;
        private CheckBox markPeaksCheckBox;
        private CheckBox useTimestampsCheckBox;
        private Label label14;
        private Label label8;
        private Button gradientButton;
        private Label label21;
        private ComboBox fftResolutionComboBox;
        private TrackBar fftSpeedTrackBar;
        private TrackBar sAttackTrackBar;
        private Label label28;
        private Label label20;
        private TrackBar fftContrastTrackBar;
        private Label label19;
        private Label label27;
        private TrackBar fftZoomTrackBar;
        private Label label17;
        private TrackBar fftOffsetTrackBar;
        private TrackBar fftRangeTrackBar;
        private TrackBar wDecayTrackBar;
        private Label label25;
        private TrackBar wAttackTrackBar;
        private Label label23;
        private TrackBar sDecayTrackBar;
        private Label label26;
        private Label label24;
        private Button PlayBtn;
        private Label label30;
        private Panel panel2;
        private Panel panel1;
        private Label label31;
        private Label label29;
        private Button RecordBtn;
        private Panel panel3;
        private ImageList imageList1;
        private Button button1;
        private Button button2;
        private TabPage tabPage2;
        private Label label37;
        private Label label39;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private NumericUpDown MemFreq2;
        private NumericUpDown MemFreq3;
        private NumericUpDown MemFreq4;
        private NumericUpDown MemFreq5;
        private NumericUpDown MemFreq1;
        private NumericUpDown MemFreq7;
        private NumericUpDown MemFreq8;
        private NumericUpDown MemFreq9;
        private NumericUpDown MemFreq0;
        private NumericUpDown MemFreq6;
        private Label label36;
        private Label label38;
        private Label label40;
        private Label label41;
        private Label label42;
        private NumericUpDown ScanDb;
        private Label label43;
        private TabPage tabPage7;
        private CollapsiblePanel.CollapsiblePanel displayCollapsiblePanel;
        private Panel controlPanel;
    }
}
