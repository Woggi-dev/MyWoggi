using System;
using System.Windows.Forms;

namespace MyWoggi.forms
{
    public partial class Homepage : Form
    {
        // Экземпляры классов форм
        Authorization authorization = new Authorization();
        Database MyWoggi = new Database();
        tables tables = new tables();
        ToolTip tooltip = new ToolTip();
        // Токен входа в аккаунт
        private string authToken;
        
        public Homepage()
        {
            InitializeComponent();
            // Подсказки для кнопок
            tooltip.SetToolTip(tables_button, "Таблицы");
            tooltip.SetToolTip(about_button, "О проекте");
            tooltip.SetToolTip(logout_button, "Выйти из аккаунта");

        }

        // Когда пользователь нажимает X, приложение закрывается
        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        // Функция выхода из аккаунта
        public void LogOut()
        {
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

        // Переход на форму таблиц
        private void TablesShow_button(object sender, EventArgs e)
        {
            tables.Show();
            this.Hide();
        }

        // Переход на форму о проекте
        private void About_button(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Переход на форму таблиц
        private void LogOut_button(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
