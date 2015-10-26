using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iniLib;

namespace LODRadiusEditor.Initialization
{
    class InitMain : IDisposable
    {
        /// <summary>
        /// Checks for another instance of this application
        /// </summary>
        public bool IsSingleInstance(string formTitle)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle == formTitle)
                {
                    // Another instance was found
                    return false;
                }
            }

            // No other instances were found
            return true;
        }

        /// <summary>
        /// Checks if a specified process is currently open
        /// </summary>
        /// <param name="name">The process name to check</param>
        /// <returns>true if the specified process is running</returns>
        public bool IsProcessOpen(string name)
        {
            // Loop round all current processes
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    // Return true
                    return true;
                }
            }

            // Return false
            return false;
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }

    class Radii : IDisposable
    {
        /// <summary>
        /// Fills a field with the radii found in the default profile
        /// </summary>
        /// <param name="comboBox">The ComboBox to fill</param>
        /// <param name="listBox">The ListBox to fill</param>
        public void FillField(ComboBox comboBox, [Optional, DefaultParameterValue(null)] ListBox listBox)
        {
            // Method vars
            int counter = 0; string iniValue; string[] iniSplit;

            // Clear the current items
            if (listBox == null && comboBox != null)
                comboBox.Items.Clear();
            else if (listBox != null && comboBox == null)
                listBox.Items.Clear();

            using (IniFile iniFile = new IniFile())
            {
                /// <switch>current profile</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                while (counter != -1)
                {
                    // Read the radius value
                    iniValue = iniFile.ReadValue("RADII", counter.ToString());

                    if (iniValue != "")
                    {
                        // Split the radius string
                        iniSplit = iniValue.Split(',');

                        // Add the new item to the list
                        if (listBox == null && comboBox != null)
                            comboBox.Items.Add(iniSplit[0].ToString() + " (" + iniSplit[1] + ")");
                        else if (listBox != null && comboBox == null)
                            listBox.Items.Add(iniSplit[0].ToString() + " (" + iniSplit[1] + ")");

                        // Increase the counter
                        counter++;
                    }
                    else
                    {
                        // Break out of the loop
                        counter = -1;
                    }
                }
            }
        }

        /// <summary>
        /// Sets the radius drop down selected item to the one that is set in fsx.cfg
        /// </summary>
        public void SelectCurrentRadius(ComboBox comboBox, [Optional]string radius)
        {
            // Method variables
            string formattedRadius;

            using (IniFile iniFile = new IniFile())
            {
                /// <switch>fsx.cfg</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = iniFile.ReadValue("LOCATIONS", "cfg") + @"\fsx.cfg";

                if (radius != null)
                {
                    // Format the radius
                    using (Format format = new Format())
                        formattedRadius = format.Compact(radius);

                    // Set the current selected item
                    comboBox.SelectedIndex = comboBox.FindString(formattedRadius, -1);

                    // Set the index to the first
                    if (comboBox.SelectedIndex == -1)
                        comboBox.SelectedIndex = 0;

                }
                else
                {
                    using (Format format = new Format())
                    {
                        // Set the radius to the current one in fsx.cfg
                        comboBox.SelectedIndex = comboBox.FindString(format.Compact(iniFile.ReadValue("TERRAIN", "LOD_RADIUS")), -1);

                        // Set the index to the first
                        if (comboBox.SelectedIndex == -1)
                            comboBox.SelectedIndex = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }
}