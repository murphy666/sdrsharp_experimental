namespace SDRSharp.DNR
{
    partial class ProcessorPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ifEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ifThresholdLabel = new System.Windows.Forms.Label();
            this.ifThresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.audioThresholdLabel = new System.Windows.Forms.Label();
            this.audioThresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.audioEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ifThresholdTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioThresholdTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ifEnableCheckBox
            // 
            this.ifEnableCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ifEnableCheckBox.AutoSize = true;
            this.ifEnableCheckBox.Location = new System.Drawing.Point(6, 19);
            this.ifEnableCheckBox.Name = "ifEnableCheckBox";
            this.ifEnableCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ifEnableCheckBox.Size = new System.Drawing.Size(82, 21);
            this.ifEnableCheckBox.TabIndex = 4;
            this.ifEnableCheckBox.Text = "Enabled";
            this.ifEnableCheckBox.UseVisualStyleBackColor = true;
            this.ifEnableCheckBox.CheckedChanged += new System.EventHandler(this.ifEnableCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ifThresholdLabel);
            this.groupBox1.Controls.Add(this.ifThresholdTrackBar);
            this.groupBox1.Controls.Add(this.ifEnableCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IF";
            // 
            // ifThresholdLabel
            // 
            this.ifThresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ifThresholdLabel.Location = new System.Drawing.Point(111, 15);
            this.ifThresholdLabel.Name = "ifThresholdLabel";
            this.ifThresholdLabel.Size = new System.Drawing.Size(87, 23);
            this.ifThresholdLabel.TabIndex = 6;
            this.ifThresholdLabel.Text = "-5 dB";
            this.ifThresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ifThresholdTrackBar
            // 
            this.ifThresholdTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ifThresholdTrackBar.Location = new System.Drawing.Point(3, 40);
            this.ifThresholdTrackBar.Maximum = 20;
            this.ifThresholdTrackBar.Minimum = -80;
            this.ifThresholdTrackBar.Name = "ifThresholdTrackBar";
            this.ifThresholdTrackBar.Size = new System.Drawing.Size(198, 56);
            this.ifThresholdTrackBar.TabIndex = 5;
            this.ifThresholdTrackBar.TickFrequency = 5;
            this.ifThresholdTrackBar.Value = -30;
            this.ifThresholdTrackBar.Scroll += new System.EventHandler(this.ifThresholdTrackBar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.audioThresholdLabel);
            this.groupBox2.Controls.Add(this.audioThresholdTrackBar);
            this.groupBox2.Controls.Add(this.audioEnableCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // audioThresholdLabel
            // 
            this.audioThresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.audioThresholdLabel.Location = new System.Drawing.Point(111, 15);
            this.audioThresholdLabel.Name = "audioThresholdLabel";
            this.audioThresholdLabel.Size = new System.Drawing.Size(87, 23);
            this.audioThresholdLabel.TabIndex = 6;
            this.audioThresholdLabel.Text = "-5 dB";
            this.audioThresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // audioThresholdTrackBar
            // 
            this.audioThresholdTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioThresholdTrackBar.Location = new System.Drawing.Point(3, 40);
            this.audioThresholdTrackBar.Maximum = -20;
            this.audioThresholdTrackBar.Minimum = -120;
            this.audioThresholdTrackBar.Name = "audioThresholdTrackBar";
            this.audioThresholdTrackBar.Size = new System.Drawing.Size(198, 56);
            this.audioThresholdTrackBar.TabIndex = 5;
            this.audioThresholdTrackBar.TickFrequency = 5;
            this.audioThresholdTrackBar.Value = -70;
            this.audioThresholdTrackBar.Scroll += new System.EventHandler(this.audioThresholdTrackBar_Scroll);
            // 
            // audioEnableCheckBox
            // 
            this.audioEnableCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.audioEnableCheckBox.AutoSize = true;
            this.audioEnableCheckBox.Location = new System.Drawing.Point(6, 19);
            this.audioEnableCheckBox.Name = "audioEnableCheckBox";
            this.audioEnableCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.audioEnableCheckBox.Size = new System.Drawing.Size(82, 21);
            this.audioEnableCheckBox.TabIndex = 4;
            this.audioEnableCheckBox.Text = "Enabled";
            this.audioEnableCheckBox.UseVisualStyleBackColor = true;
            this.audioEnableCheckBox.CheckedChanged += new System.EventHandler(this.audioEnableCheckbox_CheckedChanged);
            // 
            // ProcessorPanel
            // 
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcessorPanel";
            this.Size = new System.Drawing.Size(204, 227);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ifThresholdTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioThresholdTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ifEnableCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ifThresholdLabel;
        private System.Windows.Forms.TrackBar ifThresholdTrackBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label audioThresholdLabel;
        private System.Windows.Forms.TrackBar audioThresholdTrackBar;
        private System.Windows.Forms.CheckBox audioEnableCheckBox;

    }
}
