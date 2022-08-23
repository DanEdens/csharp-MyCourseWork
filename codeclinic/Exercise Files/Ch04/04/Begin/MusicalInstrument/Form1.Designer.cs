namespace MusicalInstrument
{
    partial class Form1
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
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.trackFrequency = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // trackVolume
            // 
            this.trackVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackVolume.Location = new System.Drawing.Point(24, 756);
            this.trackVolume.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(1552, 90);
            this.trackVolume.TabIndex = 0;
            // 
            // trackFrequency
            // 
            this.trackFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackFrequency.Location = new System.Drawing.Point(1486, 23);
            this.trackFrequency.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trackFrequency.Maximum = 1000;
            this.trackFrequency.Minimum = 100;
            this.trackFrequency.Name = "trackFrequency";
            this.trackFrequency.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackFrequency.Size = new System.Drawing.Size(90, 721);
            this.trackFrequency.TabIndex = 1;
            this.trackFrequency.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.trackFrequency);
            this.Controls.Add(this.trackVolume);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Musical Instrument";
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.TrackBar trackFrequency;
    }
}

