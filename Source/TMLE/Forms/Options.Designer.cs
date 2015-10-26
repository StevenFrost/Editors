namespace TextureMaxLoadEditor.Forms {
    partial class Options {
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
            this.optionsTabs = new System.Windows.Forms.TabControl();
            this.optionsGeneral = new System.Windows.Forms.TabPage();
            this.optionsGeneral31 = new System.Windows.Forms.RadioButton();
            this.optionsGeneral30 = new System.Windows.Forms.RadioButton();
            this.optionsGeneral2 = new System.Windows.Forms.CheckBox();
            this.optionsGeneral1 = new System.Windows.Forms.CheckBox();
            this.optionsGeneral0 = new System.Windows.Forms.CheckBox();
            this.optionsAuto = new System.Windows.Forms.TabPage();
            this.optionsAuto2Remove = new System.Windows.Forms.Label();
            this.optionsAuto2 = new System.Windows.Forms.TextBox();
            this.optionsAuto2L = new System.Windows.Forms.Label();
            this.optionsAuto1 = new System.Windows.Forms.ComboBox();
            this.optionsAuto1L = new System.Windows.Forms.Label();
            this.optionsAuto3 = new System.Windows.Forms.CheckBox();
            this.optionsAuto0 = new System.Windows.Forms.CheckBox();
            this.OptionsResolutions = new System.Windows.Forms.TabPage();
            this.optionsResolutionRemove = new System.Windows.Forms.Button();
            this.optionsResolutionEdit = new System.Windows.Forms.Button();
            this.optionsResolutionAdd = new System.Windows.Forms.Button();
            this.optionsResolutionDefinitionL = new System.Windows.Forms.Label();
            this.optionsResolutionDefinition = new System.Windows.Forms.TextBox();
            this.optionsResolutionValueL = new System.Windows.Forms.Label();
            this.optionsResolutionValue = new System.Windows.Forms.TextBox();
            this.optionsResolutionR = new System.Windows.Forms.ListBox();
            this.optionsUpdates = new System.Windows.Forms.TabPage();
            this.optionsUpdates1 = new System.Windows.Forms.CheckBox();
            this.optionsUpdatesPast = new System.Windows.Forms.ListBox();
            this.optionsUpdatesCheck = new System.Windows.Forms.Button();
            this.optionsUpdatesVersions = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.locateFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.optionsAutoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.defaultSettings = new System.Windows.Forms.Button();
            this.optionsTabs.SuspendLayout();
            this.optionsGeneral.SuspendLayout();
            this.optionsAuto.SuspendLayout();
            this.OptionsResolutions.SuspendLayout();
            this.optionsUpdates.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsTabs
            // 
            this.optionsTabs.Controls.Add(this.optionsGeneral);
            this.optionsTabs.Controls.Add(this.optionsAuto);
            this.optionsTabs.Controls.Add(this.OptionsResolutions);
            this.optionsTabs.Controls.Add(this.optionsUpdates);
            this.optionsTabs.ItemSize = new System.Drawing.Size(84, 18);
            this.optionsTabs.Location = new System.Drawing.Point(4, 4);
            this.optionsTabs.Name = "optionsTabs";
            this.optionsTabs.SelectedIndex = 0;
            this.optionsTabs.Size = new System.Drawing.Size(382, 160);
            this.optionsTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.optionsTabs.TabIndex = 0;
            this.optionsTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.optionsTabs_MouseDown);
            // 
            // optionsGeneral
            // 
            this.optionsGeneral.Controls.Add(this.optionsGeneral31);
            this.optionsGeneral.Controls.Add(this.optionsGeneral30);
            this.optionsGeneral.Controls.Add(this.optionsGeneral2);
            this.optionsGeneral.Controls.Add(this.optionsGeneral1);
            this.optionsGeneral.Controls.Add(this.optionsGeneral0);
            this.optionsGeneral.Location = new System.Drawing.Point(4, 22);
            this.optionsGeneral.Name = "optionsGeneral";
            this.optionsGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.optionsGeneral.Size = new System.Drawing.Size(374, 134);
            this.optionsGeneral.TabIndex = 0;
            this.optionsGeneral.Text = "General";
            this.optionsGeneral.UseVisualStyleBackColor = true;
            // 
            // optionsGeneral31
            // 
            this.optionsGeneral31.AutoSize = true;
            this.optionsGeneral31.Location = new System.Drawing.Point(50, 107);
            this.optionsGeneral31.Name = "optionsGeneral31";
            this.optionsGeneral31.Size = new System.Drawing.Size(60, 17);
            this.optionsGeneral31.TabIndex = 5;
            this.optionsGeneral31.TabStop = true;
            this.optionsGeneral31.Text = "Always";
            this.optionsGeneral31.UseVisualStyleBackColor = true;
            // 
            // optionsGeneral30
            // 
            this.optionsGeneral30.AutoSize = true;
            this.optionsGeneral30.Location = new System.Drawing.Point(50, 84);
            this.optionsGeneral30.Name = "optionsGeneral30";
            this.optionsGeneral30.Size = new System.Drawing.Size(142, 17);
            this.optionsGeneral30.TabIndex = 4;
            this.optionsGeneral30.TabStop = true;
            this.optionsGeneral30.Text = "When started with FSX";
            this.optionsGeneral30.UseVisualStyleBackColor = true;
            // 
            // optionsGeneral2
            // 
            this.optionsGeneral2.AutoSize = true;
            this.optionsGeneral2.Location = new System.Drawing.Point(16, 61);
            this.optionsGeneral2.Name = "optionsGeneral2";
            this.optionsGeneral2.Size = new System.Drawing.Size(191, 17);
            this.optionsGeneral2.TabIndex = 3;
            this.optionsGeneral2.Text = "Start this application minimized:";
            this.optionsGeneral2.UseVisualStyleBackColor = true;
            this.optionsGeneral2.CheckedChanged += new System.EventHandler(this.optionsGeneral2_CheckedChanged);
            // 
            // optionsGeneral1
            // 
            this.optionsGeneral1.AutoSize = true;
            this.optionsGeneral1.Location = new System.Drawing.Point(16, 38);
            this.optionsGeneral1.Name = "optionsGeneral1";
            this.optionsGeneral1.Size = new System.Drawing.Size(346, 17);
            this.optionsGeneral1.TabIndex = 2;
            this.optionsGeneral1.Text = "Run the Texture Max Load Editor when you log onto Windows";
            this.optionsGeneral1.UseVisualStyleBackColor = true;
            // 
            // optionsGeneral0
            // 
            this.optionsGeneral0.AutoSize = true;
            this.optionsGeneral0.Location = new System.Drawing.Point(16, 15);
            this.optionsGeneral0.Name = "optionsGeneral0";
            this.optionsGeneral0.Size = new System.Drawing.Size(276, 17);
            this.optionsGeneral0.TabIndex = 1;
            this.optionsGeneral0.Text = "Run the Texture Max Load Editor when FSX starts";
            this.optionsGeneral0.UseVisualStyleBackColor = true;
            // 
            // optionsAuto
            // 
            this.optionsAuto.Controls.Add(this.optionsAuto2Remove);
            this.optionsAuto.Controls.Add(this.optionsAuto2);
            this.optionsAuto.Controls.Add(this.optionsAuto2L);
            this.optionsAuto.Controls.Add(this.optionsAuto1);
            this.optionsAuto.Controls.Add(this.optionsAuto1L);
            this.optionsAuto.Controls.Add(this.optionsAuto3);
            this.optionsAuto.Controls.Add(this.optionsAuto0);
            this.optionsAuto.Location = new System.Drawing.Point(4, 22);
            this.optionsAuto.Name = "optionsAuto";
            this.optionsAuto.Padding = new System.Windows.Forms.Padding(3);
            this.optionsAuto.Size = new System.Drawing.Size(374, 134);
            this.optionsAuto.TabIndex = 1;
            this.optionsAuto.Text = "Auto Change";
            this.optionsAuto.UseVisualStyleBackColor = true;
            // 
            // optionsAuto2Remove
            // 
            this.optionsAuto2Remove.AutoSize = true;
            this.optionsAuto2Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsAuto2Remove.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.optionsAuto2Remove.Location = new System.Drawing.Point(352, 66);
            this.optionsAuto2Remove.Margin = new System.Windows.Forms.Padding(0);
            this.optionsAuto2Remove.Name = "optionsAuto2Remove";
            this.optionsAuto2Remove.Size = new System.Drawing.Size(16, 17);
            this.optionsAuto2Remove.TabIndex = 4;
            this.optionsAuto2Remove.Text = "X";
            this.optionsAuto2Remove.Click += new System.EventHandler(this.optionsAuto2Remove_Click);
            // 
            // optionsAuto2
            // 
            this.optionsAuto2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsAuto2.BackColor = System.Drawing.Color.White;
            this.optionsAuto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsAuto2.HideSelection = false;
            this.optionsAuto2.Location = new System.Drawing.Point(212, 64);
            this.optionsAuto2.Name = "optionsAuto2";
            this.optionsAuto2.ReadOnly = true;
            this.optionsAuto2.Size = new System.Drawing.Size(134, 21);
            this.optionsAuto2.TabIndex = 3;
            this.optionsAuto2.TabStop = false;
            this.optionsAuto2.Click += new System.EventHandler(this.optionsAuto2_Click);
            this.optionsAuto2.Enter += new System.EventHandler(this.optionsAuto2_Enter);
            this.optionsAuto2.MouseHover += new System.EventHandler(this.optionsAuto2_MouseHover);
            // 
            // optionsAuto2L
            // 
            this.optionsAuto2L.AutoSize = true;
            this.optionsAuto2L.Location = new System.Drawing.Point(46, 67);
            this.optionsAuto2L.Name = "optionsAuto2L";
            this.optionsAuto2L.Size = new System.Drawing.Size(160, 13);
            this.optionsAuto2L.TabIndex = 0;
            this.optionsAuto2L.Text = "Run application after change:";
            // 
            // optionsAuto1
            // 
            this.optionsAuto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionsAuto1.FormattingEnabled = true;
            this.optionsAuto1.Location = new System.Drawing.Point(212, 37);
            this.optionsAuto1.Name = "optionsAuto1";
            this.optionsAuto1.Size = new System.Drawing.Size(120, 21);
            this.optionsAuto1.TabIndex = 2;
            this.optionsAuto1.TabStop = false;
            // 
            // optionsAuto1L
            // 
            this.optionsAuto1L.AutoSize = true;
            this.optionsAuto1L.Location = new System.Drawing.Point(46, 40);
            this.optionsAuto1L.Name = "optionsAuto1L";
            this.optionsAuto1L.Size = new System.Drawing.Size(98, 13);
            this.optionsAuto1L.TabIndex = 0;
            this.optionsAuto1L.Text = "Resolution to set:";
            // 
            // optionsAuto3
            // 
            this.optionsAuto3.AutoSize = true;
            this.optionsAuto3.Location = new System.Drawing.Point(49, 93);
            this.optionsAuto3.Name = "optionsAuto3";
            this.optionsAuto3.Size = new System.Drawing.Size(297, 17);
            this.optionsAuto3.TabIndex = 5;
            this.optionsAuto3.Text = "Close this application after changes have been made";
            this.optionsAuto3.UseVisualStyleBackColor = true;
            // 
            // optionsAuto0
            // 
            this.optionsAuto0.AutoSize = true;
            this.optionsAuto0.Location = new System.Drawing.Point(16, 15);
            this.optionsAuto0.Name = "optionsAuto0";
            this.optionsAuto0.Size = new System.Drawing.Size(130, 17);
            this.optionsAuto0.TabIndex = 1;
            this.optionsAuto0.Text = "Enable auto-change";
            this.optionsAuto0.UseVisualStyleBackColor = true;
            this.optionsAuto0.CheckedChanged += new System.EventHandler(this.optionsAuto0_CheckedChanged);
            // 
            // OptionsResolutions
            // 
            this.OptionsResolutions.Controls.Add(this.optionsResolutionRemove);
            this.OptionsResolutions.Controls.Add(this.optionsResolutionEdit);
            this.OptionsResolutions.Controls.Add(this.optionsResolutionAdd);
            this.OptionsResolutions.Controls.Add(this.optionsResolutionDefinitionL);
            this.OptionsResolutions.Controls.Add(this.optionsResolutionDefinition);
            this.OptionsResolutions.Controls.Add(this.optionsResolutionValueL);
            this.OptionsResolutions.Controls.Add(this.optionsResolutionValue);
            this.OptionsResolutions.Controls.Add(this.optionsResolutionR);
            this.OptionsResolutions.Location = new System.Drawing.Point(4, 22);
            this.OptionsResolutions.Name = "OptionsResolutions";
            this.OptionsResolutions.Size = new System.Drawing.Size(374, 134);
            this.OptionsResolutions.TabIndex = 2;
            this.OptionsResolutions.Text = "Resolutions";
            this.OptionsResolutions.UseVisualStyleBackColor = true;
            // 
            // optionsResolutionRemove
            // 
            this.optionsResolutionRemove.Location = new System.Drawing.Point(199, 99);
            this.optionsResolutionRemove.Name = "optionsResolutionRemove";
            this.optionsResolutionRemove.Size = new System.Drawing.Size(55, 23);
            this.optionsResolutionRemove.TabIndex = 6;
            this.optionsResolutionRemove.Text = "Remove";
            this.optionsResolutionRemove.UseVisualStyleBackColor = true;
            this.optionsResolutionRemove.Click += new System.EventHandler(this.optionsResolutionRemove_Click);
            // 
            // optionsResolutionEdit
            // 
            this.optionsResolutionEdit.Location = new System.Drawing.Point(199, 68);
            this.optionsResolutionEdit.Name = "optionsResolutionEdit";
            this.optionsResolutionEdit.Size = new System.Drawing.Size(55, 23);
            this.optionsResolutionEdit.TabIndex = 5;
            this.optionsResolutionEdit.Text = "Edit";
            this.optionsResolutionEdit.UseVisualStyleBackColor = true;
            this.optionsResolutionEdit.Click += new System.EventHandler(this.optionsResolutionEdit_Click);
            // 
            // optionsResolutionAdd
            // 
            this.optionsResolutionAdd.Location = new System.Drawing.Point(113, 68);
            this.optionsResolutionAdd.Name = "optionsResolutionAdd";
            this.optionsResolutionAdd.Size = new System.Drawing.Size(55, 23);
            this.optionsResolutionAdd.TabIndex = 3;
            this.optionsResolutionAdd.Text = "Add";
            this.optionsResolutionAdd.UseVisualStyleBackColor = true;
            this.optionsResolutionAdd.Click += new System.EventHandler(this.optionsResolutionAdd_Click);
            this.optionsResolutionAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.optionsResolutionValueL_MouseDown);
            // 
            // optionsResolutionDefinitionL
            // 
            this.optionsResolutionDefinitionL.AutoSize = true;
            this.optionsResolutionDefinitionL.Location = new System.Drawing.Point(17, 43);
            this.optionsResolutionDefinitionL.Name = "optionsResolutionDefinitionL";
            this.optionsResolutionDefinitionL.Size = new System.Drawing.Size(62, 13);
            this.optionsResolutionDefinitionL.TabIndex = 0;
            this.optionsResolutionDefinitionL.Text = "Definition:";
            // 
            // optionsResolutionDefinition
            // 
            this.optionsResolutionDefinition.Location = new System.Drawing.Point(85, 40);
            this.optionsResolutionDefinition.Name = "optionsResolutionDefinition";
            this.optionsResolutionDefinition.Size = new System.Drawing.Size(83, 21);
            this.optionsResolutionDefinition.TabIndex = 2;
            this.optionsResolutionDefinition.TextChanged += new System.EventHandler(this.optionsResolutionValue_TextChanged);
            this.optionsResolutionDefinition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.optionsResolutionValueL_MouseDown);
            // 
            // optionsResolutionValueL
            // 
            this.optionsResolutionValueL.AutoSize = true;
            this.optionsResolutionValueL.Location = new System.Drawing.Point(17, 17);
            this.optionsResolutionValueL.Name = "optionsResolutionValueL";
            this.optionsResolutionValueL.Size = new System.Drawing.Size(38, 13);
            this.optionsResolutionValueL.TabIndex = 0;
            this.optionsResolutionValueL.Text = "Value:";
            // 
            // optionsResolutionValue
            // 
            this.optionsResolutionValue.Location = new System.Drawing.Point(85, 14);
            this.optionsResolutionValue.Name = "optionsResolutionValue";
            this.optionsResolutionValue.Size = new System.Drawing.Size(83, 21);
            this.optionsResolutionValue.TabIndex = 1;
            this.optionsResolutionValue.TextChanged += new System.EventHandler(this.optionsResolutionValue_TextChanged);
            this.optionsResolutionValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.optionsResolutionValueL_MouseDown);
            // 
            // optionsResolutionR
            // 
            this.optionsResolutionR.FormattingEnabled = true;
            this.optionsResolutionR.Location = new System.Drawing.Point(260, 14);
            this.optionsResolutionR.Name = "optionsResolutionR";
            this.optionsResolutionR.Size = new System.Drawing.Size(102, 108);
            this.optionsResolutionR.TabIndex = 4;
            this.optionsResolutionR.SelectedIndexChanged += new System.EventHandler(this.optionsResolutionR_SelectedIndexChanged);
            // 
            // optionsUpdates
            // 
            this.optionsUpdates.Controls.Add(this.optionsUpdates1);
            this.optionsUpdates.Controls.Add(this.optionsUpdatesPast);
            this.optionsUpdates.Controls.Add(this.optionsUpdatesCheck);
            this.optionsUpdates.Controls.Add(this.optionsUpdatesVersions);
            this.optionsUpdates.Location = new System.Drawing.Point(4, 22);
            this.optionsUpdates.Name = "optionsUpdates";
            this.optionsUpdates.Size = new System.Drawing.Size(374, 134);
            this.optionsUpdates.TabIndex = 4;
            this.optionsUpdates.Text = "Updates";
            this.optionsUpdates.UseVisualStyleBackColor = true;
            // 
            // optionsUpdates1
            // 
            this.optionsUpdates1.Enabled = false;
            this.optionsUpdates1.Location = new System.Drawing.Point(16, 55);
            this.optionsUpdates1.Name = "optionsUpdates1";
            this.optionsUpdates1.Size = new System.Drawing.Size(226, 40);
            this.optionsUpdates1.TabIndex = 1;
            this.optionsUpdates1.Text = "Check for updates when the Texture Max Load Editor starts";
            this.optionsUpdates1.UseVisualStyleBackColor = true;
            // 
            // optionsUpdatesPast
            // 
            this.optionsUpdatesPast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsUpdatesPast.FormattingEnabled = true;
            this.optionsUpdatesPast.Items.AddRange(new object[] {
            "1.2 Build 194",
            "1.2 Build 195",
            "1.2 Build 196",
            "1.2 Build 197",
            "2.0 Build 1",
            "2.0 Build 2"});
            this.optionsUpdatesPast.Location = new System.Drawing.Point(248, 53);
            this.optionsUpdatesPast.Name = "optionsUpdatesPast";
            this.optionsUpdatesPast.Size = new System.Drawing.Size(114, 69);
            this.optionsUpdatesPast.TabIndex = 3;
            this.optionsUpdatesPast.SelectedIndexChanged += new System.EventHandler(this.optionsUpdatesPast_SelectedIndexChanged);
            // 
            // optionsUpdatesCheck
            // 
            this.optionsUpdatesCheck.Enabled = false;
            this.optionsUpdatesCheck.Location = new System.Drawing.Point(16, 99);
            this.optionsUpdatesCheck.Name = "optionsUpdatesCheck";
            this.optionsUpdatesCheck.Size = new System.Drawing.Size(166, 23);
            this.optionsUpdatesCheck.TabIndex = 2;
            this.optionsUpdatesCheck.Text = "Check for new updates";
            this.optionsUpdatesCheck.UseVisualStyleBackColor = true;
            // 
            // optionsUpdatesVersions
            // 
            this.optionsUpdatesVersions.Location = new System.Drawing.Point(13, 11);
            this.optionsUpdatesVersions.Name = "optionsUpdatesVersions";
            this.optionsUpdatesVersions.Size = new System.Drawing.Size(350, 39);
            this.optionsUpdatesVersions.TabIndex = 0;
            this.optionsUpdatesVersions.Text = "Checking for updates is now deprecated. You can view the change log for each of t" +
    "he past versions by clicking on a version in the list below.";
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(306, 172);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.optionsResolutionValueL_MouseDown);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(225, 172);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.optionsResolutionValueL_MouseDown);
            // 
            // locateFileDialog
            // 
            this.locateFileDialog.Filter = "Executable files|*.exe";
            this.locateFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.locateFileDialog_FileOk);
            // 
            // optionsAutoToolTip
            // 
            this.optionsAutoToolTip.AutoPopDelay = 0;
            this.optionsAutoToolTip.InitialDelay = 500;
            this.optionsAutoToolTip.ReshowDelay = 100;
            // 
            // defaultSettings
            // 
            this.defaultSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.defaultSettings.Location = new System.Drawing.Point(8, 172);
            this.defaultSettings.Name = "defaultSettings";
            this.defaultSettings.Size = new System.Drawing.Size(75, 23);
            this.defaultSettings.TabIndex = 3;
            this.defaultSettings.Text = "Default";
            this.defaultSettings.UseVisualStyleBackColor = true;
            this.defaultSettings.Click += new System.EventHandler(this.defaultSettings_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(388, 203);
            this.Controls.Add(this.defaultSettings);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.optionsTabs);
            this.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.optionsTabs.ResumeLayout(false);
            this.optionsGeneral.ResumeLayout(false);
            this.optionsGeneral.PerformLayout();
            this.optionsAuto.ResumeLayout(false);
            this.optionsAuto.PerformLayout();
            this.OptionsResolutions.ResumeLayout(false);
            this.OptionsResolutions.PerformLayout();
            this.optionsUpdates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl optionsTabs;
        private System.Windows.Forms.TabPage optionsGeneral;
        private System.Windows.Forms.TabPage optionsAuto;
        private System.Windows.Forms.TabPage OptionsResolutions;
        private System.Windows.Forms.TabPage optionsUpdates;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton optionsGeneral31;
        private System.Windows.Forms.RadioButton optionsGeneral30;
        private System.Windows.Forms.CheckBox optionsGeneral2;
        private System.Windows.Forms.CheckBox optionsGeneral1;
        private System.Windows.Forms.CheckBox optionsGeneral0;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button optionsResolutionAdd;
        private System.Windows.Forms.Label optionsResolutionDefinitionL;
        private System.Windows.Forms.TextBox optionsResolutionDefinition;
        private System.Windows.Forms.Label optionsResolutionValueL;
        private System.Windows.Forms.TextBox optionsResolutionValue;
        private System.Windows.Forms.ListBox optionsUpdatesPast;
        private System.Windows.Forms.Button optionsUpdatesCheck;
        private System.Windows.Forms.Label optionsUpdatesVersions;
        private System.Windows.Forms.Label optionsAuto1L;
        private System.Windows.Forms.CheckBox optionsAuto3;
        private System.Windows.Forms.CheckBox optionsAuto0;
        private System.Windows.Forms.TextBox optionsAuto2;
        private System.Windows.Forms.Label optionsAuto2L;
        public System.Windows.Forms.ComboBox optionsAuto1;
        internal System.Windows.Forms.ListBox optionsResolutionR;
        public System.Windows.Forms.Button optionsResolutionRemove;
        public System.Windows.Forms.Button optionsResolutionEdit;
        private System.Windows.Forms.OpenFileDialog locateFileDialog;
        private System.Windows.Forms.ToolTip optionsAutoToolTip;
        private System.Windows.Forms.CheckBox optionsUpdates1;
        public System.Windows.Forms.Label optionsAuto2Remove;
        private System.Windows.Forms.Button defaultSettings;
    }
}