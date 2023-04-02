using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWoggi.forms;

namespace MyWoggi
{
    public partial class About : Form
    {
        tables tables = new tables();
        Homepage homepage = new Homepage();
        ToolTip tooltip = new ToolTip();
        public About()
        {
            InitializeComponent();
            tooltip.SetToolTip(tables_button, "Таблицы");
            tooltip.SetToolTip(homepage_button, "На главный экран");
            tooltip.SetToolTip(logout_button, "Выйти из аккаунта");
        }
        // текст о для label_About_the_project
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
        
        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Переход в Home
        private void HomePage_Click(object sender, EventArgs e)
        {
            homepage.Show();
            this.Hide();
        }

        private void Logout_button(object sender, EventArgs e)
        {
            homepage.LogOut();
        }

        private void Tables_button(object sender, EventArgs e)
        {
            tables.Show();
            this.Hide();
        }
    }
}
