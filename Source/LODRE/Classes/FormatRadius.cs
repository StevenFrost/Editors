using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using iniLib;

namespace LODRadiusEditor
{
    class Format : IDisposable
    {
        public string Radius(string radius)
        {
            // Method variables
            string[] splitRadius;
            string finalResult;

            if (!radius.Contains("."))
            {
                // Format the string
                finalResult = String.Format("{0}.000000", radius);
            }
            else
            {
                // Split the radius at the decimal point
                splitRadius = radius.Split('.');

                while (splitRadius[1].Length != 6)
                {
                    if (splitRadius[1].Length > 6)
                    {
                        // Remove the last number from the string
                        splitRadius[1] = splitRadius[1].Remove(splitRadius[1].Length - 1, 1);
                    }
                    else
                    {
                        // Add a zero to the end of the string
                        splitRadius[1] += "0";
                    }
                }

                // Format the string
                finalResult = String.Format("{0}.{1}", splitRadius[0], splitRadius[1]);
            }

            // Return the formatted radius
            return finalResult;
        }

        public string Compact(string radius)
        {
            // Method variables
            string[] splitRadius;
            string finalResult;

            if (!radius.Contains("."))
            {
                // Format the string
                finalResult = String.Format("{0}.0", radius);
            }
            else
            {
                // Split the radius at the decimal point
                splitRadius = radius.Split('.');

                while (splitRadius[1].Length != 1)
                {
                    if (splitRadius[1].Length > 1)
                    {
                        // Remove the last number from the string
                        splitRadius[1] = splitRadius[1].Remove(splitRadius[1].Length - 1, 1);
                    }
                    else
                    {
                        // Add a zero to the end of the string
                        splitRadius[1] += "0";
                    }
                }

                // Format the string
                finalResult = String.Format("{0}.{1}", splitRadius[0], splitRadius[1]);
            }

            // Return the formatted radius
            return finalResult;
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }
}