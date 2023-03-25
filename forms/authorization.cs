﻿using System;
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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        // Заполнители для текстовых полей
        string login_placeholder = "Ваш никнейм";
        string pwd_placeholder = "Ваш пароль";

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
            if (Authorization_Login_textbox.Text == login_placeholder)
            {
                Authorization_Login_textbox.Text = "";
                Authorization_Login_textbox.ForeColor = Color.Black;

            }
        }
        private void Authorization_Login_textbox_Leave(object sender, EventArgs e)
        {
            // Когда пользователь переключается на другое текстовое поле, а login_textbox пустое, login_placeholder назначается login_textbox
            if (Authorization_Login_textbox.Text == "")
            {
                Authorization_Login_textbox.Text = login_placeholder;
                Authorization_Login_textbox.ForeColor = Color.Gray;
            }
        }

        private void Authorization_Pwd_textbox_Enter(object sender, EventArgs e)
        {
            // Когда пользователь наводит курсор на pwd_textbox, pwd_textbox очищается, и изменяется цвет
            if (Authorization_Pwd_textbox.Text == pwd_placeholder)
            {
                Authorization_Pwd_textbox.Text = "";
                Authorization_Pwd_textbox.ForeColor = Color.Black;
            }
        }

        private void Authorization_Pwd_textbox_Leave(object sender, EventArgs e)
        {
            // Когда пользователь переключается на другое текстовое поле, а pwd_textbox пустое, pwd_placeholder назначается pwd_textbox
            if (Authorization_Pwd_textbox.Text == "")
            {
                Authorization_Pwd_textbox.Text = pwd_placeholder;
                Authorization_Pwd_textbox.ForeColor = Color.Gray;
            }
        }

        private void ForgotPwd_Button_Click(object sender, EventArgs e)
        {
            // Переключение на форму forgotpwd_email
            UserEmail forgotpwd_email = new UserEmail();
            forgotpwd_email.Show();
            this.Hide();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            // Переключение на форму регистрации
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

    }
}
