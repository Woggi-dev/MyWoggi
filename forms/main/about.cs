using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWoggi
{
    public partial class About : Form
    {
        private string authToken;
        Database MyWoggi = new Database();
        public About()
        {
            InitializeComponent();
        }

        private void LogOut()
        {
            Authorization authorization = new Authorization();
            // Получить токен авторизации
            authToken = authorization.ReadAuthToken();
            // Отключить функцию "запомнить меня"
            string rememberMeDisabledQueryString = $"update Userdata set rememberme_user = '0' where authtoken_user = '{authToken}'";
            bool isRememberDisabled = MyWoggi.InsertUpdateData(rememberMeDisabledQueryString);
            // Если отключено успешно
            if (isRememberDisabled)
            {
                authorization.Show();
                this.Hide();
            }
            // Если нет
            else
            {
                MessageBox.Show("Произошла ошибка выхода из аккаунта...", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void about_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tables_button_Click(object sender, EventArgs e)
        {
            AnimalTable tables = new AnimalTable();
            tables.Show();
            this.Hide();

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void about_Load(object sender, EventArgs e)
        {
            about_label.Text = "Название проекта: MyWoggi" +
    "\n\nОписание: Наш проект представляет собой приложения на С# , позволяющее " +
    "\nсобирать и накапливать сведения о посетителях и" +
    "\nобитателях экзотариума в городе Москве" +
    "\n\nДата начала и окончания: март 2023 - апрель 2023" +
    "\nКоманда проекта: Садыгов Васиф - frontend - разработчик;" +
    "\nНиколай Шапилов - backend - разработчик" +
    "\n\nИспользованные технологии: Git, Chat.openai, MySQL" +
    "\n\nКонтактная информация: sadygov.vasif@inbox.ru" +
    "\n\nЛоготип: Лось" +
    "\n\nСоциальные сети: tg: @obl_lak; vk: https://vk.com/kolyashap" +
    "\n\nХотим поблагодарить Николая Александровича за помощь в проекте";
        }
    }
}
