using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace TextureMaxLoadEditor
{
    class ExeXML : IDisposable
    {
        public string xmlPath;
        public bool tmleFound;
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList xmlNodeList;

        /// <summary>
        /// Class constructor
        /// </summary>
        public ExeXML(string documentPath)
        {
            xmlPath = documentPath;
        }

        public void CheckExistence(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            if (File.Exists(xmlPath))
            {
                xmlDoc.Load(xmlPath);
                xmlNodeList = xmlDoc.SelectNodes(@"//Launch.Addon");
                ValidateDocument(xmlName, xmlDisabled, xmlAppPath);
            }
            else
            {
                CreateNewDocument(xmlName, xmlDisabled, xmlAppPath);
            }
        }

        /// <summary>
        /// Checks the XML document for the Texture Max Load's entry
        /// </summary>
        private void ValidateDocument(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            if (xmlNodeList.Count != 0)
            {
                foreach (XmlNode xmlNode in xmlNodeList)
                {
                    object attribute = xmlNode.Attributes.GetNamedItem("Name");
                    string innerAttribute = xmlNode.ChildNodes.Item(0).InnerText.ToString();

                    if (innerAttribute == xmlName)
                    {
                        tmleFound = true;
                        break;
                    }
                }

                if (!tmleFound)
                {
                    CreateTmleNodes(xmlName, xmlDisabled, xmlAppPath);
                }
                else
                {
                    UpdateTmleChildren(xmlName, xmlDisabled, xmlAppPath);
                }
            }
            else
            {
                CreateTmleNodes(xmlName, xmlDisabled, xmlAppPath);
            }
        }

        /// <summary>
        /// Creates the required nodes in exe.xml for the Texture Max Load Editor
        /// </summary>
        private void CreateTmleNodes(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
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
                streamWriter.Write(xPathNav.OuterXml);
            }
        }

        /// <summary>
        /// Updates the child nodes of the Texture Max Load Editor node in the xml document
        /// </summary>
        private void UpdateTmleChildren(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            string innerXmlName;

            XPathNavigator xPathNav = xmlDoc.CreateNavigator();
            xPathNav.MoveToChild("SimBase.Document", "");
            xPathNav.MoveToChild("Launch.Addon", "");
            xPathNav.MoveToChild("Name", "");
            innerXmlName = xPathNav.InnerXml;

            while (innerXmlName != xmlName)
            {
                xPathNav.MoveToFollowing("Launch.Addon", "");
                xPathNav.MoveToChild("Name", "");

                innerXmlName = xPathNav.InnerXml;
            }

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
                streamWriter.Write(xPathNav.OuterXml);
            }
        }

        /// <summary>
        /// Creates a new exe.xml file in the user's FSX configuration folder
        /// </summary>
        private void CreateNewDocument(string xmlName, bool xmlDisabled, string xmlAppPath)
        {
            File.Copy(Application.StartupPath + @"\Resources\exe.resource", xmlPath);
            xmlDoc.Load(xmlPath);
            xmlNodeList = xmlDoc.SelectNodes(@"//Launch.Addon");
            CreateTmleNodes(xmlName, xmlDisabled, xmlAppPath);
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
            xmlDoc = null;
            xmlNodeList = null;
        }
    }
}