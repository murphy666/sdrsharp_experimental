namespace SDRSharp.NoiseBlanker
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
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.pulseWidthLabel = new System.Windows.Forms.Label();
            this.pulseWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Location = new System.Drawing.Point(12, 8);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(82, 21);
            this.enableCheckBox.TabIndex = 0;
            this.enableCheckBox.Text = "Enabled";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            this.enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdLabel.Location = new System.Drawing.Point(107, 6);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(87, 23);
            this.thresholdLabel.TabIndex = 6;
            this.thresholdLabel.Text = "50";
            this.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdTrackBar.Location = new System.Drawing.Point(3, 35);
            this.thresholdTrackBar.Maximum = 100;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(198, 56);
            this.thresholdTrackBar.TabIndex = 1;
            this.thresholdTrackBar.TickFrequency = 5;
            this.thresholdTrackBar.Value = 20;
            this.thresholdTrackBar.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll);
            // 
            // pulseWidthLabel
            // 
            this.pulseWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseWidthLabel.Location = new System.Drawing.Point(107, 86);
            this.pulseWidthLabel.Name = "pulseWidthLabel";
            this.pulseWidthLabel.Size = new System.Drawing.Size(87, 23);
            this.pulseWidthLabel.TabIndex = 8;
            this.pulseWidthLabel.Text = "50";
            this.pulseWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pulseWidthTrackBar
            // 
            this.pulseWidthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseWidthTrackBar.Location = new System.Drawing.Point(3, 115);
            this.pulseWidthTrackBar.Maximum = 1000;
            this.pulseWidthTrackBar.Minimum = 1;
            this.pulseWidthTrackBar.Name = "pulseWidthTrackBar";
            this.pulseWidthTrackBar.Size = new System.Drawing.Size(198, 56);
            this.pulseWidthTrackBar.TabIndex = 2;
            this.pulseWidthTrackBar.TickFrequency = 50;
            this.pulseWidthTrackBar.Value = 100;
            this.pulseWidthTrackBar.Scroll += new System.EventHandler(this.pulseWidthTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pulse width";
            // 
            // ProcessorPanel
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pulseWidthLabel);
            this.Controls.Add(this.pulseWidthTrackBar);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.thresholdTrackBar);
            this.Controls.Add(this.enableCheckBox);
            this.Name = "ProcessorPanel";
            this.Size = new System.Drawing.Size(204, 192);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseWidthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.Label pulseWidthLabel;
        private System.Windows.Forms.TrackBar pulseWidthTrackBar;
        private System.Windows.Forms.Label label2;

    }
}
