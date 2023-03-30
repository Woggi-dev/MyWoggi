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
using System.Text.RegularExpressions;

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

        private bool Validate_TextBox(TextBox textBox, string fieldName, Label errorLabel, List<TextBox> invalidTextBoxes, string placeHolder)
        {
            bool isValid = true;
            // Check if the textbox is empty or whitespace
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == placeHolder)
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Поле пустое";

            }
            else if (textBox.Text.Contains(" "))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Поле содержит пробелы";
            }

            else if ((fieldName == "Name" || fieldName == "Surname") && Regex.IsMatch(textBox.Text, @"\d"))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                if (fieldName == "Name")
                    errorLabel.Text = "Имя содержит цифры";
                else
                    errorLabel.Text = "Фамилия содержит цифры";
            }
            // Check for special characters in name and surname
            else if ((fieldName == "Name" || fieldName == "Surname") && !Regex.IsMatch(textBox.Text, "^[a-zA-Zа-яА-Я]+$"))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                if (fieldName == "Name")
                    errorLabel.Text = "Имя содержит спец символы";
                else
                    errorLabel.Text = "Фамилия содержит спец символы";
            }

            // Check for special characters in login
            else if (fieldName == "Login" && !Regex.IsMatch(textBox.Text, "^[a-zA-Z0-9_]+$"))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Логин содержит спец символы";
            }

            else if (fieldName == "Login" && textBox.Text.Length < 3)
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Логин содержит меньше 3 символов";
            }

            // Check for valid email format
            else if (fieldName == "Email" && !Regex.IsMatch(textBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && (!textBox.Text.EndsWith("@gmail.com") && !textBox.Text.EndsWith("@mail.ru") && !textBox.Text.EndsWith("@inbox.ru") && !textBox.Text.EndsWith("@yandex.ru")))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Неверно введена почта";
            }

            else if (fieldName == "Pwd" && textBox.Text != Registration_Pwdretry_textbox.Text)
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                invalidTextBoxes.Add(Registration_Pwdretry_textbox);
                errorLabel.Visible = true;
                errorLabel.Text = "Пароли не совпадают";
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
                errorLabel.Visible = false;
                pwdretryError_label.Visible = false;

            }

            return isValid;
        }
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
            List<TextBox> invalidTextBoxes = new List<TextBox>();
            var newNameUser = Registration_Name_textbox;
            var newSurnameUser = Registration_Surname_textbox;
            var newLoginUser = Registration_Login_textbox;
            var newEmailUser = Registration_Email_textbox;
            var newPwdUser = Registration_Pwd_textbox;
            var newPwdRetryUser = Registration_Pwdretry_textbox;
            
            bool allValid = Validate_TextBox(newNameUser, "Name", nameError_label, invalidTextBoxes, name_placeholder);
            allValid &= Validate_TextBox(newSurnameUser, "Surname", surnameError_label, invalidTextBoxes, surname_placeholder);
            allValid &= Validate_TextBox(newLoginUser, "Login", loginError_label, invalidTextBoxes, login_placeholder);
            allValid &= Validate_TextBox(newEmailUser, "Email", emailError_label, invalidTextBoxes, email_placeholder);
            allValid &= Validate_TextBox(newPwdUser, "Pwd", pwdError_label, invalidTextBoxes, pwd_placeholder);
            allValid &= Validate_TextBox(newPwdRetryUser, "Pwdretry", pwdretryError_label, invalidTextBoxes, pwdretry_placeholder);

            if (!allValid)
            {
                foreach (TextBox invalidTextBox in invalidTextBoxes)
                {
                    invalidTextBox.BackColor = ColorTranslator.FromHtml("#E89696");
                }
                return;
            }

            int isregistered = MyWoggi.registerUser(newNameUser, newSurnameUser, newLoginUser, newEmailUser, newPwdUser);


            if (isregistered == 0)
            {
                registrationError_label.Visible = true;
                registrationError_label.Text = "Пользователь с такими данными уже существует";
                return;
            }
            else if (isregistered == 1)
            {
                Registration registration = new Registration();
                registration.Show();
                this.Hide();
            }
            
            else
                MessageBox.Show("Произошла ошибка регистрации. Повторите попытку", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }
    }
}
