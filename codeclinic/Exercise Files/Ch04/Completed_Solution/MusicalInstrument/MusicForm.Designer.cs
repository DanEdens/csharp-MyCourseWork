namespace MusicalInstrument
{
    partial class MusicForm
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
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // trackVolume
            // 
            this.trackVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackVolume.Location = new System.Drawing.Point(12, 393);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(776, 45);
            this.trackVolume.TabIndex = 0;
            this.trackVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TheMouseDown);
            this.trackVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TheMouseUp);
            // 
            // trackFrequency
            // 
            this.trackFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackFrequency.Location = new System.Drawing.Point(743, 12);
            this.trackFrequency.Maximum = 1000;
            this.trackFrequency.Minimum = 100;
            this.trackFrequency.Name = "trackFrequency";
            this.trackFrequency.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackFrequency.Size = new System.Drawing.Size(45, 375);
            this.trackFrequency.TabIndex = 1;
            this.trackFrequency.Value = 100;
            this.trackFrequency.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TheMouseDown);
            this.trackFrequency.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TheMouseUp);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(725, 375);
            this.panel.TabIndex = 2;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TheMouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TheMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.trackFrequency);
            this.Controls.Add(this.trackVolume);
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
        private System.Windows.Forms.Panel panel;
    }
}

