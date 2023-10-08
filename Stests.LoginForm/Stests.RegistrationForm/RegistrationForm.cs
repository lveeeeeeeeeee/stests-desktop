using System.Text.RegularExpressions;

namespace Stests.RegistrationForm
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks if the input of required property is correct.
        /// </summary>
        /// <param name="line">Given input.</param>
        /// <returns>Validity of given input as boolean value (true if valid).</returns>
        private bool CredentialsCorrect(string line)
        {
            Regex regex = new Regex("[A-Za-zА-Яа-я]*$");
            return regex.IsMatch(line);
        }

        /// <summary>
        /// Validated event handler for name box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameBox_Validated(object sender, EventArgs e)
        {
            {
                // If all conditions have been met, clear the ErrorProvider of errors.
                errorProvider.SetError(nameBox, "");

                // Enable proceeding with the registration process.
                registrationButton.Enabled = true;
            }
        }

        /// <summary>
        /// Validating event handler for name box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!CredentialsCorrect(nameBox.Text))
            {
                errorMsg = "Данные введены неверно. Разрешены только символы кириллицы / латиницы.";

                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                nameBox.Select(0, nameBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(nameBox, errorMsg);

                // Disable proceeding with the registration process.
                registrationButton.Enabled = false;
            }
            if (nameBox.Text.Length == 0)
            {
                errorMsg = "Поле обязательно для заполнения.";

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(nameBox, errorMsg);

                // Disable proceeding with the registration process.
                registrationButton.Enabled = false;
            }
        }

        /// <summary>
        /// Validating event handler for surname box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surnameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!CredentialsCorrect(surnameBox.Text))
            {
                errorMsg = "Данные введены неверно. Разрешены только символы кириллицы / латиницы.";

                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                surnameBox.Select(0, surnameBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(surnameBox, errorMsg);

                // Disable proceeding with the registration process.
                registrationButton.Enabled = false;
            }
            if (surnameBox.Text.Length == 0)
            {
                errorMsg = "Поле обязательно для заполнения.";

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(surnameBox, errorMsg);

                // Disable proceeding with the registration process.
                registrationButton.Enabled = false;
            }
        }

        /// <summary>
        /// Validated event handler for surname box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surnameBox_Validated(object sender, EventArgs e)
        {
            {
                // If all conditions have been met, clear the ErrorProvider of errors.
                errorProvider.SetError(surnameBox, "");

                // Enable proceeding with the registration process.
                registrationButton.Enabled = true;
            }
        }


        /// <summary>
        /// Validation event handler for patronymic box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patronymicBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider.SetError(patronymicBox, "");

            // Enable proceeding with the registration process.
            registrationButton.Enabled = true;
        }

        /// <summary>
        /// Validating event handler for partronymic box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patronymicBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!CredentialsCorrect(patronymicBox.Text))
            {
                errorMsg = "Данные введены неверно. Разрешены только символы кириллицы / латиницы.";

                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                patronymicBox.Select(0, patronymicBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(patronymicBox, errorMsg);

                // Disable proceeding with the registration process.
                registrationButton.Enabled = false;
            }
        }
    }
}