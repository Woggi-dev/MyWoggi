using System;
using System.Windows.Forms;
using MyWoggi.forms;

namespace MyWoggi
{
    public partial class About : Form
    {
        tables tables = new tables();
        ToolTip tooltip = new ToolTip();
        public About()
        {
            InitializeComponent();
            tooltip.SetToolTip(tables_button, "Таблицы");
            tooltip.SetToolTip(homepage_button, "На главный экран");
            tooltip.SetToolTip(logout_button, "Выйти из аккаунта");
        }
        // Обработчик события загрузки формы
        private void About_Load(object sender, EventArgs e)
        {
            label_About_the_project.Text = "Название проекта: MyWoggi" +
                "\nОписание: Наш проект представляет собой приложения на С# , позволяющее " +
                "\nсобирать и накапливать сведения о посетителях и" +
                "\nобитателях экзотариума в городе Москве" +
                "\nДата начала и окончания: март 2023 - апрель 2023" +
                "\nКоманда проекта: Садыгов Васиф - frontend - разработчик;" +
                "\nНиколай Шапилов - backend - разработчик" +
                "\nИспользованные технологии: Git, Chat.openai, MySQL" +
                "\nКонтактная информация: sadygov.vasif@inbox.ru" +
                "\nЛоготип: Лось" +
                "\nСоциальные сети: tg: @obl_lak; vk: https://vk.com/kolyashap" +
                "\nХотим поблагодарить Николая Александровича за помощь в проекте";
        }

        // Когда пользователь нажимает X, приложение закрывается
        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Перейти на главный экран
        private void HomePage_button(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();

            homepage.Show();
            this.Hide();
        }
        // Выход из аккаунта
        private void Logout_button(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();

            homepage.LogOut();
        }

        // Перейти к таблицам
        private void Tables_button(object sender, EventArgs e)
        {
            tables.Show();
            this.Hide();
        }
    }
}
