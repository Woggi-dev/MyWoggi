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
    public partial class About_the_project : Form
    {
        public About_the_project()
        {
            InitializeComponent();
        }
        // текст о для label_About_the_project
        private void About_the_project_Load(object sender, EventArgs e)
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
        
        private void About_the_project_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Переход в Home
        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
