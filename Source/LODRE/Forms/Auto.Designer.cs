namespace LODRadiusEditor
{
	partial class Auto
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
			this.autoTitle = new System.Windows.Forms.Label();
			this.autoCancel = new System.Windows.Forms.Label();
			this.autoBody = new System.Windows.Forms.Label();
			this.autoTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// autoTitle
			// 
			this.autoTitle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.autoTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.autoTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.autoTitle.Location = new System.Drawing.Point(0, 0);
			this.autoTitle.Name = "autoTitle";
			this.autoTitle.Size = new System.Drawing.Size(215, 28);
			this.autoTitle.TabIndex = 5;
			this.autoTitle.Text = "Auto Change Enabled";
			this.autoTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.autoTitle.Click += new System.EventHandler(this.autoCancel_Click);
			// 
			// autoCancel
			// 
			this.autoCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.autoCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.autoCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.autoCancel.Location = new System.Drawing.Point(0, 77);
			this.autoCancel.Name = "autoCancel";
			this.autoCancel.Size = new System.Drawing.Size(215, 23);
			this.autoCancel.TabIndex = 4;
			this.autoCancel.Text = "Cancel";
			this.autoCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.autoCancel.Click += new System.EventHandler(this.autoCancel_Click);
			// 
			// autoBody
			// 
			this.autoBody.Cursor = System.Windows.Forms.Cursors.Hand;
			this.autoBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.autoBody.Location = new System.Drawing.Point(0, 0);
			this.autoBody.Name = "autoBody";
			this.autoBody.Padding = new System.Windows.Forms.Padding(3);
			this.autoBody.Size = new System.Drawing.Size(215, 100);
			this.autoBody.TabIndex = 3;
			this.autoBody.Text = "The Level of Detail Radius Editor will close in [0] seconds.";
			this.autoBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.autoBody.Click += new System.EventHandler(this.autoCancel_Click);
			// 
			// autoTimer
			// 
			this.autoTimer.Enabled = true;
			this.autoTimer.Interval = 1000;
			this.autoTimer.Tick += new System.EventHandler(this.autoTimer_Tick);
			// 
			// Auto
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(215, 100);
			this.ControlBox = false;
			this.Controls.Add(this.autoTitle);
			this.Controls.Add(this.autoCancel);
			this.Controls.Add(this.autoBody);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(215, 100);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(215, 100);
			this.Name = "Auto";
			this.Opacity = 0.8D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Auto";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label autoTitle;
		private System.Windows.Forms.Label autoCancel;
		private System.Windows.Forms.Label autoBody;
		private System.Windows.Forms.Timer autoTimer;
	}
}