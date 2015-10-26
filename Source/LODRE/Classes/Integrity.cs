using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using iniLib;

namespace LODRadiusEditor.Integrity
{
    class Existence : IDisposable
    {
        /// <summary>
        /// Checks if the core locations exist
        /// </summary>
        /// <returns>True if all locations exist</returns>
        public bool CoreLocations()
        {
            using (IniFile iniFile = new IniFile())
            {
                /// <switch>current profile</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                if (Directory.Exists(iniFile.ReadValue("LOCATIONS", "exe")) && Directory.Exists(iniFile.ReadValue("LOCATIONS", "cfg")) && Directory.Exists(iniFile.ReadValue("LOCATIONS", "self")))
                    return true;

                return false;
            }
        }

        /// <summary>
        /// Checks if the current profile exists
        /// </summary>
        /// <returns>True if the profile exists</returns>
        public bool CurrentProfile()
        {
            using (IniFile iniFile = new IniFile())
            {
                /// <switch>current profile</switch>
                iniFile.IniPath = Application.StartupPath + @"\locations.ini";

                if (File.Exists(Application.StartupPath + iniFile.ReadValue("PROFILES", "0")))
                    return true;

                return false;
            }
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }

    class Hash : IDisposable
    {
        /// <summary>
        /// Compares the current SHA-1 hash value to the one specified
        /// </summary>
        /// <param name="fileName">The full path of the file to check</param>
        /// <param name="hash">The calculated hash value to compare</param>
        /// <returns>True if the hash values match</returns>
        public bool Match(string fileName, string hash)
        {
            if (CalculateSHA1(fileName) == hash)
                return true;

            return false;
        }

        /// <summary>
        /// Calculates an SHA-1 hash
        /// </summary>
        private string CalculateSHA1(string fileLocation)
        {
            // Private variables
            byte[] hash;
            string formattedHash;

            // File stream
            FileStream fileStream = new FileStream(fileLocation, FileMode.Open);

            using (SHA1Managed sha1 = new SHA1Managed())
            {
                // Calculate the hash
                hash = sha1.ComputeHash(fileStream);
                formattedHash = string.Empty;

                foreach (byte b in hash)
                {
                    formattedHash += b.ToString("X2");
                }
            }

            // Close the stream
            fileStream.Close();

            // Return the file hash
            return formattedHash;
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }
}
