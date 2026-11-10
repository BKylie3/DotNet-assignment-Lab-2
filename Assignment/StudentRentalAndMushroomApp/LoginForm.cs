using System;
using System.Windows.Forms;

namespace StudentRentalAndMushroomApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 1. Basic input validation: ensure fields are not empty
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // 2. Authentication: username and password123
            bool isValidUser = (string.Equals(username, "username", StringComparison.OrdinalIgnoreCase) ||
                                string.Equals(username, "student", StringComparison.OrdinalIgnoreCase)) &&
                               password == "password123";

            if (isValidUser)
            {
                MessageBox.Show("Welcome! Login successful.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the main selection form
                MainMenuForm mainForm = new MainMenuForm(this, username);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please enter username: 'username' and password: 'password123'.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        /// <summary>
        /// Called when logging out from other forms to cleanly reset and display the login screen.
        /// </summary>
        public void ResetLoginForm()
        {
            txtPassword.Clear();
            this.Show();
            txtUsername.Focus();
        }
    }
}