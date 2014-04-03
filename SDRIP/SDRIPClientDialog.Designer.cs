namespace SDRSharp.SDRIP
{
    partial class SDRIPClientDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.hostNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.samplerateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.rfAttenLbl = new System.Windows.Forms.Label();
            this.rfAttenTrackBar = new System.Windows.Forms.TrackBar();
            this.rfAttenLabel = new System.Windows.Forms.Label();
            this.debugLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sampleFormatCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfAttenTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // hostNameTb
            // 
            this.hostNameTb.Location = new System.Drawing.Point(123, 18);
            this.hostNameTb.Name = "hostNameTb";
            this.hostNameTb.Size = new System.Drawing.Size(136, 20);
            this.hostNameTb.TabIndex = 1;
            this.hostNameTb.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // portNumberUpDown
            // 
            this.portNumberUpDown.Location = new System.Drawing.Point(123, 44);
            this.portNumberUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNumberUpDown.Name = "portNumberUpDown";
            this.portNumberUpDown.Size = new System.Drawing.Size(136, 20);
            this.portNumberUpDown.TabIndex = 3;
            this.portNumberUpDown.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // samplerateComboBox
            // 
            this.samplerateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.samplerateComboBox.FormattingEnabled = true;
            this.samplerateComboBox.Items.AddRange(new object[] {
            "2.0 MSPS",
            "1.3333 MSPS",
            "1.0 MSPS",
            "0.8 MSPS",
            "0.5 MSPS",
            "0.4 MSPS",
            "0.25 MSPS",
            "0.2 MSPS",
            "0.125 MSPS",
            "0.1 MSPS",
            "0.05 MSPS",
            "0.032 MSPS"});
            this.samplerateComboBox.Location = new System.Drawing.Point(12, 97);
            this.samplerateComboBox.Name = "samplerateComboBox";
            this.samplerateComboBox.Size = new System.Drawing.Size(247, 21);
            this.samplerateComboBox.TabIndex = 4;
            this.samplerateComboBox.SelectedIndexChanged += new System.EventHandler(this.samplerateComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sample Rate";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // rfAttenLbl
            // 
            this.rfAttenLbl.AutoSize = true;
            this.rfAttenLbl.Location = new System.Drawing.Point(12, 185);
            this.rfAttenLbl.Name = "rfAttenLbl";
            this.rfAttenLbl.Size = new System.Drawing.Size(73, 13);
            this.rfAttenLbl.TabIndex = 6;
            this.rfAttenLbl.Text = "RF Attenuator";
            // 
            // rfAttenTrackBar
            // 
            this.rfAttenTrackBar.LargeChange = 1;
            this.rfAttenTrackBar.Location = new System.Drawing.Point(12, 201);
            this.rfAttenTrackBar.Maximum = 3;
            this.rfAttenTrackBar.Name = "rfAttenTrackBar";
            this.rfAttenTrackBar.Size = new System.Drawing.Size(247, 45);
            this.rfAttenTrackBar.TabIndex = 7;
            this.rfAttenTrackBar.Scroll += new System.EventHandler(this.rfAttenTrackBar_Scroll);
            // 
            // rfAttenLabel
            // 
            this.rfAttenLabel.AutoSize = true;
            this.rfAttenLabel.Location = new System.Drawing.Point(230, 185);
            this.rfAttenLabel.Name = "rfAttenLabel";
            this.rfAttenLabel.Size = new System.Drawing.Size(29, 13);
            this.rfAttenLabel.TabIndex = 8;
            this.rfAttenLabel.Text = "0 dB";
            // 
            // debugLbl
            // 
            this.debugLbl.AutoSize = true;
            this.debugLbl.Location = new System.Drawing.Point(12, 246);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(129, 13);
            this.debugLbl.TabIndex = 9;
            this.debugLbl.Text = "Debug: 0 Missed Packets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sample Format";
            // 
            // sampleFormatCombo
            // 
            this.sampleFormatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sampleFormatCombo.FormattingEnabled = true;
            this.sampleFormatCombo.Items.AddRange(new object[] {
            "24-bit",
            "16-bit"});
            this.sampleFormatCombo.Location = new System.Drawing.Point(12, 150);
            this.sampleFormatCombo.Name = "sampleFormatCombo";
            this.sampleFormatCombo.Size = new System.Drawing.Size(247, 21);
            this.sampleFormatCombo.TabIndex = 11;
            this.sampleFormatCombo.SelectedIndexChanged += new System.EventHandler(this.sampleFormatCombo_SelectedIndexChanged);
            // 
            // SDRIPClientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 272);
            this.Controls.Add(this.sampleFormatCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.rfAttenLabel);
            this.Controls.Add(this.rfAttenTrackBar);
            this.Controls.Add(this.rfAttenLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.samplerateComboBox);
            this.Controls.Add(this.portNumberUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostNameTb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(287, 310);
            this.MinimizeBox = false;
            this.Name = "SDRIPClientDialog";
            this.ShowIcon = false;
            this.Text = "SDR-IP Controller";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SDRIPClientDialog_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.SDRIPClientDialog_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.portNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfAttenTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown portNumberUpDown;
        private System.Windows.Forms.ComboBox samplerateComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label rfAttenLbl;
        private System.Windows.Forms.TrackBar rfAttenTrackBar;
        private System.Windows.Forms.Label rfAttenLabel;
        private System.Windows.Forms.Label debugLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sampleFormatCombo;
    }
}