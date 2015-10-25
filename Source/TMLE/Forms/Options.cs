using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using iniLib;
using IWshRuntimeLibrary;

namespace TextureMaxLoadEditor.Forms
{
    public partial class Options : Form
    {
        private string currentTmlValue;

        /// <summary>
        /// Form constructor
        /// </summary>
        public Options(string currentValue)
        {
            InitializeComponent();
            Icon = global::TextureMaxLoadEditor.Properties.Resources.icon;
            currentTmlValue = currentValue;
            InitializeOptions(false);
        }

        #region Initialization

        public void InitializeOptions(bool DefaultClick)
        {
            using (IniFile iniFile = new IniFile())
            {
                if (!DefaultClick)
                {
                    /// <switch>current profile</switch>
                    iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                    iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");
                }
                else
                {
                    /// <switch>default profile</switch>
                    iniFile.IniPath = Application.StartupPath + @"\Resources\profile.resource";
                }

                #region General

                #region Run the Texture Max Load Editor when FSX starts

                switch (iniFile.ReadValue("OPTIONS.GENERAL", "runfsx"))
                {
                    case "1":
                        optionsGeneral0.Checked = true;
                        break;
                    case "0":
                        optionsGeneral0.Checked = false;
                        break;
                }

                #endregion

                #region Run the Texture Max Load Editor when you log onto this user account

                switch (iniFile.ReadValue("OPTIONS.GENERAL", "runwin"))
                {
                    case "1":
                        optionsGeneral1.Checked = true;
                        break;
                    case "0":
                        optionsGeneral1.Checked = false;
                        break;
                }

                #endregion

                #region Start this application minimized:

                switch (iniFile.ReadValue("OPTIONS.GENERAL", "minimize"))
                {
                    case "1":
                        optionsGeneral2.Checked = true;
                        optionsGeneral30.Enabled = true;
                        optionsGeneral31.Enabled = true;
                        break;
                    case "0":
                        optionsGeneral2.Checked = false;
                        optionsGeneral30.Enabled = false;
                        optionsGeneral31.Enabled = false;
                        break;
                }

                #endregion

                #region When started with FSX || Always

                switch (iniFile.ReadValue("OPTIONS.GENERAL", "sub"))
                {
                    case "1":
                        optionsGeneral31.Checked = true;
                        break;
                    case "0":
                        optionsGeneral30.Checked = true;
                        break;
                }

                #endregion

                #endregion

                #region Auto Change

                #region Enable auto-change

                switch (iniFile.ReadValue("OPTIONS.AUTO", "auto"))
                {
                    case "1":
                        optionsAuto0.Checked = true;
                        optionsAuto2.Enabled = true;
                        optionsAuto2Remove.Enabled = true;
                        optionsAuto2L.Enabled = true;
                        optionsAuto3.Enabled = true;
                        optionsAuto1.Enabled = true;
                        optionsAuto1L.Enabled = true;
                        break;
                    case "0":
                        optionsAuto0.Checked = false;
                        optionsAuto2.Enabled = false;
                        optionsAuto2Remove.Enabled = false;
                        optionsAuto2L.Enabled = false;
                        optionsAuto3.Enabled = false;
                        optionsAuto1.Enabled = false;
                        optionsAuto1L.Enabled = false;
                        break;
                }

                #endregion

                #region Set the dropdown items

                using (Resolutions resolutions = new Resolutions())
                {
                    // Fill the drop down box
                    resolutions.FillField(optionsAuto1, null);

                    if (iniFile.ReadValue("OPTIONS.AUTO", "resolution") == "")
                    {
                        // Select the current resolution in fsx.cfg
                        resolutions.SelectCurrentResolution(optionsAuto1, currentTmlValue);
                    }
                    else
                    {
                        // Select the chosen resolution
                        optionsAuto1.SelectedIndex = optionsAuto1.FindString(iniFile.ReadValue("OPTIONS.AUTO", "resolution"), 0);
                    }
                }

                #endregion

                #region Application to run after change

                optionsAuto2.Text = iniFile.ReadValue("OPTIONS.AUTO", "application");

                #endregion

                #region Close this application after changes have been made

                switch (iniFile.ReadValue("OPTIONS.AUTO", "close"))
                {
                    case "1":
                        optionsAuto3.Checked = true;
                        break;
                    case "0":
                        optionsAuto3.Checked = false;
                        break;
                }

                #endregion

                #endregion

                #region Resolutions

                using (Resolutions resolutions = new Resolutions())
                {
                    // Fill the List Box with resolutions
                    resolutions.FillField(null, optionsResolutionR);
                }

                // Disable the function buttons
                optionsResolutionEdit.Enabled = false;
                optionsResolutionAdd.Enabled = false;
                optionsResolutionRemove.Enabled = false;

                #endregion
            }
        }

