using System;
using System.Windows.Forms;

namespace LODRadiusEditor
{
    public partial class About : Form
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

        /// <summary>
        /// Initializes the form
        /// </summary>
        public About()
        {
            // Initialize the component
            InitializeComponent();

            // Assign the icon
            Icon = global::LODRadiusEditor.Properties.Resources.icon;

            // Read the license agreement
            aboutLicense.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\Resources\license.resource");
        }

        /// <summary>
        /// Closes the about window and returns to the parent
        /// </summary>
        private void aboutOkButton_Click(object sender, EventArgs e)
        {
            // Remove the license from memory
            aboutLicense.Text = null;

            // Close the form
            this.Close();
        }

        /// <summary>
        /// Switch for the license/credits content
        /// </summary>
        private void aboutLicenseButton_Click(object sender, EventArgs e)
        {
            switch (aboutLicenseButton.Text)
            {
                case "Credits":
                    aboutLicenseButton.Text = "License";
                    aboutLicense.Visible = false;
                    break;
                case "License":
                    aboutLicenseButton.Text = "Credits";
                    aboutLicense.Visible = true;
                    break;
            }
        }
    }
}