using System;
using System.Windows.Forms;

namespace StudentRentalAndMushroomApp
{
    public partial class BicycleRentalForm : Form
    {
        private readonly MainMenuForm _mainMenuForm;
        private readonly LoginForm _loginForm;
        private bool _isNavigating = false;

        public BicycleRentalForm(MainMenuForm mainMenuForm, LoginForm loginForm)
        {
            _mainMenuForm = mainMenuForm;
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate inputs according to all assignment requirements
                if (!ValidateInputs(out int startHour, out int endHour))
                {
                    return;
                }

                // 2. Clear previous calculation breakdown
                lstBreakdown.Items.Clear();

                // 3. Compute cost using loops and decision control statements
                int totalCost = 0;
                int duration = endHour - startHour;

                for (int hour = startHour; hour < endHour; hour++)
                {
                    int hourlyRate;
                    string rateDescription;

                    // Decision control statements for rate periods
                    if (hour >= 0 && hour < 7)
                    {
                        hourlyRate = 500;
                        rateDescription = "Early Morning Rate";
                    }
                    else if (hour >= 7 && hour < 14)
                    {
                        hourlyRate = 1000;
                        rateDescription = "Morning / Midday Rate";
                    }
                    else if (hour >= 14 && hour < 19)
                    {
                        hourlyRate = 1500;
                        rateDescription = "Afternoon Peak Rate";
                    }
                    else if (hour >= 19 && hour < 21)
                    {
                        hourlyRate = 1000;
                        rateDescription = "Evening Rate";
                    }
                    else // hour >= 21 && hour < 24
                    {
                        hourlyRate = 500;
                        rateDescription = "Night Rate";
                    }

                    totalCost += hourlyRate;

                    // Format hour string nicely, e.g., 06:00 -> 07:00
                    string timeSlot = $"{hour:D2}:00 - {(hour + 1):D2}:00";
                    lstBreakdown.Items.Add($"{timeSlot} : {hourlyRate,5:N0} RWF ({rateDescription})");
                }

                // 4. Display results
                lblDuration.Text = $"Duration: {duration} hour(s) [From {startHour:D2}:00 to {endHour:D2}:00]";
                lblTotalCost.Text = $"{totalCost:N0} RWF";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred during calculation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validates that starting and ending hours satisfy all assignment constraints.
        /// </summary>
        private bool ValidateInputs(out int startHour, out int endHour)
        {
            startHour = 0;
            endHour = 0;

            string startText = txtStartHour.Text.Trim();
            string endText = txtEndHour.Text.Trim();

            // Requirement 1: Check for empty input
            if (string.IsNullOrWhiteSpace(startText))
            {
                MessageBox.Show("Please enter the starting hour.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartHour.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(endText))
            {
                MessageBox.Show("Please enter the ending hour.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndHour.Focus();
                return false;
            }

            // Requirement 2: Both inputs must be integers
            if (!int.TryParse(startText, out startHour))
            {
                MessageBox.Show("The starting hour must be a valid integer whole number.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartHour.SelectAll();
                txtStartHour.Focus();
                return false;
            }

            if (!int.TryParse(endText, out endHour))
            {
                MessageBox.Show("The ending hour must be a valid integer whole number.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndHour.SelectAll();
                txtEndHour.Focus();
                return false;
            }

            // Requirement 3: Starting hour must be between 0 and 23
            if (startHour < 0 || startHour > 23)
            {
                MessageBox.Show("The starting hour must be between 0 (midnight) and 23 (11 PM).", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartHour.SelectAll();
                txtStartHour.Focus();
                return false;
            }

            // Requirement 4: Ending hour must be between 1 and 24
            if (endHour < 1 || endHour > 24)
            {
                MessageBox.Show("The ending hour must be between 1 (1 AM) and 24 (midnight next day).", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndHour.SelectAll();
                txtEndHour.Focus();
                return false;
            }

            // Requirement 5: Starting hour must be strictly less than ending hour
            if (startHour >= endHour)
            {
                MessageBox.Show("The starting hour must be strictly less than the ending hour. A rental cannot span more than one day.", "Invalid Rental Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartHour.SelectAll();
                txtStartHour.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStartHour.Clear();
            txtEndHour.Clear();
            lblTotalCost.Text = "0 RWF";
            lblDuration.Text = "Duration: 0 hour(s)";
            lstBreakdown.Items.Clear();
            txtStartHour.Focus();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            this.Close();
            _mainMenuForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            this.Close();
            _mainMenuForm.LogoutToLogin();
        }

        private void BicycleRentalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing)
            {
                _mainMenuForm.Show();
            }
        }
    }
}