        #endregion

        #region General

        /// <summary>
        /// Switch for the General sub-options
        /// Enables/Disables the appropriate radio buttons when the check status changes
        /// </summary>
        private void optionsGeneral2_CheckedChanged(object sender, EventArgs e)
        {
            switch (optionsGeneral2.Checked)
            {
                case true:
                    optionsGeneral30.Enabled = true;
                    optionsGeneral31.Enabled = true;
                    break;
                case false:
                    optionsGeneral30.Enabled = false;
                    optionsGeneral31.Enabled = false;
                    break;
            }
        }

        #endregion

        #region Auto Change

        /// <summary>
        /// Switch for the auto-change enable/disable checkbox.
        /// All controls must be disabled if the user deselects the checkbox.
        /// </summary>
        private void optionsAuto0_CheckedChanged(object sender, EventArgs e)
        {
            switch (optionsAuto0.Checked)
            {
                case true:
                    optionsAuto2.Enabled = true;
                    optionsAuto2Remove.Enabled = true;
                    optionsAuto2L.Enabled = true;
                    optionsAuto3.Enabled = true;
                    optionsAuto1.Enabled = true;
                    optionsAuto1L.Enabled = true;
                    break;
                case false:
                    optionsAuto2.Enabled = false;
                    optionsAuto2Remove.Enabled = false;
                    optionsAuto2L.Enabled = false;
                    optionsAuto3.Enabled = false;
                    optionsAuto1.Enabled = false;
                    optionsAuto1L.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// Removes the executable path from the textbox
        /// </summary>
        private void optionsAuto2Remove_Click(object sender, EventArgs e)
        {
            optionsAuto2.Text = null;
        }

        /// <summary>
        /// Updates the auto change textbox with the new executable path
        /// </summary>
        private void locateFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            optionsAuto2.Text = locateFileDialog.FileName;
        }

        /// <summary>
        /// Shows the file browser dialog
        /// </summary>
        private void optionsAuto2_Click(object sender, EventArgs e)
        {
            locateFileDialog.ShowDialog();
        }

        /// <summary>
        /// Deselects the text and activates a separate control
        /// </summary>
        private void optionsAuto2_Enter(object sender, EventArgs e)
        {
            optionsAuto2.DeselectAll();
            ActiveControl = optionsAuto2L;
        }

        /// <summary>
        /// Shows the full path to the executable via a tool tip
        /// </summary>
        private void optionsAuto2_MouseHover(object sender, EventArgs e)
        {
            using (IniFile iniFile = new IniFile())
            {
                // Switch: Default profile
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                if (iniFile.ReadValue("MISCELLANEOUS", "tooltips") == "1")
                {
                    // Show the tool tip
                    optionsAutoToolTip.Show(optionsAuto2.Text, optionsAuto2);
                }
            }
        }

        #endregion

        #region Resolutions

        /// <summary>
        /// Enables/Disables the "Add" button based upon the text in the fields
        /// </summary>
        private void optionsResolutionValue_TextChanged(object sender, EventArgs e)
        {
            if (optionsResolutionValue.Text != "" && optionsResolutionDefinition.Text != "")
                optionsResolutionAdd.Enabled = true;
            else
                optionsResolutionAdd.Enabled = false;
        }

        /// <summary>
        /// 1. Check if the resolution entered is an exponent of 2
        /// 2. Add the resolution to the list if (1) is satisfied
        /// </summary>
        private void optionsResolutionAdd_Click(object sender, EventArgs e)
        {
            Int64 x;	// Create an integer to store the resolution
            Int64.TryParse(optionsResolutionValue.Text.ToString(), out x);	// Parse the string to an integer

            while (((x % 2) == 0) && x > 1)
            {
                x /= 2;
                if (x == 1) { break; }
            }

            if (x != 1)
            {
                // Show an error, the user did not enter a value that is an exponent of 2
                MessageBox.Show("The resolution you entered is not an exponent of 2 and will not work in Flight Simulator X. Negative values are also not supported.",
                    "Incompatible Resolution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Method variables
                ArrayList listItems = new ArrayList();
                string[] previousItems = new string[optionsResolutionR.Items.Count];
                string[] splitItem;
                int counter = 0;

                foreach (string item in optionsResolutionR.Items)
                {
                    previousItems[counter] = item;
                    splitItem = item.Split('(');
                    listItems.Add(Convert.ToInt64(splitItem[0]));
                    counter++;
                }

                listItems.Add(Convert.ToInt64(optionsResolutionValue.Text.ToString()));
                listItems.Sort();
                optionsResolutionR.Items.Clear();

                for (int i = 0; i < listItems.Count; i++)
                    optionsResolutionR.Items.Insert(i, "");

                foreach (string item in previousItems)
                {
                    splitItem = item.Split('(');
                    optionsResolutionR.Items.Insert(listItems.IndexOf(Convert.ToInt64(splitItem[0])), item);
                }

                optionsResolutionR.Items.Insert(listItems.IndexOf(Convert.ToInt64(optionsResolutionValue.Text)),
                    optionsResolutionValue.Text.ToString() + " (" + optionsResolutionDefinition.Text.ToString() + ")");

                while (optionsResolutionR.Items.Count > listItems.Count)
                {
                    optionsResolutionR.Items.RemoveAt(optionsResolutionR.Items.IndexOf(""));
                }

                optionsResolutionValue.Text = null;
                optionsResolutionDefinition.Text = null;
            }

            if (optionsResolutionAdd.Text == "Save")
            {
                optionsResolutionAdd.Text = "Add";
            }
        }

        /// <summary>
        /// Refreshes the form and removes the selected item
        /// Also removed the item from the auto change tab drop down
        /// </summary>
        private void optionsResolutionRemove_Click(object sender, EventArgs e)
        {
            if (optionsResolutionR.SelectedItem.ToString() != optionsAuto1.SelectedItem.ToString())
            {
                if (optionsResolutionR.Items.Count > 1)
                {
                    using (OptionsResolutionList.Update update = new OptionsResolutionList.Update())
                    {
                        update.RefreshForm(optionsResolutionR, true);

                        optionsResolutionEdit.Enabled = false;
                        optionsResolutionRemove.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("You must have at least one resolution in your list.",
                        "Unable to remove resolution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You cannot remove a resolution that you have set for auto change.",
                    "Unable to remove resolution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Enables the resolutions tab controls
        /// </summary>
        private void optionsResolutionR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optionsResolutionEdit.Enabled == false && optionsResolutionR.SelectedIndex > -1)
            {
                optionsResolutionEdit.Enabled = true;
                optionsResolutionRemove.Enabled = true;
            }
        }

        /// <summary>
        /// Refreshes the form without removing a selected item
        /// </summary>
        private void optionsTabs_MouseDown(object sender, MouseEventArgs e)
        {
            using (OptionsResolutionList.Update update = new OptionsResolutionList.Update())
            {
                update.RefreshForm(optionsResolutionR, false);
                optionsResolutionEdit.Enabled = false;
                optionsResolutionRemove.Enabled = false;
            }
        }

        /// <summary>
        /// Refreshes the form without removing a selected item
        /// </summary>
        private void optionsResolutionValueL_MouseDown(object sender, MouseEventArgs e)
        {
            using (OptionsResolutionList.Update update = new OptionsResolutionList.Update())
            {
                update.RefreshForm(optionsResolutionR, false);
                optionsResolutionEdit.Enabled = false;
                optionsResolutionRemove.Enabled = false;
            }
        }

        /// <summary>
        /// Splits the selected item up into the exponential value of 2 and the description
        /// then outputs the two parts into the appropriate textboxes
        /// </summary>
        private void optionsResolutionEdit_Click(object sender, EventArgs e)
        {
            string[] splitResolution = optionsResolutionR.SelectedItem.ToString().Split('(');

            optionsResolutionValue.Text = splitResolution[0].TrimEnd(' ');
            optionsResolutionDefinition.Text = splitResolution[1].TrimEnd(')');

            using (OptionsResolutionList.Update update = new OptionsResolutionList.Update())
            {
                update.RefreshForm(optionsResolutionR, true);
                optionsResolutionEdit.Enabled = false;
                optionsResolutionRemove.Enabled = false;
            }

            optionsResolutionAdd.Text = "Save";
        }

        #endregion

        #region Updates

        /// <summary>
        /// Shows a change log for the selected version
        /// </summary>
        private void optionsUpdatesPast_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show the change log for the selected item
            ChangeLog changeLog = new ChangeLog(optionsUpdatesPast.Text.ToString());
            changeLog.ShowDialog(this);
        }

        #endregion

        #region Footer

        /// <summary>
        /// Resets all settings back to defaults
        /// </summary>
        private void defaultSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset all settings back to default?", "Default Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Reinitialize the window
                InitializeOptions(true);
            }
        }

        /// <summary>
        /// Disposes of the form without saving the changes made
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Disposes of the form after saving the changes made
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (optionsResolutionAdd.Text == "Save")
            {
                // Show the dialog
                DialogResult result = MessageBox.Show("You did not save the resolution you were editing. Are you sure you want to continue?",
                    "Resolution not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    // Quit the save process
                    return;
                }
            }

            #region Save Settings

            using (IniFile iniFile = new IniFile())
            {
                // Switch: Default profile
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                #region General

                #region Run the Texture Max Load Editor when FSX starts

                if (optionsGeneral0.Checked)
                {
                    // Write the setting value
                    iniFile.WriteValue("OPTIONS.GENERAL", "runfsx", "1");

                    ///<switch>locations.ini</switch>
                    iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                    using (ExeXML exeXml = new ExeXML(iniFile.ReadValue("LOCATIONS", "cfg") + @"\exe.xml"))
                    {
                        ///<switch>current profile</switch>
                        iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                        iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                        // Check the existence of the document
                        exeXml.CheckExistence("Texture Max Load Editor", false, Application.ExecutablePath);
                    }
                }
                else
                {
                    // Write the setting value
                    iniFile.WriteValue("OPTIONS.GENERAL", "runfsx", "0");

                    ///<switch>locations.ini</switch>
                    iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                    using (ExeXML exeXml = new ExeXML(iniFile.ReadValue("LOCATIONS", "cfg") + @"\exe.xml"))
                    {
                        ///<switch>current profile</switch>
                        iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                        iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                        // Check the existence of the document
                        exeXml.CheckExistence("Texture Max Load Editor", true, Application.ExecutablePath);
                    }
                }

                #endregion

                #region Run the Texture Max Load Editor when you log onto this user account

                // The full path to the application shortcut
                string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Texture Max Load Editor.lnk";

                if (optionsGeneral1.Checked)
                {
                    iniFile.WriteValue("OPTIONS.GENERAL", "runwin", "1");

                    if (!System.IO.File.Exists(shortcutPath))
                    {
                        WshShellClass wshShell = new WshShellClass();
                        IWshRuntimeLibrary.IWshShortcut appShortcut;
                        appShortcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(shortcutPath);
                        appShortcut.TargetPath = Application.ExecutablePath;
                        appShortcut.Description = "Texture Max Load Editor";
                        appShortcut.Save();
                    }
                }
                else
                {
                    iniFile.WriteValue("OPTIONS.GENERAL", "runwin", "0");

                    if (System.IO.File.Exists(shortcutPath))
                    {
                        System.IO.File.Delete(shortcutPath);
                    }
                }
                shortcutPath = null;

                #endregion

                #region Start this application minimized:

                if (optionsGeneral2.Checked)
                    iniFile.WriteValue("OPTIONS.GENERAL", "minimize", "1");
                else
                    iniFile.WriteValue("OPTIONS.GENERAL", "minimize", "0");

                #endregion

                #region When started with FSX || Always

                if (optionsGeneral30.Checked)
                    iniFile.WriteValue("OPTIONS.GENERAL", "sub", "0");
                else
                    iniFile.WriteValue("OPTIONS.GENERAL", "sub", "1");

                #endregion

                #endregion

                #region Auto Change

                #region Auto Change enabled

                if (optionsAuto0.Checked)
                {
                    iniFile.WriteValue("OPTIONS.AUTO", "auto", "1");
                }
                else
                {
                    iniFile.WriteValue("OPTIONS.AUTO", "auto", "0");
                }

                #endregion

                #region Auto change resolution

                try
                {
                    string[] selectedAutoRes = optionsAuto1.SelectedItem.ToString().Split(' ');
                    iniFile.WriteValue("OPTIONS.AUTO", "resolution", selectedAutoRes[0]);
                }
                catch
                {
                    MessageBox.Show("Unable to set the Auto Change resolution selected. An item was either not selected or in the wrong format.",
                        "Unable To Save Auto Change Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                #endregion

                #region Application to run after change

                iniFile.WriteValue("OPTIONS.AUTO", "application", optionsAuto2.Text.ToString());

                #endregion

                #region Exit after resolution change

                if (optionsAuto3.Checked)
                {
                    iniFile.WriteValue("OPTIONS.AUTO", "close", "1");
                }
                else
                {
                    iniFile.WriteValue("OPTIONS.AUTO", "close", "0");
                }

                #endregion

                #endregion

                #region Resolutions

                string trimmedItem;
                int counter = 0;

                while (iniFile.ReadValue("RESOLUTIONS", counter.ToString()) != "")
                {
                    iniFile.WriteValue("RESOLUTIONS", counter.ToString(), "");
                    counter++;
                }

                counter = 0;

                foreach (string item in optionsResolutionR.Items)
                {
                    trimmedItem = item;
                    trimmedItem = trimmedItem.Replace(" (", ",");
                    trimmedItem = trimmedItem.TrimEnd(')');

                    iniFile.WriteValue("RESOLUTIONS", counter.ToString(), trimmedItem);

                    counter++;
                }

                #endregion

                #region Updates

                if (optionsUpdates1.Checked)
                {
                    iniFile.WriteValue("OPTIONS.UPDATE", "autocheck", "1");
                }
                else
                {
                    iniFile.WriteValue("OPTIONS.UPDATE", "autocheck", "0");
                }

                #endregion
            }

            #endregion

            // Dispose of the form
            this.Dispose();
        }

        #endregion
    }
}