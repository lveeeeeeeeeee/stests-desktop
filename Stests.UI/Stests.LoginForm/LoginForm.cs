using System.Text.RegularExpressions;
using Stests.LoginLogic;

namespace Stests.LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Check if given input is correct login.
        /// </summary>
        /// <param name="line">Given input.</param>
        /// <returns>Boolean value whether the input is correct login.</returns>
        private bool LoginIsCorrect(string line)
        {
            Regex regex = new Regex(@"[A-Za-z0-9]+$");
            return regex.IsMatch(line);
        }

        /// <summary>
        /// Validating event handler for login box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!LoginIsCorrect(loginBox.Text))
            {
                string errorMsg = "Неверный логин.";

                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                loginBox.Select(0, loginBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(loginBox, errorMsg);

                // Disable the login button
                loginButton.Enabled = false;
            }
        }

        /// <summary>
        /// Validated event handler for login box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBox_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider.SetError(loginBox, "");

            // Enable the login button.
            loginButton.Enabled = true;
        }
    }
}