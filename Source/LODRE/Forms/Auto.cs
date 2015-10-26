using System;
using System.Windows.Forms;

namespace LODRadiusEditor
{
    public partial class Auto : Form
    {
        #region Draw Override

        /// <summary>
        /// Overrides the form draw params to allow smoother, flicker-free loading
        /// </summary>
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

        // Public variables
        public int seconds;

        /// <summary>
        /// Class constructor
        /// </summary>
        public Auto(int timerSeconds)
        {
            // Initialize the form
            InitializeComponent();

            // Assign the icon
            Icon = global::LODRadiusEditor.Properties.Resources.icon;

            // Set the timer seconds
            seconds = timerSeconds;

            // Update the timer text
            autoBody.Text = autoBody.Text.Replace("[0]", (seconds + 1).ToString());
        }

        /// <summary>
        /// Stops the auto timer and closes the form
        /// </summary>
        private void autoCancel_Click(object sender, EventArgs e)
        {
            // Stop the close timer
            autoTimer.Stop();

            // Close the form
            this.Close();
        }

        /// <summary>
        /// Counts down to the automatic shutdown of the LODRE
        /// </summary>
        private void autoTimer_Tick(object sender, EventArgs e)
        {
            if (seconds != 0)
            {
                // Update the body text
                autoBody.Text = "The Level of Detail Radius Editor will close in " + seconds + " seconds.";

                // Decrease the time
                seconds--;
            }
            else
            {
                // Stop the timer
                autoTimer.Stop();

                // Close the application
                Application.Exit();
            }
        }
    }
}