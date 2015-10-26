namespace LODRadiusEditor
{
	partial class ChangeLog
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
			this.changeLogText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// changeLogText
			// 
			this.changeLogText.BackColor = System.Drawing.Color.White;
			this.changeLogText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.changeLogText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.changeLogText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.changeLogText.Location = new System.Drawing.Point(0, 0);
			this.changeLogText.Multiline = true;
			this.changeLogText.Name = "changeLogText";
			this.changeLogText.ReadOnly = true;
			this.changeLogText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.changeLogText.ShortcutsEnabled = false;
			this.changeLogText.Size = new System.Drawing.Size(434, 212);
			this.changeLogText.TabIndex = 0;
			this.changeLogText.TabStop = false;
			// 
			// ChangeLog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(434, 212);
			this.Controls.Add(this.changeLogText);
			this.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChangeLog";
			this.Text = "Change Log - [0]";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox changeLogText;
	}
}