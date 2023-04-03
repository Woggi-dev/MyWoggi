﻿using System;
using System.Windows.Forms;

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
                Application.Run(new visitor_table());
            }
            else
            {
                // Показать форму авторизации
                Application.Run(new Authorization());
            }
        }
    }
}
