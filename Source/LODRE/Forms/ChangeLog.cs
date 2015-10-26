using System.IO;
using System.Windows.Forms;

namespace LODRadiusEditor
{
    public partial class ChangeLog : Form
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        public ChangeLog(string text)
        {
            // Initialize the form
            InitializeComponent();

            // Assign the icon
            Icon = global::LODRadiusEditor.Properties.Resources.icon;

            // Set the title text
            this.Text = this.Text.Replace("[0]", text);

            // Display the file contents to the console
            changeLogText.Text = File.ReadAllText(Application.StartupPath + @"\Logs\Versions\" + text.Replace('.', '_') + ".log");
        }
    }
}