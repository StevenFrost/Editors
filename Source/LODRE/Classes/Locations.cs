using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LODRadiusEditor.Locations
{
    class FSX : IDisposable
    {
        // Class variables
        private string fsxCfgPath, fsxReg32, fsxReg64;

        /// <summary>
        /// Class constructor
        /// </summary>
        public FSX()
        {
            // Find the locations
            findCfgLocation();
            findExeLocation();
        }

        /// <summary>
        /// Finds the current fsx.cfg location
        /// </summary>
        private void findCfgLocation()
        {
            // Get the location of fsx.CFG folder
            fsxCfgPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + @"\Microsoft\FSX";
        }

        /// <summary>
        /// Finds the current fsx.exe location
        /// </summary>
        private void findExeLocation()
        {
            try
            {
                // Try to get the 32Bit registry value
                RegistryKey registry32Bit = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\microsoft games\flight simulator\10.0\");
                fsxReg32 = registry32Bit.GetValue("SetupPath").ToString();
                registry32Bit.Close();
            }
            catch
            {
                // null the string, the value is not there
                fsxReg32 = null;
            }

            try
            {
                // Try to get the 64Bit registry value
                RegistryKey registry64Bit = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\microsoft games\flight simulator\10.0\");
                fsxReg64 = registry64Bit.GetValue("SetupPath").ToString();
                registry64Bit.Close();
            }
            catch
            {
                // null the string, the value is not there
                fsxReg64 = null;
            }
        }

        /// <summary>
        /// Returns the full path to fsx.exe without a tailing \
        /// </summary>
        /// <returns></returns>
        public string GetExe()
        {
            // Check the FSX.EXE location
            if (fsxReg32 != null)
            {
                // Check the ending of the string
                if (fsxReg32.EndsWith(@"\"))
                {
                    // Remove the slash
                    fsxReg32 = fsxReg32.Remove(fsxReg32.Length - 1, 1);
                }

                // Check if the directory actually exists
                if (Directory.Exists(fsxReg32) == true)
                {
                    // Return the full path to the calling thread
                    return fsxReg32;
                }
                else
                {
                    // The directory does not exist, show an error
                    MessageBox.Show("Unable to find your FSX root directory. Please make sure Flight Simulator X is installed.",
                                    "Unable to find FSX directory",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );

                    // Return nothing
                    return "";
                }
            }
            else if (fsxReg64 != null)
            {
                // Check the ending of the string
                if (fsxReg64.EndsWith(@"\"))
                {
                    // Remove the slash
                    fsxReg64 = fsxReg64.Remove(fsxReg64.Length - 1, 1);
                }

                // Check if the directory actually exists
                if (Directory.Exists(fsxReg64) == true)
                {
                    // Return the full path to the calling thread
                    return fsxReg64;
                }
                else
                {
                    // The directory does not exist, show an error
                    MessageBox.Show("Unable to find your FSX root directory. Please make sure Flight Simulator X is installed.",
                                    "Unable to find FSX directory",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );

                    // Return nothing
                    return "";
                }
            }
            else
            {
                // FSX registry value not found or is empty, show an error
                MessageBox.Show("Unable to find a core FSX registry value. Please make sure that you have ran FSX at least once before running the Level of Detail Radius Editor.",
                                "Unable to find core registry values",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                // Return nothing
                return "";
            }
        }

        /// <summary>
        /// Returns the full path to fsx.cfg without the tailing \
        /// </summary>
        /// <returns></returns>
        public string GetCfg()
        {
            if (Directory.Exists(fsxCfgPath) == true)
            {
                // return the fsx.CFG path to the calling thread
                return fsxCfgPath;
            }
            else
            {
                // FSX registry value not found or is empty, show an error
                MessageBox.Show("Unable to find the fsx.CFG directory. Please make sure that you have ran FSX at least once before running the Level of Detail Radius Editor.",
                                "Unable to find fsx.CFG path",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                // Return nothing
                return "";
            }
        }

        /// <summary>
        /// Disposes of class objects
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }
}
