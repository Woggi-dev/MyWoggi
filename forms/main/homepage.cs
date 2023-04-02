using System;
using System.Windows.Forms;

namespace MyWoggi.forms
{
    public partial class Homepage : Form
    {
        Authorization authorization = new Authorization();
        Database MyWoggi = new Database();
        tables tables = new tables();
        About about = new About();
        ToolTip tooltip = new ToolTip();
        private string authToken;
        
        public Homepage()
        {
            InitializeComponent();
            tooltip.SetToolTip(tables_button, "Таблицы");
            tooltip.SetToolTip(about_button, "О проекте");
            tooltip.SetToolTip(logout_button, "Выйти из аккаунта");


        }
        //переход на форму Table
        private void ShowTables_button(object sender, EventArgs e)
        {
            tables.Show();
            this.Hide();
        }

        public void LogOut()
        {
            authToken = authorization.ReadAuthToken();
            string rememberMeDisabledQueryString = $"update Userdata set rememberme_user = '0' where authtoken_user = '{authToken}'";
            bool isRememberDisabled = MyWoggi.InsertUpdateData(rememberMeDisabledQueryString);
            if (isRememberDisabled)
            {
                authorization.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Произошла ошибка выхода из аккаунта...", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_button(object sender, EventArgs e)
        {
            LogOut();
        }

        private void TablesShow_button(object sender, EventArgs e)
        {
            tables.Show();
            this.Hide();
        }

        private void About_button(object sender, EventArgs e)
        {
            about.Show();
            this.Hide();
        }
    }
}
