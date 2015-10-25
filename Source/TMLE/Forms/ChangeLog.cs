using System.IO;
using System.Windows.Forms;

namespace TextureMaxLoadEditor.Forms
{
    public partial class ChangeLog : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ChangeLog(string text)
        {
            InitializeComponent();
            Icon = global::TextureMaxLoadEditor.Properties.Resources.icon;
            this.Text = this.Text.Replace("[0]", text);
            changeLogText.Text = File.ReadAllText(Application.StartupPath + @"\Logs\Versions\" + text.Replace('.', '_') + ".log");
        }
    }
}