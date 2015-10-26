namespace LODRadiusEditor
{
	partial class About
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
			this.aboutTitle = new System.Windows.Forms.Label();
			this.aboutVersion = new System.Windows.Forms.Label();
			this.aboutCopyright = new System.Windows.Forms.Label();
			this.aboutDevelopers = new System.Windows.Forms.Label();
			this.aboutDevs = new System.Windows.Forms.Label();
			this.aboutTesters = new System.Windows.Forms.Label();
			this.aboutFooter = new System.Windows.Forms.Panel();
			this.aboutLicenseButton = new System.Windows.Forms.Button();
			this.aboutOkButton = new System.Windows.Forms.Button();
			this.aboutLicense = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AboutTes = new System.Windows.Forms.Label();
			this.aboutFooter.SuspendLayout();
			this.SuspendLayout();
			// 
			// aboutTitle
			// 
			this.aboutTitle.AutoSize = true;
			this.aboutTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.aboutTitle.Location = new System.Drawing.Point(7, 9);
			this.aboutTitle.Name = "aboutTitle";
			this.aboutTitle.Size = new System.Drawing.Size(273, 30);
			this.aboutTitle.TabIndex = 1;
			this.aboutTitle.Text = "Level of Detail Radius Editor";
			// 
			// aboutVersion
			// 
			this.aboutVersion.AutoSize = true;
			this.aboutVersion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.aboutVersion.ForeColor = System.Drawing.Color.Gray;
			this.aboutVersion.Location = new System.Drawing.Point(12, 39);
			this.aboutVersion.Name = "aboutVersion";
			this.aboutVersion.Size = new System.Drawing.Size(64, 13);
			this.aboutVersion.TabIndex = 2;
			this.aboutVersion.Text = "Version 2.0";
			// 
			// aboutCopyright
			// 
			this.aboutCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.aboutCopyright.Location = new System.Drawing.Point(12, 66);
			this.aboutCopyright.Name = "aboutCopyright";
			this.aboutCopyright.Size = new System.Drawing.Size(280, 30);
			this.aboutCopyright.TabIndex = 3;
			this.aboutCopyright.Text = "Copyright © 2009 - 2010 Frosty Software. All rights\r\nreserved.";
			// 
			// aboutDevelopers
			// 
			this.aboutDevelopers.AutoSize = true;
			this.aboutDevelopers.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.aboutDevelopers.ForeColor = System.Drawing.Color.Gray;
			this.aboutDevelopers.Location = new System.Drawing.Point(12, 105);
			this.aboutDevelopers.Name = "aboutDevelopers";
			this.aboutDevelopers.Size = new System.Drawing.Size(68, 13);
			this.aboutDevelopers.TabIndex = 4;
			this.aboutDevelopers.Text = "Developers:";
			// 
			// aboutDevs
			// 
			this.aboutDevs.AutoSize = true;
			this.aboutDevs.Location = new System.Drawing.Point(42, 120);
			this.aboutDevs.Name = "aboutDevs";
			this.aboutDevs.Size = new System.Drawing.Size(77, 26);
			this.aboutDevs.TabIndex = 5;
			this.aboutDevs.Text = "- Steven Frost\r\n- Orion Lyau";
			// 
			// aboutTesters
			// 
			this.aboutTesters.AutoSize = true;
			this.aboutTesters.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.aboutTesters.ForeColor = System.Drawing.Color.Gray;
			this.aboutTesters.Location = new System.Drawing.Point(12, 158);
			this.aboutTesters.Name = "aboutTesters";
			this.aboutTesters.Size = new System.Drawing.Size(46, 13);
			this.aboutTesters.TabIndex = 6;
			this.aboutTesters.Text = "Testers:";
			// 
			// aboutFooter
			// 
            this.aboutFooter.BackColor = System.Drawing.SystemColors.Control;
            this.aboutFooter.BackgroundImage = global::LODRadiusEditor.Properties.Resources.aboutFooter;
			this.aboutFooter.Controls.Add(this.aboutLicenseButton);
			this.aboutFooter.Controls.Add(this.aboutOkButton);
			this.aboutFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.aboutFooter.Location = new System.Drawing.Point(0, 239);
			this.aboutFooter.Name = "aboutFooter";
			this.aboutFooter.Size = new System.Drawing.Size(304, 48);
			this.aboutFooter.TabIndex = 0;
			// 
			// aboutLicenseButton
			// 
			this.aboutLicenseButton.Location = new System.Drawing.Point(12, 13);
			this.aboutLicenseButton.Name = "aboutLicenseButton";
			this.aboutLicenseButton.Size = new System.Drawing.Size(75, 23);
			this.aboutLicenseButton.TabIndex = 1;
			this.aboutLicenseButton.Text = "License";
			this.aboutLicenseButton.UseVisualStyleBackColor = true;
			this.aboutLicenseButton.Click += new System.EventHandler(this.aboutLicenseButton_Click);
			// 
			// aboutOkButton
			// 
			this.aboutOkButton.Location = new System.Drawing.Point(217, 13);
			this.aboutOkButton.Name = "aboutOkButton";
			this.aboutOkButton.Size = new System.Drawing.Size(75, 23);
			this.aboutOkButton.TabIndex = 0;
			this.aboutOkButton.Text = "OK";
			this.aboutOkButton.UseVisualStyleBackColor = true;
			this.aboutOkButton.Click += new System.EventHandler(this.aboutOkButton_Click);
			// 
			// aboutLicense
			// 
			this.aboutLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.aboutLicense.BackColor = System.Drawing.Color.White;
			this.aboutLicense.Location = new System.Drawing.Point(14, 63);
			this.aboutLicense.Multiline = true;
			this.aboutLicense.Name = "aboutLicense";
			this.aboutLicense.ReadOnly = true;
			this.aboutLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.aboutLicense.Size = new System.Drawing.Size(277, 162);
			this.aboutLicense.TabIndex = 1;
			this.aboutLicense.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(159, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "- Peter Maziarz\r\n- Steven Frost";
			// 
			// AboutTes
			// 
			this.AboutTes.AutoSize = true;
			this.AboutTes.Location = new System.Drawing.Point(42, 173);
			this.AboutTes.Name = "AboutTes";
			this.AboutTes.Size = new System.Drawing.Size(90, 52);
			this.AboutTes.TabIndex = 9;
			this.AboutTes.Text = "- Adam Johnson\r\n- Brian Byers\r\n- Orion Lyau\r\n- Paul Gluck";
			// 
			// About
			// 
			this.AcceptButton = this.aboutOkButton;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(304, 287);
			this.Controls.Add(this.aboutLicense);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AboutTes);
			this.Controls.Add(this.aboutTesters);
			this.Controls.Add(this.aboutDevs);
			this.Controls.Add(this.aboutDevelopers);
			this.Controls.Add(this.aboutCopyright);
			this.Controls.Add(this.aboutVersion);
			this.Controls.Add(this.aboutTitle);
			this.Controls.Add(this.aboutFooter);
			this.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.aboutFooter.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel aboutFooter;
		private System.Windows.Forms.Button aboutLicenseButton;
		private System.Windows.Forms.Button aboutOkButton;
		private System.Windows.Forms.Label aboutTitle;
		private System.Windows.Forms.Label aboutVersion;
		private System.Windows.Forms.Label aboutCopyright;
		private System.Windows.Forms.Label aboutDevelopers;
		private System.Windows.Forms.Label aboutDevs;
		private System.Windows.Forms.Label aboutTesters;
		private System.Windows.Forms.TextBox aboutLicense;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label AboutTes;

	}
}