using System;
using System.Windows.Forms;

namespace StudentRentalAndMushroomApp
{
    public partial class MainMenuForm : Form
    {
        private readonly LoginForm _loginForm;
        private readonly string _username;
        private bool _isNavigatingOrLoggingOut = false;

        public MainMenuForm(LoginForm loginForm, string username)
        {
            _loginForm = loginForm;
            _username = username;
            InitializeComponent();
            lblUserStatus.Text = $"Logged in as: {_username}";
        }

        private void btnOpenBicycle_Click(object sender, EventArgs e)
        {
            OpenBicycleRentalModule();
        }

        private void btnOpenMushroom_Click(object sender, EventArgs e)
        {
            OpenMushroomIdentificationModule();
        }

        private void OpenBicycleRentalModule()
        {
            _isNavigatingOrLoggingOut = true;
            BicycleRentalForm rentalForm = new BicycleRentalForm(this, _loginForm);
            rentalForm.Show();
            this.Hide();
            _isNavigatingOrLoggingOut = false;
        }

        private void OpenMushroomIdentificationModule()
        {
            _isNavigatingOrLoggingOut = true;
            MushroomIdForm mushroomForm = new MushroomIdForm(this, _loginForm);
            mushroomForm.Show();
            this.Hide();
            _isNavigatingOrLoggingOut = false;
        }

        /// <summary>
        /// Logs out the user and returns directly to the login screen.
        /// </summary>
        public void LogoutToLogin()
        {
            _isNavigatingOrLoggingOut = true;
            this.Close();
            _loginForm.ResetLoginForm();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigatingOrLoggingOut && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}