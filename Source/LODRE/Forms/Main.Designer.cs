namespace LODRadiusEditor
{
	partial class Main
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
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.homeResL = new System.Windows.Forms.Label();
            this.homeFsxCfgL = new System.Windows.Forms.Label();
            this.homeFsxExeL = new System.Windows.Forms.Label();
            this.homeCfgPath = new System.Windows.Forms.TextBox();
            this.homeExePath = new System.Windows.Forms.TextBox();
            this.homeRadius = new System.Windows.Forms.ComboBox();
            this.autoTimer = new System.Windows.Forms.Timer(this.components);
            this.homeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.homeBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.homeCloseButton = new lodreLib.CloseButton();
            this.homeMinimizeButton = new lodreLib.MinimizeButton();
            this.homeHelpButton = new lodreLib.HelpButton();
            this.homeApplyButton = new lodreLib.ApplyButton();
            this.homeOptionsButton = new lodreLib.OptionsButton();
            this.homeAboutButton = new lodreLib.AboutButton();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.BackgroundImage = global::LODRadiusEditor.Properties.Resources.titlebar;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(390, 29);
            this.titleBar.TabIndex = 1;
            this.titleBar.TabStop = false;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // homeResL
            // 
            this.homeResL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeResL.BackColor = System.Drawing.Color.Transparent;
            this.homeResL.Location = new System.Drawing.Point(9, 105);
            this.homeResL.Name = "homeResL";
            this.homeResL.Size = new System.Drawing.Size(75, 13);
            this.homeResL.TabIndex = 6;
            this.homeResL.Text = "Radius:";
            // 
            // homeFsxCfgL
            // 
            this.homeFsxCfgL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeFsxCfgL.BackColor = System.Drawing.Color.Transparent;
            this.homeFsxCfgL.Location = new System.Drawing.Point(9, 77);
            this.homeFsxCfgL.Name = "homeFsxCfgL";
            this.homeFsxCfgL.Size = new System.Drawing.Size(75, 13);
            this.homeFsxCfgL.TabIndex = 5;
            this.homeFsxCfgL.Text = "FSX.cfg path:";
            // 
            // homeFsxExeL
            // 
            this.homeFsxExeL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeFsxExeL.BackColor = System.Drawing.Color.Transparent;
            this.homeFsxExeL.Location = new System.Drawing.Point(9, 49);
            this.homeFsxExeL.Name = "homeFsxExeL";
            this.homeFsxExeL.Size = new System.Drawing.Size(75, 13);
            this.homeFsxExeL.TabIndex = 4;
            this.homeFsxExeL.Text = "FSX.exe path:";
            // 
            // homeCfgPath
            // 
            this.homeCfgPath.BackColor = System.Drawing.Color.White;
            this.homeCfgPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeCfgPath.Location = new System.Drawing.Point(89, 74);
            this.homeCfgPath.Multiline = true;
            this.homeCfgPath.Name = "homeCfgPath";
            this.homeCfgPath.ReadOnly = true;
            this.homeCfgPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeCfgPath.ShortcutsEnabled = false;
            this.homeCfgPath.Size = new System.Drawing.Size(289, 20);
            this.homeCfgPath.TabIndex = 8;
            this.homeCfgPath.TabStop = false;
            this.homeCfgPath.WordWrap = false;
            this.homeCfgPath.Click += new System.EventHandler(this.homeCfgPath_Click);
            this.homeCfgPath.Enter += new System.EventHandler(this.homeCfgPath_Enter);
            this.homeCfgPath.MouseHover += new System.EventHandler(this.homeCfgPath_MouseHover);
            // 
            // homeExePath
            // 
            this.homeExePath.BackColor = System.Drawing.Color.White;
            this.homeExePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeExePath.Location = new System.Drawing.Point(89, 46);
            this.homeExePath.Multiline = true;
            this.homeExePath.Name = "homeExePath";
            this.homeExePath.ReadOnly = true;
            this.homeExePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeExePath.ShortcutsEnabled = false;
            this.homeExePath.Size = new System.Drawing.Size(289, 20);
            this.homeExePath.TabIndex = 7;
            this.homeExePath.TabStop = false;
            this.homeExePath.WordWrap = false;
            this.homeExePath.Click += new System.EventHandler(this.homeExePath_Click);
            this.homeExePath.Enter += new System.EventHandler(this.homeExePath_Enter);
            this.homeExePath.MouseHover += new System.EventHandler(this.homeExePath_MouseHover);
            // 
            // homeRadius
            // 
            this.homeRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.homeRadius.FormattingEnabled = true;
            this.homeRadius.Location = new System.Drawing.Point(89, 102);
            this.homeRadius.Name = "homeRadius";
            this.homeRadius.Size = new System.Drawing.Size(120, 21);
            this.homeRadius.TabIndex = 9;
            this.homeRadius.TabStop = false;
            // 
            // autoTimer
            // 
            this.autoTimer.Interval = 1000;
            this.autoTimer.Tick += new System.EventHandler(this.autoTimer_Tick);
            // 
            // homeToolTip
            // 
            this.homeToolTip.AutoPopDelay = 0;
            this.homeToolTip.InitialDelay = 500;
            this.homeToolTip.ReshowDelay = 100;
            // 
            // homeBrowser
            // 
            this.homeBrowser.Description = "Please select your [0] folder.";
            this.homeBrowser.ShowNewFolderButton = false;
            // 
            // homeCloseButton
            // 
            this.homeCloseButton.Location = new System.Drawing.Point(370, 9);
            this.homeCloseButton.Name = "homeCloseButton";
            this.homeCloseButton.Size = new System.Drawing.Size(11, 10);
            this.homeCloseButton.TabIndex = 10;
            this.homeCloseButton.ButtonClick += new lodreLib.ButtonClickEventHandler(this.titleBarCloseButton_ButtonClick);
            // 
            // homeMinimizeButton
            // 
            this.homeMinimizeButton.Location = new System.Drawing.Point(352, 14);
            this.homeMinimizeButton.Name = "homeMinimizeButton";
            this.homeMinimizeButton.Size = new System.Drawing.Size(12, 5);
            this.homeMinimizeButton.TabIndex = 11;
            this.homeMinimizeButton.ButtonClick += new lodreLib.ButtonClickEventHandler(this.titleBarMinimizeButton_ButtonClick);
            // 
            // homeHelpButton
            // 
            this.homeHelpButton.Location = new System.Drawing.Point(339, 8);
            this.homeHelpButton.Name = "homeHelpButton";
            this.homeHelpButton.Size = new System.Drawing.Size(8, 12);
            this.homeHelpButton.TabIndex = 12;
            this.homeHelpButton.ButtonClick += new lodreLib.ButtonClickEventHandler(this.titleBarHelpButton_ButtonClick);
            // 
            // homeApplyButton
            // 
            this.homeApplyButton.Location = new System.Drawing.Point(21, 134);
            this.homeApplyButton.Name = "homeApplyButton";
            this.homeApplyButton.Size = new System.Drawing.Size(75, 40);
            this.homeApplyButton.TabIndex = 13;
            this.homeApplyButton.ButtonClick += new lodreLib.ButtonClickEventHandler(this.homeApplyButton_ButtonClick);
            // 
            // homeOptionsButton
            // 
            this.homeOptionsButton.Location = new System.Drawing.Point(149, 134);
            this.homeOptionsButton.Name = "homeOptionsButton";
            this.homeOptionsButton.Size = new System.Drawing.Size(92, 40);
            this.homeOptionsButton.TabIndex = 14;
            this.homeOptionsButton.ButtonClick += new lodreLib.ButtonClickEventHandler(this.homeOptionsButton_ButtonClick);
            // 
            // homeAboutButton
            // 
            this.homeAboutButton.Location = new System.Drawing.Point(294, 134);
            this.homeAboutButton.Name = "homeAboutButton";
            this.homeAboutButton.Size = new System.Drawing.Size(79, 40);
            this.homeAboutButton.TabIndex = 15;
            this.homeAboutButton.ButtonClick += new lodreLib.ButtonClickEventHandler(this.homeAboutButton_ButtonClick);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::LODRadiusEditor.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 190);
            this.Controls.Add(this.homeAboutButton);
            this.Controls.Add(this.homeOptionsButton);
            this.Controls.Add(this.homeApplyButton);
            this.Controls.Add(this.homeHelpButton);
            this.Controls.Add(this.homeMinimizeButton);
            this.Controls.Add(this.homeCloseButton);
            this.Controls.Add(this.homeResL);
            this.Controls.Add(this.homeFsxCfgL);
            this.Controls.Add(this.homeFsxExeL);
            this.Controls.Add(this.homeCfgPath);
            this.Controls.Add(this.homeExePath);
            this.Controls.Add(this.homeRadius);
            this.Controls.Add(this.titleBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 190);
            this.MinimumSize = new System.Drawing.Size(390, 190);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Level of Detail Radius Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox titleBar;
		private System.Windows.Forms.Label homeResL;
		private System.Windows.Forms.Label homeFsxCfgL;
		private System.Windows.Forms.Label homeFsxExeL;
		private System.Windows.Forms.TextBox homeCfgPath;
		private System.Windows.Forms.TextBox homeExePath;
        internal System.Windows.Forms.ComboBox homeRadius;
		private System.Windows.Forms.Timer autoTimer;
		private System.Windows.Forms.ToolTip homeToolTip;
		private System.Windows.Forms.FolderBrowserDialog homeBrowser;
		private lodreLib.CloseButton homeCloseButton;
		private lodreLib.MinimizeButton homeMinimizeButton;
		private lodreLib.HelpButton homeHelpButton;
		private lodreLib.ApplyButton homeApplyButton;
		private lodreLib.OptionsButton homeOptionsButton;
		private lodreLib.AboutButton homeAboutButton;
	}
}

