using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iniLib;

namespace TextureMaxLoadEditor.Forms
{
    public partial class Main : Form
    {
        #region Private Variables

        private bool requireExit = false;
        private bool fsxIsRunning = false;
        private bool autoChangeExit = false;
        private int autoSeconds;
        private int autoCounter;
        private bool autoFired = false;
        private string currentValue;

        #endregion

        #region Draw Override

        /// <summary>
        /// Over-rides the createParams function to force the form to draw the contents
        /// before displaying anything. Reduces form flicker
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        /// <summary>
        /// Form Constructor
        /// </summary>
        public Main()
        {
            InitializeComponent();
            Icon = global::TextureMaxLoadEditor.Properties.Resources.icon;

            #region Check for existing instanstance

            using (InitMain initialize = new InitMain())
            {
                if (!initialize.IsSingleInstance(Text))
                {
                    MessageBox.Show("Another instance of this application is already running.",
                        "Multiple application instances", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    requireExit = true;
                }
            }

            #endregion

            #region Check if FSX is running

            using (InitMain initialize = new InitMain())
            {
                if (initialize.IsProcessOpen("fsx"))
                {
                    fsxIsRunning = true;
                }
            }

            #endregion

            #region Integrity Checks

            #region Check File Existence and Hash

            using (Hash hash = new Hash())
            {
                if (File.Exists(Application.StartupPath + @"\Resources\core.resource"))
                {
                    if (hash.Match(Application.StartupPath + @"\Resources\core.resource", "700BE7CE784D666F91B911C149E5602B48652939"))
                    {
                        // Get the file lines one by one
                        string[] lines = File.ReadAllLines(Application.StartupPath + @"\Resources\core.resource");

                        for (int i = 0; i < lines.Length; i++)
                        {
                            // Split the line
                            string[] splitLine = lines[i].Split(';');

                            if (File.Exists(Application.StartupPath + splitLine[0]))
                            {
                                if (!hash.Match(Application.StartupPath + splitLine[0], splitLine[1]))
                                {
                                    // Show an error
                                    MessageBox.Show("The file " + splitLine[0] + " has been modified or is corrupt. Please reinstall the Texture Max Load Editor.",
                                        "Integrity Check", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    // Require an exit
                                    requireExit = true;
                                }
                            }
                            else
                            {
                                // Show an error
                                MessageBox.Show("The file " + splitLine[0] + " could not be found. Please reinstall the Texture Max Load Editor.",
                                    "Integrity Check", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                // Require an exit
                                requireExit = true;
                            }
                        }
                    }
                    else
                    {
                        // Show an error
                        MessageBox.Show("The file core.resource has been modified or is corrupt. Please reinstall the Texture Max Load Editor.",
                            "Integrity Check", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Require an exit
                        requireExit = true;
                    }
                }
                else
                {
                    // Show an error
                    MessageBox.Show("The file core.resource could not be found. Please reinstall the Texture Max Load Editor.",
                        "Integrity Check", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Require an exit
                    requireExit = true;
                }
            }

            #endregion

            #region Check INI Files

            using (IniFile iniFile = new IniFile())
            {
                /// <switch>current profile</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                if (!File.Exists(Application.StartupPath + @"\locations.ini"))
                {
                    // Copy the locations resource
                    File.Copy(Application.StartupPath + @"\Resources\locations.resource",
                        Application.StartupPath + @"\locations.ini", false);
                }

                if (!File.Exists(Application.StartupPath + iniFile.ReadValue("PROFILES", "0")))
                {
                    try
                    {
                        if (!Directory.Exists(Application.StartupPath + @"\Profiles\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + @"\Profiles\");
                        }

                        if (!File.Exists(Application.StartupPath + @"\Profiles\default.ini"))
                        {
                            // Copy the resource
                            File.Copy(Application.StartupPath + @"\Resources\profile.resource",
                                Application.StartupPath + @"\Profiles\default.ini", false);
                        }

                        // Write the new path value
                        iniFile.WriteValue("PROFILES", "0", @"\Profiles\default.ini");

                        // Success message
                        MessageBox.Show("The default profile specified in 'locations.ini' could not be found. A new one has been automatically generated.",
                            "Integrity Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        // Error message
                        MessageBox.Show("The default profile specified in 'locations.ini' could not be found and a new profile could not be generated. Please reinstall the Texture Max Load Editor.",
                            "Integrity Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            #endregion

            #region Check INI Variables

            using (IniFile iniFile = new IniFile())
            {
                using (Existence existence = new Existence())
                {
                    /// <switch>current profile</switch>
                    iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                    if (!Directory.Exists(iniFile.ReadValue("LOCATIONS", "exe")) &&
                        !Directory.Exists(iniFile.ReadValue("LOCATIONS", "cfg")) &&
                        !Directory.Exists(iniFile.ReadValue("LOCATIONS", "self")))
                    {
                        // Require a locations reset
                        iniFile.WriteValue("GENERAL", "reset", "1");
                    }
                }
            }

            #endregion

            #endregion

            #region Check For Reset Switch

            using (IniFile iniFile = new IniFile())
            {
                /// <switch>locations.ini</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                if (iniFile.ReadValue("GENERAL", "reset") == "1")
                {
                    using (Locations.FSX fsxLocations = new Locations.FSX())
                    {
                        // Reset the location variables
                        iniFile.WriteValue("LOCATIONS", "exe", fsxLocations.GetExe());
                        iniFile.WriteValue("LOCATIONS", "cfg", fsxLocations.GetCfg());
                        iniFile.WriteValue("LOCATIONS", "self", Application.StartupPath);
                    }

                    try
                    {
                        if (File.Exists(iniFile.ReadValue("LOCATIONS", "cfg") + @"\exe.xml"))
                        {
                            string dateTime = DateTime.Now.ToString();
                            dateTime = dateTime.Replace("/", "");
                            dateTime = dateTime.Replace(" ", "_");
                            dateTime = dateTime.Replace(":", "");

                            if (!Directory.Exists(Application.StartupPath + @"\Backups\"))
                            {
                                Directory.CreateDirectory(Application.StartupPath + @"\Backups\");
                            }

                            // Make a copy of exe.xml
                            File.Copy(iniFile.ReadValue("LOCATIONS", "cfg") + @"\exe.xml", Application.StartupPath + @"\Backups\exe_xml_backup_" + dateTime + ".bak");
                        }
                    }
                    catch
                    {
                        // Show an error
                        MessageBox.Show("Unable to make a copy of exe.xml. The file has not been backed up.",
                            "Unable to backup exe.xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Set the reset value back to 0
                    iniFile.WriteValue("GENERAL", "reset", "0");
                }
            }

            #endregion

            #region Set Main Resolutions

            using (Resolutions resolutions = new Resolutions())
            {
                // Set the resolution list items
                resolutions.FillField(homeResolution, null);
            }

            #endregion

            #region Set Location Fields

            using (IniFile iniFile = new IniFile())
            {
                /// <switch>locations.ini</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                // Set the location fields
                homeExePath.Text = iniFile.ReadValue("LOCATIONS", "exe");
                homeCfgPath.Text = iniFile.ReadValue("LOCATIONS", "cfg");
            }

            #endregion

            #region Switch Main Resolution To Current

            using (Resolutions resolutions = new Resolutions())
            {
                // Select the current resolution in fsx.cfg
                resolutions.SelectCurrentResolution(homeResolution, null);

                // Set the current value
                string[] selectedItem = homeResolution.SelectedItem.ToString().Split(' ');
                currentValue = selectedItem[0];
                selectedItem = null;
            }

            #endregion

            #region Check for exe.xml existence and entry

            using (IniFile iniFile = new IniFile())
            {
                ///<switch>locations.ini</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                using (ExeXML exeXml = new ExeXML(iniFile.ReadValue("LOCATIONS", "cfg") + @"\exe.xml"))
                {
                    ///<switch>current profile</switch>
                    iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                    if (iniFile.ReadValue("OPTIONS.GENERAL", "runfsx") == "1")
                    {
                        // Check the existence of the document
                        exeXml.CheckExistence("Texture Max Load Editor", false, Application.ExecutablePath);
                    }
                    else
                    {
                        // Check the existence of the document
                        exeXml.CheckExistence("Texture Max Load Editor", true, Application.ExecutablePath);
                    }
                }
            }

            #endregion

            #region Minimize the Form

            using (IniFile iniFile = new IniFile())
            {
                /// <switch>current profile</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                if (iniFile.ReadValue("OPTIONS.GENERAL", "minimize") == "1")
                {
                    if (iniFile.ReadValue("OPTIONS.GENERAL", "sub") == "0")
                    {
                        if (fsxIsRunning)
                            this.WindowState = FormWindowState.Minimized;
                    }
                    else
                        this.WindowState = FormWindowState.Minimized;
                }
            }

            #endregion

            #region Auto Change

            using (IniFile iniFile = new IniFile())
            {
                /// <switch>current profile</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                if (iniFile.ReadValue("OPTIONS.AUTO", "auto") == "1")
                {
                    // Get the auto resolution
                    string autoResolution = iniFile.ReadValue("OPTIONS.AUTO", "resolution");

                    if (autoResolution != "")
                    {
                        /// <switch>fsx.cfg</switch>
                        iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                        iniFile.IniPath = iniFile.ReadValue("LOCATIONS", "cfg") + @"\fsx.cfg";

                        // Set the Texture Max Load Value in fsx.cfg
                        iniFile.WriteValue("GRAPHICS", "TEXTURE_MAX_LOAD", autoResolution);

                        /// <switch>current profile</switch>
                        iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                        iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");
                    }
                    else
                    {
                        // Show an error informing the user that the TML value has not been set
                        MessageBox.Show("Unable to set a null resolution. The Texture Max Load value has not been changed in fsx.cfg.",
                            "Null resolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (iniFile.ReadValue("OPTIONS.AUTO", "application") != "")
                    {
                        try
                        {
                            // Try to start the specified process
                            System.Diagnostics.Process.Start(iniFile.ReadValue("OPTIONS.AUTO", "application"));
                        }
                        catch
                        {
                            // Show an error informing the user that their application could not be started
                            MessageBox.Show("Unable to run the post auto change application you specified.",
                                "External process error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (iniFile.ReadValue("OPTIONS.AUTO", "close") == "1")
                    {
                        // Set the seconds for the timer
                        autoSeconds = Int32.Parse(iniFile.ReadValue("MISCELLANEOUS", "autotime"));

                        // Require an exit
                        autoCounter = 0;
                        autoChangeExit = true;
                    }
                    else
                    {
                        // Make the auto counter negative
                        autoCounter = -1;
                    }
                }
            }

            #endregion
        }

        #region Load Routines

        /// <summary>
        /// Checks for a required exit that occurred during initialization
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            if (requireExit)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Shows the auto change dialog when the form is shown
        /// </summary>
        private void Main_Shown(object sender, EventArgs e)
        {
            if (!autoFired)
            {
                if (autoChangeExit && this.WindowState == FormWindowState.Normal)
                {
                    // Stop the auto change exit timer
                    autoTimer.Stop();

                    // Report that auto change has been fired
                    autoFired = true;

                    // Show the auto close dialog
                    Auto auto = new Auto(autoSeconds);
                    auto.ShowDialog();
                }
                else if (autoChangeExit && this.WindowState == FormWindowState.Minimized)
                {
                    // Enable the auto change timer
                    autoTimer.Enabled = true;
                }
            }
        }

        #endregion

        #region TitleBar

        #region TitleBar Move Objects

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        /// <summary>
        /// Capture the MouseDown event and move the form
        /// This version supports AeroShake functionality in Windows 7 +
        /// </summary>
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Open the help PDF
        /// </summary>
        private void titleBarHelpButton_ButtonClick()
        {
            try
            {
                // Open the user manual
                System.Diagnostics.Process.Start(Application.StartupPath + @"\Documents\User Manual.pdf");
            }
            catch
            {
                // Show an error
                MessageBox.Show("Unable to locate or open the user manual. Please make sure that you have a PDF reader installed on your computer.",
                    "User Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Minimize the current instance of the application
        /// </summary>
        private void titleBarMinimizeButton_ButtonClick()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Close the current instance of the application
        /// This function is caught to clean things up before closing
        /// </summary>
        private void titleBarCloseButton_ButtonClick()
        {
            Application.Exit();
        }

        #endregion

        #region Navigation

        /// <summary>
        /// Applies the current selected resolution to fsx.cfg
        /// </summary>
        private void homeApplyButton_ButtonClick()
        {
            using (IniFile iniFile = new IniFile())
            {
                /// <switch>current profile</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                // Ding var
                bool ding = false;

                // Check for the secret ding switch
                if (iniFile.ReadValue("MISCELLANEOUS", "ding") == "1")
                    ding = true;

                /// <switch>fsx.cfg</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                if (System.IO.File.Exists(iniFile.ReadValue("LOCATIONS", "cfg") + @"\fsx.cfg"))
                {
                    if (System.IO.File.Exists(iniFile.ReadValue("LOCATIONS", "exe") + @"\fsx.exe"))
                    {
                        iniFile.IniPath = iniFile.ReadValue("LOCATIONS", "cfg") + @"\fsx.cfg";

                        if (homeResolution.SelectedItem != null)
                        {
                            // Ding!
                            if (ding)
                                using (Sound.TmleSound sound = new Sound.TmleSound())
                                    sound.Play(Application.StartupPath + @"\Resources\apply.resource", sound.SND_FILENAME | sound.SND_ASYNC);

                            // Split the selected item up into a new array
                            string[] selectedItem = homeResolution.SelectedItem.ToString().Split(' ');

                            // Write the value to fsx.cfg
                            iniFile.WriteValue("GRAPHICS", "TEXTURE_MAX_LOAD", selectedItem[0].ToString());

                            // Null the form owner (.Net 1.1 -> 2.0 workaround)
                            Form formOwner = this.Owner;
                            this.Owner = null;

                            // Show the apply box
                            Apply apply = new Apply(selectedItem[0].ToString());
                            apply.ShowDialog();

                            // Reset the form owner
                            this.Owner = formOwner;
                        }
                        else
                        {
                            MessageBox.Show("Please select a resolution to apply from the resolutions drop down box",
                                "Unable to set resolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your fsx.exe file could not be located. Please make sure you have selected your correct fsx.exe folder.",
                            "Unable to find fsx.exe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Your fsx.cfg file could not be located. Please make sure you have run FSX at least once before trying to apply a resolution.",
                        "Unable to find fsx.cfg", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Opens the options window
        /// </summary>
        private void homeOptionsButton_ButtonClick()
        {
            // Create a new optionsBox object
            Options optionsBox = new Options(currentValue);

            // Null the form owner (.Net 1.1 -> 2.0 workaround)
            Form formOwner = this.Owner;
            this.Owner = null;

            // Show the options box
            optionsBox.ShowDialog();

            // Reset the form owner
            this.Owner = formOwner;

            using (Resolutions resolutions = new Resolutions())
            {
                // Set the resolution list items
                resolutions.FillField(homeResolution, null);
            }

            using (Resolutions resolutions = new Resolutions())
            {
                // Select the current resolution in fsx.cfg
                resolutions.SelectCurrentResolution(homeResolution, null);
            }
        }

        /// <summary>
        /// Opens the about window
        /// </summary>
        private void homeAboutButton_ButtonClick()
        {
            // Create a new aboutBox object
            About aboutBox = new About();

            // Null the form owner (.Net 1.1 -> 2.0 workaround)
            Form formOwner = this.Owner;
            this.Owner = null;

            // Show the about box
            aboutBox.ShowDialog();

            // Reset the form owner
            this.Owner = formOwner;
        }

        #endregion

        #region Location Clicks

        /// <summary>
        /// Opens a folder browser dialog to find the fsx.exe path
        /// The path is then stored in locations.ini
        /// </summary>
        private void homeExePath_Click(object sender, EventArgs e)
        {
            // Set the folder browser description
            homeBrowser.Description = homeBrowser.Description.Replace("[0]", "Flight Simulator X executable");

            using (IniFile iniFile = new IniFile())
            {
                // Switch: locations.ini
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                // Set the current selected path to the one in the ini
                homeBrowser.SelectedPath = iniFile.ReadValue("LOCATIONS", "exe");

                // Show the folder browser
                homeBrowser.ShowDialog();

                // Write the new value to the ini file
                iniFile.WriteValue("LOCATIONS", "exe", homeBrowser.SelectedPath.ToString());

                // Update the textbox
                homeExePath.Text = iniFile.ReadValue("LOCATIONS", "exe");
            }

            // Reset the folder browser description
            homeBrowser.Description = homeBrowser.Description.Replace("Flight Simulator X executable", "[0]");
        }

        /// <summary>
        /// Opens a folder browser dialog to find the fsx.cfg path
        /// The path is then stored in locations.ini
        /// </summary>
        private void homeCfgPath_Click(object sender, EventArgs e)
        {
            // Set the folder browser description
            homeBrowser.Description = homeBrowser.Description.Replace("[0]", "Flight Simulator X configuration file");

            using (IniFile iniFile = new IniFile())
            {
                // Switch: locations.ini
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                // Set the current selected path to the one in the ini
                homeBrowser.SelectedPath = iniFile.ReadValue("LOCATIONS", "cfg");

                // Show the folder browser
                homeBrowser.ShowDialog();

                // Write the new value to the ini file
                iniFile.WriteValue("LOCATIONS", "cfg", homeBrowser.SelectedPath.ToString());

                // Update the textbox
                homeCfgPath.Text = iniFile.ReadValue("LOCATIONS", "cfg");
            }

            // Reset the folder browser description
            homeBrowser.Description = homeBrowser.Description.Replace("Flight Simulator X configuration file", "[0]");
        }

        /// <summary>
        /// Deselects all selected text and actives the relative label
        /// </summary>
        private void homeExePath_Enter(object sender, EventArgs e)
        {
            homeExePath.DeselectAll();
            ActiveControl = homeFsxExeL;
        }

        /// <summary>
        /// Deselects all selected text and actives the relative label
        /// </summary>
        private void homeCfgPath_Enter(object sender, EventArgs e)
        {
            homeCfgPath.DeselectAll();
            ActiveControl = homeFsxCfgL;
        }

        /// <summary>
        /// Displays a tooltip on mouse hover
        /// </summary>
        private void homeExePath_MouseHover(object sender, EventArgs e)
        {
            using (IniFile iniFile = new IniFile())
            {
                // Switch: Default profile
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                if (iniFile.ReadValue("MISCELLANEOUS", "tooltips") == "1")
                {
                    // Show the tool tip
                    homeToolTip.Show(homeExePath.Text, homeExePath);
                }
            }
        }

        /// <summary>
        /// Displays a tooltip on mouse hover
        /// </summary>
        private void homeCfgPath_MouseHover(object sender, EventArgs e)
        {
            using (IniFile iniFile = new IniFile())
            {
                // Switch: Default profile
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                if (iniFile.ReadValue("MISCELLANEOUS", "tooltips") == "1")
                {
                    // Show the tool tip
                    homeToolTip.Show(homeCfgPath.Text, homeCfgPath);
                }
            }
        }

        #endregion

        #region Auto Change Timer

        /// <summary>
        /// Counts the time for the auto change timer when the application is minimized
        /// </summary>
        private void autoTimer_Tick(object sender, EventArgs e)
        {
            if (autoSeconds != 0)
            {
                // Decrease the time
                autoSeconds--;
            }
            else
            {
                // Stop the timer
                autoTimer.Stop();

                // Close the application
                Application.Exit();
            }
        }

        /// <summary>
        /// Stops the timer once the form has been resized (pulled from the taskbar)
        /// </summary>
        private void Main_Resize(object sender, EventArgs e)
        {
            if (!autoFired)
            {
                if (autoChangeExit && this.WindowState == FormWindowState.Normal)
                {
                    if (autoCounter == 2 || (autoTimer.Enabled))
                    {
                        // Stop the auto change exit timer
                        autoTimer.Stop();

                        // Report that auto change has been fired
                        autoFired = true;

                        // Show the auto close dialog
                        Auto auto = new Auto(autoSeconds);
                        auto.ShowDialog();
                    }

                    // Increase the counter
                    autoCounter++;
                }
            }
        }

        #endregion
    }
}