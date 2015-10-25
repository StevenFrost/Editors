namespace TextureMaxLoadEditor.Forms {
    partial class Apply {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerFade
            // 
            this.timerFade.Enabled = true;
            this.timerFade.Interval = 2000;
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resolutionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resolutionLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resolutionLabel.ForeColor = System.Drawing.Color.White;
            this.resolutionLabel.Location = new System.Drawing.Point(0, 32);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(136, 40);
            this.resolutionLabel.TabIndex = 0;
            this.resolutionLabel.Text = "4096";
            this.resolutionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resolutionLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(136, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Resolution Set";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // Apply
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(136, 72);
            this.ControlBox = false;
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(136, 72);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(136, 72);
            this.Name = "Apply";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Apply";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}