using System;
using System.Windows.Forms;

namespace TextureMaxLoadEditor.Forms
{
    public partial class Apply : Form
    {
        #region Draw Override

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
        /// Constructor
        /// </summary>
        public Apply(string resolution)
        {
            InitializeComponent();
            Icon = global::TextureMaxLoadEditor.Properties.Resources.icon;
            resolutionLabel.Text = resolution;
        }

        /// <summary>
        /// Stops the timer and closes the form
        /// </summary>
        private void titleLabel_Click(object sender, EventArgs e)
        {
            timerFade.Stop();
            this.Close();
        }

        /// <summary>
        /// Disposes of the form after the timer ends
        /// </summary>
        private void timerFade_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}