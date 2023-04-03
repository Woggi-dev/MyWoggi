using System;
using System.Windows.Forms;

namespace MyWoggi
{
    public partial class Homepage : Form
    {
        // Экземпляры классов форм
        Database MyWoggi = new Database();
        ToolTip tooltip = new ToolTip();
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

        // Переход на форму таблиц
        private void TablesShow_button(object sender, EventArgs e)
        {
            tables tables = new tables();
            tables.Show();
            this.Hide();
        }

        // Переход на форму таблиц
        private void LogOut_button(object sender, EventArgs e)
        {
            LogOut();
        }

        private void About_Button(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }
    }
}
