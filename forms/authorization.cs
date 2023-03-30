﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWoggi.forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace MyWoggi
{
    public partial class Authorization : Form
    {
        Database MyWoggi = new Database();
        public Authorization()
        {
            InitializeComponent();
        }

        // Заполнители для текстовых полей
        string login_placeholder = "Ваш никнейм";
        string pwd_placeholder = "Ваш пароль";


        private void Set_Placeholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            else if (textBox.Text == "")
            {
                Authorization_Pwd_textbox.PasswordChar = '\0';
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            // Когда форма загружена, login_placeholder назначается login_textbox и изменяется цвет
            Authorization_Login_textbox.Text = login_placeholder;
            Authorization_Login_textbox.ForeColor = Color.Gray;

            // Когда форма загружена, pwd_placeholder назначается pwd_textbox и изменяется цвет
            Authorization_Pwd_textbox.Text = pwd_placeholder;
            Authorization_Pwd_textbox.ForeColor = Color.Gray;

        }
        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Когда пользователь нажимает X в какой-то форме, приложение закрывается
            Application.Exit();
        }

        private void Authorization_Login_textbox_Enter(object sender, EventArgs e)
        {
            // Когда пользователь наводит курсор на login_textbox, login_textbox очищается, и изменяется цвет
            Set_Placeholder(Authorization_Login_textbox, login_placeholder);
        }
        private void Authorization_Login_textbox_Leave(object sender, EventArgs e)
        {
            // Когда пользователь переключается на другое текстовое поле, а login_textbox пустое, login_placeholder назначается login_textbox
            Set_Placeholder(Authorization_Login_textbox, login_placeholder);

        }

        private void Authorization_Pwd_textbox_Enter(object sender, EventArgs e)
        {
            // Когда пользователь наводит курсор на pwd_textbox, pwd_textbox очищается, и изменяется цвет
            if (Authorization_Showpwd_picturebox.Visible == false)
                Authorization_Pwd_textbox.PasswordChar = '•';

            
            Set_Placeholder(Authorization_Pwd_textbox, pwd_placeholder);

        }

        private void Authorization_Pwd_textbox_Leave(object sender, EventArgs e)
        {
            // Когда пользователь переключается на другое текстовое поле, а pwd_textbox пустое, pwd_placeholder назначается pwd_textbox
            Set_Placeholder(Authorization_Pwd_textbox, pwd_placeholder);
        }

        private void ForgotPwd_Button_Click(object sender, EventArgs e)
        {
            // Переключение на форму forgotpwd_email
            UserEmail forgotpwd_email = new UserEmail();
            forgotpwd_email.Show();
            this.Hide();
        }

        private void Authorization_Showpwd_picturebox_Click(object sender, EventArgs e)
        {
            Authorization_Hidepwd_picturebox.Visible = true;
            Authorization_Showpwd_picturebox.Visible = false;
            Authorization_Pwd_textbox.PasswordChar = '•';
            if (Authorization_Pwd_textbox.Text == pwd_placeholder)
                Authorization_Pwd_textbox.PasswordChar = '\0';
        }

        private void Authorization_Hidepwd_picturebox_Click(object sender, EventArgs e)
        {
            Authorization_Hidepwd_picturebox.Visible = false;
            Authorization_Showpwd_picturebox.Visible = true;
            Authorization_Pwd_textbox.PasswordChar = '\0';
            if (Authorization_Pwd_textbox.Text == pwd_placeholder)
                Authorization_Pwd_textbox.PasswordChar = '•';


        }

        private void Authorization_Login_button_Click(object sender, EventArgs e)
        {
            var loginUser = Authorization_Login_textbox;
            var pwdUser = Authorization_Pwd_textbox;

            bool isSuchUser = MyWoggi.isSuchUser(Authorization_Login_textbox, Authorization_Pwd_textbox);

            if (isSuchUser)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                Authorization_Login_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
                Authorization_Pwd_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
                loginpasswordError_label.Visible = true;
                loginpasswordError_label.Text = "Неверно введен логин или пароль";
            }



        }

        private void Authorization_Register_button_Click(object sender, EventArgs e)
        {
            // Переключение на форму регистрации
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

    }
}
