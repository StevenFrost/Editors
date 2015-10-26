using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace LODRadiusEditor
{
    class ExeXml : IDisposable
    {
        // Public variables
        public string xmlPath;
        public bool tmleFound;

        // Xml Objects
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList xmlNodeList;

        /// <summary>
        /// Class constructor
        /// </summary>
        public ExeXml(string documentPath)
        {
            // Set the xmlPath public variable
            xmlPath = documentPath;
        }

        public void CheckExistence(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            if (File.Exists(xmlPath))
            {
                // Load the xml document
                xmlDoc.Load(xmlPath);

                // Create a node list from all Launch.Addon nodes
                xmlNodeList = xmlDoc.SelectNodes(@"//Launch.Addon");

                // Validate the document
                ValidateDocument(xmlName, xmlDisabled, xmlAppPath);
            }
            else
            {
                // Create a new document
                CreateNewDocument(xmlName, xmlDisabled, xmlAppPath);
            }
        }

        /// <summary>
        /// Checks the XML document for the LODRE's entry
        /// </summary>
        private void ValidateDocument(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            if (xmlNodeList.Count != 0)
            {
                foreach (XmlNode xmlNode in xmlNodeList)
                {
                    // Create objects to store the inner attribute of the xml node
                    object attribute = xmlNode.Attributes.GetNamedItem("Name");
                    string innerAttribute = xmlNode.ChildNodes.Item(0).InnerText.ToString();

                    if (innerAttribute == xmlName)
                    {
                        // Report that the LODRE was found
                        tmleFound = true;

                        // Break out of the loop
                        break;
                    }
                }

                if (!tmleFound)
                {
                    // Create a new entry for the LODRE
                    CreateTmleNodes(xmlName, xmlDisabled, xmlAppPath);
                }
                else
                {
                    // Update the child nodes
                    UpdateTmleChildren(xmlName, xmlDisabled, xmlAppPath);
                }
            }
            else
            {
                // Create a new entry for the LODRE
                CreateTmleNodes(xmlName, xmlDisabled, xmlAppPath);
            }
        }

        /// <summary>
        /// Creates the required nodes in exe.xml for the LODRE
        /// </summary>
        private void CreateTmleNodes(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            // Create a new document navigator
            XPathNavigator xPathNav = xmlDoc.CreateNavigator();

            xPathNav.MoveToChild("SimBase.Document", "");
            xPathNav.MoveToChild("Launch.ManualLoad", "");
            xPathNav.InsertAfter("<Launch.Addon></Launch.Addon>");
            xPathNav.MoveToNext();
            xPathNav.AppendChild("<Name>" + xmlName + "</Name>");
            xPathNav.AppendChild("<Disabled>" + xmlDisabled.ToString() + "</Disabled>");
            xPathNav.AppendChild("<ManualLoad>False</ManualLoad>");
            xPathNav.AppendChild("<Path>" + xmlAppPath + "</Path>");
            xPathNav.MoveToParent();
            xPathNav.MoveToRoot();

            using (StreamWriter streamWriter = new StreamWriter(xmlPath))
            {
                // Write the xml file changes to the original file
                streamWriter.Write(xPathNav.OuterXml);
            }
        }

        /// <summary>
        /// Updates the child nodes of the LODRE node in the xml document
        /// </summary>
        private void UpdateTmleChildren(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            // Inner Xml string
            string innerXmlName;

            // Create a new document navigator
            XPathNavigator xPathNav = xmlDoc.CreateNavigator();

            // Switch to the first node in the list
            xPathNav.MoveToChild("SimBase.Document", "");
            xPathNav.MoveToChild("Launch.Addon", "");
            xPathNav.MoveToChild("Name", "");

            // Set the innerXml string
            innerXmlName = xPathNav.InnerXml;

            while (innerXmlName != xmlName)
            {
                // Switch to the Name child node in the current node
                xPathNav.MoveToFollowing("Launch.Addon", "");
                xPathNav.MoveToChild("Name", "");

                // Set the innerXml string
                innerXmlName = xPathNav.InnerXml;
            }

            // Reset the child innerText
            xPathNav.MoveToParent();
            xPathNav.MoveToChild("Disabled", "");
            xPathNav.ReplaceSelf("<Disabled>" + xmlDisabled + "</Disabled>");
            xPathNav.MoveToParent();
            xPathNav.MoveToChild("Path", "");
            xPathNav.ReplaceSelf("<Path>" + xmlAppPath + "</Path>");
            xPathNav.MoveToParent();
            xPathNav.MoveToRoot();

            using (StreamWriter streamWriter = new StreamWriter(xmlPath))
            {
                // Write the xml file changes to the original file
                streamWriter.Write(xPathNav.OuterXml);
            }
        }

        /// <summary>
        /// Creates a new exe.xml file in the user's FSX configuration folder
        /// </summary>
        private void CreateNewDocument(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            // Copy the resource to the specified xml path
            File.Copy(Application.StartupPath + @"\Resources\exe.resource", xmlPath);

            // Load the xml document
            xmlDoc.Load(xmlPath);

            // Create a node list from all Launch.Addon nodes
            xmlNodeList = xmlDoc.SelectNodes(@"//Launch.Addon");

            // Create the TMLE nodes
            CreateTmleNodes(xmlName, xmlDisabled, xmlAppPath);
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
            // Null the xml objects ready for GC
            xmlDoc = null;
            xmlNodeList = null;
        }
    }
}