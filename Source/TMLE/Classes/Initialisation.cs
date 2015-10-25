using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iniLib;

namespace TextureMaxLoadEditor
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
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if a specified process is currently open
        /// </summary>
        /// <param name="name">The process name to check</param>
        /// <returns>true if the specified process is running</returns>
        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }

    class Resolutions : IDisposable
    {
        /// <summary>
        /// Fills a field with the resolutions found in the default profile
        /// </summary>
        /// <param name="comboBox">The ComboBox to fill</param>
        /// <param name="listBox">The ListBox to fill</param>
        public void FillField(ComboBox comboBox, [Optional, DefaultParameterValue(null)] ListBox listBox)
        {
            int counter = 0;
            string iniValue;
            string[] iniSplit;

            if (listBox == null && comboBox != null)
                comboBox.Items.Clear();
            else if (listBox != null && comboBox == null)
                listBox.Items.Clear();

            using (IniFile iniFile = new IniFile())
            {
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = Application.StartupPath + iniFile.ReadValue("PROFILES", "0");

                while (counter != -1)
                {
                    iniValue = iniFile.ReadValue("RESOLUTIONS", counter.ToString());

                    if (iniValue != "")
                    {
                        iniSplit = iniValue.Split(',');

                        if (listBox == null && comboBox != null)
                            comboBox.Items.Add(iniSplit[0].ToString() + " (" + iniSplit[1] + ")");
                        else if (listBox != null && comboBox == null)
                            listBox.Items.Add(iniSplit[0].ToString() + " (" + iniSplit[1] + ")");
                        counter++;
                    }
                    else
                    {
                        counter = -1;
                    }
                }
            }
        }

        /// <summary>
        /// Sets the resolution drop down selected item to the one that is set in fsx.cfg
        /// </summary>
        public void SelectCurrentResolution(ComboBox comboBox, [Optional]string resolution)
        {
            using (IniFile iniFile = new IniFile())
            {
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";
                iniFile.IniPath = iniFile.ReadValue("LOCATIONS", "cfg") + @"\fsx.cfg";

                if (resolution != null)
                {
                    comboBox.SelectedIndex = comboBox.FindString(resolution, -1);

                    if (comboBox.SelectedIndex == -1)
                        comboBox.SelectedIndex = 0;
                }
                else
                {
                    comboBox.SelectedIndex = comboBox.FindString(iniFile.ReadValue("GRAPHICS", "TEXTURE_MAX_LOAD"), -1);

                    if (comboBox.SelectedIndex == -1)
                        comboBox.SelectedIndex = 0;
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