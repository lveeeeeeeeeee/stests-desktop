using System.Text.RegularExpressions;

namespace Stests.ManageStudyGroup
{
    public partial class ManageStudyGroup : Form
    {
        public ManageStudyGroup()
        {
            InitializeComponent();
        }

        private void groupPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupNameLabel_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Enable password copy from password box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                Clipboard.SetText(passwordBox.Text);
            }
        }

        /// <summary>
        /// Check if group name is correct format.
        /// </summary>
        /// <param name="line">Group name.</param>
        /// <returns>Whether group name is correct.</returns>
        private bool GroupNameCorrect(string line)
        {
            Regex regex = new Regex(@"[А-Яа-яA-Za-z0-9]+$");
            return regex.IsMatch(line);
        }

        /// <summary>
        /// Event handler for name box when text is put in it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!GroupNameCorrect(nameBox.Text))
            {
                string errorMsg = "Название группы может только содержать символы кириллицы, латиницы или цифры.";

                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                nameBox.Select(0, nameBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(nameBox, errorMsg);

                // Disable the login button
                changeGroupNameButton.Enabled = false;
            }
        }

        /// <summary>
        /// Correct input event handler for name box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider.SetError(nameBox, "");

            // Enable the login button.
            changeGroupNameButton.Enabled = true;
        }
    }
}