namespace TextureMaxLoadEditor.Forms {
    partial class Main {
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
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.homeResolution = new System.Windows.Forms.ComboBox();
            this.titleBarCloseButton = new tmle2CtrlLib.CloseButton();
            this.titleBarMinimizeButton = new tmle2CtrlLib.MinimizeButton();
            this.titleBarHelpButton = new tmle2CtrlLib.HelpButton();
            this.homeApplyButton = new tmle2CtrlLib.ApplyButton();
            this.homeOptionsButton = new tmle2CtrlLib.OptionsButton();
            this.homeAboutButton = new tmle2CtrlLib.AboutButton();
            this.homeBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.updateChecker = new System.ComponentModel.BackgroundWorker();
            this.autoTimer = new System.Windows.Forms.Timer(this.components);
            this.homeExePath = new System.Windows.Forms.TextBox();
            this.homeCfgPath = new System.Windows.Forms.TextBox();
            this.homeFsxExeL = new System.Windows.Forms.Label();
            this.homeFsxCfgL = new System.Windows.Forms.Label();
            this.homeResL = new System.Windows.Forms.Label();
            this.homeToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.BackgroundImage = global::TextureMaxLoadEditor.Properties.Resources.titlebar;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(390, 29);
            this.titleBar.TabIndex = 0;
            this.titleBar.TabStop = false;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // homeResolution
            // 
            this.homeResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.homeResolution.FormattingEnabled = true;
            this.homeResolution.Location = new System.Drawing.Point(89, 102);
            this.homeResolution.Name = "homeResolution";
            this.homeResolution.Size = new System.Drawing.Size(120, 21);
            this.homeResolution.TabIndex = 3;
            this.homeResolution.TabStop = false;
            // 
            // titleBarCloseButton
            // 
            this.titleBarCloseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titleBarCloseButton.Location = new System.Drawing.Point(370, 9);
            this.titleBarCloseButton.Name = "titleBarCloseButton";
            this.titleBarCloseButton.Size = new System.Drawing.Size(11, 10);
            this.titleBarCloseButton.TabIndex = 9;
            this.titleBarCloseButton.ButtonClick += new tmle2CtrlLib.ButtonClickEventHandler(this.titleBarCloseButton_ButtonClick);
            // 
            // titleBarMinimizeButton
            // 
            this.titleBarMinimizeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titleBarMinimizeButton.Location = new System.Drawing.Point(352, 14);
            this.titleBarMinimizeButton.Name = "titleBarMinimizeButton";
            this.titleBarMinimizeButton.Size = new System.Drawing.Size(12, 5);
            this.titleBarMinimizeButton.TabIndex = 8;
            this.titleBarMinimizeButton.ButtonClick += new tmle2CtrlLib.ButtonClickEventHandler(this.titleBarMinimizeButton_ButtonClick);
            // 
            // titleBarHelpButton
            // 
            this.titleBarHelpButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titleBarHelpButton.Location = new System.Drawing.Point(339, 8);
            this.titleBarHelpButton.Name = "titleBarHelpButton";
            this.titleBarHelpButton.Size = new System.Drawing.Size(8, 12);
            this.titleBarHelpButton.TabIndex = 7;
            this.titleBarHelpButton.ButtonClick += new tmle2CtrlLib.ButtonClickEventHandler(this.titleBarHelpButton_ButtonClick);
            // 
            // homeApplyButton
            // 
            this.homeApplyButton.Location = new System.Drawing.Point(21, 134);
            this.homeApplyButton.Name = "homeApplyButton";
            this.homeApplyButton.Size = new System.Drawing.Size(75, 40);
            this.homeApplyButton.TabIndex = 4;
            this.homeApplyButton.ButtonClick += new tmle2CtrlLib.ButtonClickEventHandler(this.homeApplyButton_ButtonClick);
            // 
            // homeOptionsButton
            // 
            this.homeOptionsButton.Location = new System.Drawing.Point(149, 134);
            this.homeOptionsButton.Name = "homeOptionsButton";
            this.homeOptionsButton.Size = new System.Drawing.Size(92, 40);
            this.homeOptionsButton.TabIndex = 5;
            this.homeOptionsButton.ButtonClick += new tmle2CtrlLib.ButtonClickEventHandler(this.homeOptionsButton_ButtonClick);
            // 
            // homeAboutButton
            // 
            this.homeAboutButton.Location = new System.Drawing.Point(294, 134);
            this.homeAboutButton.Name = "homeAboutButton";
            this.homeAboutButton.Size = new System.Drawing.Size(79, 40);
            this.homeAboutButton.TabIndex = 6;
            this.homeAboutButton.ButtonClick += new tmle2CtrlLib.ButtonClickEventHandler(this.homeAboutButton_ButtonClick);
            // 
            // homeBrowser
            // 
            this.homeBrowser.Description = "Please select your [0] folder.";
            this.homeBrowser.ShowNewFolderButton = false;
            // 
            // autoTimer
            // 
            this.autoTimer.Interval = 1000;
            this.autoTimer.Tick += new System.EventHandler(this.autoTimer_Tick);
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
            this.homeExePath.TabIndex = 1;
            this.homeExePath.TabStop = false;
            this.homeExePath.WordWrap = false;
            this.homeExePath.Click += new System.EventHandler(this.homeExePath_Click);
            this.homeExePath.Enter += new System.EventHandler(this.homeExePath_Enter);
            this.homeExePath.MouseHover += new System.EventHandler(this.homeExePath_MouseHover);
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
            this.homeCfgPath.TabIndex = 2;
            this.homeCfgPath.TabStop = false;
            this.homeCfgPath.WordWrap = false;
            this.homeCfgPath.Click += new System.EventHandler(this.homeCfgPath_Click);
            this.homeCfgPath.Enter += new System.EventHandler(this.homeCfgPath_Enter);
            this.homeCfgPath.MouseHover += new System.EventHandler(this.homeCfgPath_MouseHover);
            // 
            // homeFsxExeL
            // 
            this.homeFsxExeL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.homeFsxExeL.BackColor = System.Drawing.Color.Transparent;
            this.homeFsxExeL.Location = new System.Drawing.Point(9, 49);
            this.homeFsxExeL.Name = "homeFsxExeL";
            this.homeFsxExeL.Size = new System.Drawing.Size(75, 13);
            this.homeFsxExeL.TabIndex = 0;
            this.homeFsxExeL.Text = "FSX.exe path:";
            // 
            // homeFsxCfgL
            // 
            this.homeFsxCfgL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.homeFsxCfgL.BackColor = System.Drawing.Color.Transparent;
            this.homeFsxCfgL.Location = new System.Drawing.Point(9, 77);
            this.homeFsxCfgL.Name = "homeFsxCfgL";
            this.homeFsxCfgL.Size = new System.Drawing.Size(75, 13);
            this.homeFsxCfgL.TabIndex = 0;
            this.homeFsxCfgL.Text = "FSX.cfg path:";
            // 
            // homeResL
            // 
            this.homeResL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.homeResL.BackColor = System.Drawing.Color.Transparent;
            this.homeResL.Location = new System.Drawing.Point(9, 105);
            this.homeResL.Name = "homeResL";
            this.homeResL.Size = new System.Drawing.Size(75, 13);
            this.homeResL.TabIndex = 0;
            this.homeResL.Text = "Resolution:";
            // 
            // homeToolTip
            // 
            this.homeToolTip.AutoPopDelay = 0;
            this.homeToolTip.InitialDelay = 500;
            this.homeToolTip.ReshowDelay = 100;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TextureMaxLoadEditor.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 190);
            this.Controls.Add(this.homeResL);
            this.Controls.Add(this.homeFsxCfgL);
            this.Controls.Add(this.homeFsxExeL);
            this.Controls.Add(this.homeCfgPath);
            this.Controls.Add(this.homeExePath);
            this.Controls.Add(this.homeAboutButton);
            this.Controls.Add(this.homeOptionsButton);
            this.Controls.Add(this.homeApplyButton);
            this.Controls.Add(this.titleBarHelpButton);
            this.Controls.Add(this.titleBarMinimizeButton);
            this.Controls.Add(this.titleBarCloseButton);
            this.Controls.Add(this.homeResolution);
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
            this.Text = "Texture Max Load Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titleBar;
        private tmle2CtrlLib.CloseButton titleBarCloseButton;
        private tmle2CtrlLib.MinimizeButton titleBarMinimizeButton;
        private tmle2CtrlLib.HelpButton titleBarHelpButton;
        private tmle2CtrlLib.ApplyButton homeApplyButton;
        private tmle2CtrlLib.OptionsButton homeOptionsButton;
        private tmle2CtrlLib.AboutButton homeAboutButton;
        private System.Windows.Forms.FolderBrowserDialog homeBrowser;
        internal System.Windows.Forms.ComboBox homeResolution;
        private System.ComponentModel.BackgroundWorker updateChecker;
        private System.Windows.Forms.Timer autoTimer;
        private System.Windows.Forms.TextBox homeExePath;
        private System.Windows.Forms.TextBox homeCfgPath;
        private System.Windows.Forms.Label homeFsxExeL;
        private System.Windows.Forms.Label homeFsxCfgL;
        private System.Windows.Forms.Label homeResL;
        private System.Windows.Forms.ToolTip homeToolTip;
    }
}

