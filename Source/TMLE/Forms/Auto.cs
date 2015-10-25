using System;
using System.Windows.Forms;

namespace TextureMaxLoadEditor.Forms
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

        public int seconds;

        /// <summary>
        /// Constructor
        /// </summary>
        public Auto(int timerSeconds)
        {
            InitializeComponent();
            Icon = global::TextureMaxLoadEditor.Properties.Resources.icon;
            seconds = timerSeconds;
            autoBody.Text = autoBody.Text.Replace("[0]", (seconds + 1).ToString());
        }

        /// <summary>
        /// Stops the auto timer and closes the form
        /// </summary>
        private void autoCancel_Click(object sender, EventArgs e)
        {
            autoTimer.Stop();
            this.Close();
        }

        /// <summary>
        /// Counts down to the automatic shutdown of the Texture Max Load Editor
        /// </summary>
        private void autoTimer_Tick(object sender, EventArgs e)
        {
            if (seconds != 0)
            {
                autoBody.Text = "The Texture Max Load Editor will close in " + seconds + " seconds.";
                seconds--;
            }
            else
            {
                autoTimer.Stop();
                Application.Exit();
            }
        }
    }
}