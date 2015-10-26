using System;
using System.Windows.Forms;

namespace LODRadiusEditor
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
        /// Class Constructor
        /// </summary>
        public Apply(string radius)
        {
            // Initialize the form
            InitializeComponent();

            // Assign the icon
            Icon = global::LODRadiusEditor.Properties.Resources.icon;

            // Set the radius label
            radiusLabel.Text = radius;
        }

        /// <summary>
        /// Stops the timer and closes the form
        /// </summary>
        private void titleLabel_Click(object sender, EventArgs e)
        {
            // Stop the close timer
            timerFade.Stop();

            // Close the form
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