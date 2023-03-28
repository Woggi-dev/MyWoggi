using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyWoggi
{
    public partial class Registration : Form
    {
        Database MyWoggi = new Database();
        string name_placeholder = "Ваше имя";
        string surname_placeholder = "Ваша фамилия";
        string login_placeholder = "Ваш логин";
        string email_placeholder = "Ваша почта";
        string pwd_placeholder = "Ваш пароль";
        string pwdretry_placeholder = "Ваш пароль повторно";

        private void Set_Placeholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            else if (textBox.Text == "")
            {
                textBox.PasswordChar = '\0';
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // Когда форма загружена, login_placeholder назначается login_textbox и изменяется цвет
            Registration_Name_textbox.Text = name_placeholder;
            Registration_Surname_textbox.Text = surname_placeholder;
            Registration_Login_textbox.Text = login_placeholder;
            Registration_Email_textbox.Text = email_placeholder;
            Registration_Pwd_textbox.Text = pwd_placeholder;
            Registration_Pwdretry_textbox.Text = pwdretry_placeholder;

            Registration_Name_textbox.ForeColor = Color.Gray;
            Registration_Surname_textbox.ForeColor = Color.Gray;
            Registration_Login_textbox.ForeColor = Color.Gray;
            Registration_Email_textbox.ForeColor = Color.Gray;
            Registration_Pwd_textbox.ForeColor = Color.Gray;
            Registration_Pwdretry_textbox.ForeColor = Color.Gray;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Enter_Account_Button(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void Registration_Name_textbox_Enter(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Name_textbox, name_placeholder);

        }

        private void Registration_Name_textbox_Leave(object sender, EventArgs e)
        {
            // Когда пользователь переключается на другое текстовое поле, а pwd_textbox пустое, pwd_placeholder назначается pwd_textbox
            Set_Placeholder(Registration_Name_textbox, name_placeholder);


        }

        private void Registration_Surname_textbox_Enter(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Surname_textbox, surname_placeholder);

        }

        private void Registration_Surname_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Surname_textbox, surname_placeholder);

        }

        private void Registration_Login_textbox_Enter(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Login_textbox, login_placeholder);

        }

        private void Registration_Login_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Login_textbox, login_placeholder);

        }

        private void Registration_Email_textbox_Enter(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Email_textbox, email_placeholder);

        }

        private void Registration_Email_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Email_textbox, email_placeholder);
        }

        private void Registration_Pwd_textbox_Enter(object sender, EventArgs e)
        {
            if (Registration_Showpwd_picturebox.Visible == false)
                Registration_Pwd_textbox.PasswordChar = '•';
            Set_Placeholder(Registration_Pwd_textbox, pwd_placeholder);


        }

        private void Registration_Pwd_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Pwd_textbox, pwd_placeholder);
        }

        private void Registration_Pwdretry_textbox_Enter(object sender, EventArgs e)
        {
            if (Registration_Showpwdretry_picturebox.Visible == false)
                Registration_Pwdretry_textbox.PasswordChar = '•';
            Set_Placeholder(Registration_Pwdretry_textbox, pwdretry_placeholder);        
        }

        private void Registration_Pwdretry_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(Registration_Pwdretry_textbox, pwdretry_placeholder);

        }

        private void Authorization_Showpwd_picturebox_Click(object sender, EventArgs e)
        {
            Registration_Hidepwd_picturebox.Visible = true;
            Registration_Showpwd_picturebox.Visible = false;
            Registration_Pwd_textbox.PasswordChar = '•';
            if (Registration_Pwd_textbox.Text == pwd_placeholder)
                Registration_Pwd_textbox.PasswordChar = '\0';
        }

        private void Authorization_Hidepwd_picturebox_Click(object sender, EventArgs e)
        {
            Registration_Hidepwd_picturebox.Visible = false;
            Registration_Showpwd_picturebox.Visible = true;
            Registration_Pwd_textbox.PasswordChar = '\0';
            if (Registration_Pwd_textbox.Text == pwd_placeholder)
                Registration_Pwd_textbox.PasswordChar = '•';
        }

        private void Registration_Showpwdretry_picturebox_Click(object sender, EventArgs e)
        {
            Registration_Hidepwdretry_picturebox.Visible = true;
            Registration_Showpwdretry_picturebox.Visible = false;
            Registration_Pwdretry_textbox.PasswordChar = '•';
            if (Registration_Pwdretry_textbox.Text == pwdretry_placeholder)
                Registration_Pwdretry_textbox.PasswordChar = '\0';
        }

        private void Registration_Hidepwdretry_picturebox_Click(object sender, EventArgs e)
        {
            Registration_Hidepwdretry_picturebox.Visible = false;
            Registration_Showpwdretry_picturebox.Visible = true;
            Registration_Pwdretry_textbox.PasswordChar = '\0';
            if (Registration_Pwdretry_textbox.Text == pwdretry_placeholder)
                Registration_Pwdretry_textbox.PasswordChar = '•';
        }

        private void Registration_Register_button_Click(object sender, EventArgs e)
        {
            var newNameUser = Registration_Name_textbox.Text;
            var newSurnameUser = Registration_Surname_textbox.Text;
            var newLoginUser = Registration_Login_textbox.Text;
            var newEmailUser = Registration_Email_textbox.Text;
            var newPwdUser = Registration_Pwd_textbox.Text;
            
            string register_querystring = $"insert into Userdata(login_user, name_user, surname_user, email_user, password_user) VALUES('{newLoginUser}', '{newNameUser}', '{newSurnameUser}', '{newEmailUser}', '{newPwdUser}')";
            string checkuser_querystring = $"select id_user, login_user, password_user from Userdata where login_user = '{newLoginUser}' and password_user = '{newPwdUser}'";
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();


            MySqlCommand checkuser_command = new MySqlCommand(checkuser_querystring, MyWoggi.getConnection());
            adapter.SelectCommand = checkuser_command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return;
            }
            
            MySqlCommand register_command = new MySqlCommand(register_querystring, MyWoggi.getConnection());
            MyWoggi.openConnection();


            if (register_command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
            }
            else
            {
                MessageBox.Show("Аккаунт не создан", "Провал");
            }

            MyWoggi.closeConnection();
        }
    }
}
