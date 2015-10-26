using System;
using System.Windows.Forms;

namespace LODRadiusEditor.OptionsRadiiList
{
    class Update : IDisposable
    {
        /// <summary>
        /// Refreshes the list box items for the radii tab
        /// </summary>
        /// <param name="removeSelected">Removes the selected item</param>
        public void RefreshForm(ListBox listBox, bool removeSelected)
        {
            if (removeSelected)
            {
                object o = listBox.SelectedItem.ToString();

                // Remove the current selected item
                listBox.Items.Remove(o);

                // Remove the auto change item
                listBox.Items.Remove(o);
            }

            // Clear the selected items
            listBox.ClearSelected();
        }

        /// <summary>
        /// Disposes of the class
        /// </summary>
        void IDisposable.Dispose()
        {
        }
    }
}