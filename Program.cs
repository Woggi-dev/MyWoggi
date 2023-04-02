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

            // Проверить если пользователь уже авторизован
            if (authorization.isUserRemembered())
            {
                // Закрыть форму авторизации
                authorization.Close();

                // Создать и показать основную форму
                Application.Run(new Homepage());
            }
            else
            {
                // Показать форму авторизации
                Application.Run(new Authorization());
            }
        }
    }
}
