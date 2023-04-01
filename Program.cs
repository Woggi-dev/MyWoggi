using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWoggi.forms;

namespace MyWoggi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Authorization authorization = new Authorization();

            // Check if the user is already authorized
            if (authorization.isUserRemembered())
            {
                // Close the Authorization form
                authorization.Close();

                // Create and show the Main form
                Application.Run(new Main());
            }
            else
            {
                // Show the Authorization form
                Application.Run(authorization);
            }
            Application.Run(new Authorization());
        }
    }
}
