using System;
using System.Windows.Forms;

namespace StudentRentalAndMushroomApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure application settings such as DPI awareness and default styles
            ApplicationConfiguration.Initialize();

            // Run the initial login form
            Application.Run(new LoginForm());
        }
    }
}
