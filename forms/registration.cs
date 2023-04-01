using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyWoggi
{
    public partial class Registration : Form
    {
        Authorization authorization = new Authorization();
        Database MyWoggi = new Database();
        string namePlaceholder = "Ваше имя";
        string surnamePlaceholder = "Ваша фамилия";
        string loginPlaceholder = "Ваш логин";
        string emailPlaceholder = "Ваша почта";
        string pwdPlaceholder = "Ваш пароль";
        string pwdRetryPlaceholder = "Ваш пароль повторно";



        public bool ValidateTextboxLength(TextBox textBox, Label errorLabel, List<TextBox> invalidTextBoxes, string placeHolder)
        {
            if (textBox.Text.Length < 3 || textBox.Text == placeHolder)
            {
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = $"Поле содержит < 3 символов";
                return false;
            }
            return true;
        }

        public void ValidateTextboxSymbols(TextBox textBox, string fieldName, Label errorLabel, List<TextBox> invalidTextBoxes)
        {
            if (Regex.IsMatch(textBox.Text, @"[!@#$%^&*()]"))
            {
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = $"{fieldName} содержит спец символы";
            }
        }

        public void ValidateTextboxDigits(TextBox textBox, string fieldName, Label errorLabel, List<TextBox> invalidTextBoxes)
        {
            if (Regex.IsMatch(textBox.Text, @"\d"))
            {
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = $"{fieldName} содержит цифры";
            }
        }

        private void ValidateTextboxEmail(TextBox email, Label errorLabel, List<TextBox> invalidTextBoxes)
        {
            bool isSuchDomain = !Regex.IsMatch(email.Text, @"\b(gmail\.com|mail\.ru|inbox\.ru|yandex\.ru)$");
            if (isSuchDomain)
            {
                invalidTextBoxes.Add(email);
                errorLabel.Visible = true;
                errorLabel.Text = $"Неверно введена почта";
            }
        }
        public void ValidateTextboxPwd(TextBox pwd, TextBox pwdRetry, Label pwdErrorLabel, Label pwdRetryErrorLabel, List<TextBox> invalidTextBoxes, string pwdPlaceHolder, string pwdRetryPlaceHolder)
        {
            bool pwdLength = ValidateTextboxLength(pwd, pwdErrorLabel, invalidTextBoxes, pwdPlaceHolder);
            bool pwdRetryLength = ValidateTextboxLength(pwdRetry, pwdRetryErrorLabel, invalidTextBoxes, pwdRetryPlaceHolder);
            
            if ((pwd.Text != pwdRetry.Text) && (pwdLength && pwdRetryLength))
            {
                invalidTextBoxes.Add(pwd);
                pwdErrorLabel.Visible = true;
                pwdErrorLabel.Text = "Пароли не совпадают";
                invalidTextBoxes.Add(pwdRetry);
                pwdRetryErrorLabel.Visible = true;
                pwdRetryErrorLabel.Text = "Пароли не совпадают";
            }
        }
        // Проверка текстовых полей на валидность
        private bool ValidateTextbox(TextBox [] textBoxes, string [] fieldNames, Label [] errorLabels, List<TextBox> invalidTextBoxes, string [] placeHolders)
        {
            for (int index = 0; index < textBoxes.Length; index++)
            {
                if (fieldNames[index] == "Имя" || fieldNames[index] == "Фамилия")
                {
                    ValidateTextboxSymbols(textBoxes[index], fieldNames[index], errorLabels[index], invalidTextBoxes);
                    ValidateTextboxDigits(textBoxes[index], fieldNames[index], errorLabels[index], invalidTextBoxes);
                }
                else if (fieldNames[index] == "Логин")
                {
                    ValidateTextboxSymbols(textBoxes[index], fieldNames[index], errorLabels[index], invalidTextBoxes);
                }
                else if (fieldNames[index] == "Почта")
                {
                    ValidateTextboxEmail(textBoxes[index], errorLabels[index], invalidTextBoxes);
                }
                ValidateTextboxLength(textBoxes[index], errorLabels[index], invalidTextBoxes, placeHolders[index]);

                if (!invalidTextBoxes.Contains(textBoxes[index]))
                {
                    textBoxes[index].BackColor = SystemColors.Window;
                    errorLabels[index].Visible = false;
                }
            }
            ValidateTextboxPwd(pwd_textbox, pwdretry_textbox, pwdError_label, pwdRetryError_label, invalidTextBoxes, pwdPlaceholder, pwdRetryPlaceholder);    

            if (invalidTextBoxes.Count > 0)
                return false;

            return true;
        }
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            name_textbox.Text = namePlaceholder;
            surname_textbox.Text = surnamePlaceholder;
            login_textbox.Text = loginPlaceholder;
            email_textbox.Text = emailPlaceholder;
            pwd_textbox.Text = pwdPlaceholder;
            pwdretry_textbox.Text = pwdRetryPlaceholder;

            name_textbox.ForeColor = Color.Gray;
            surname_textbox.ForeColor = Color.Gray;
            login_textbox.ForeColor = Color.Gray;
            email_textbox.ForeColor = Color.Gray;
            pwd_textbox.ForeColor = Color.Gray;
            pwdretry_textbox.ForeColor = Color.Gray;
        }

        // Метод закрытия формы регистрации
        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Закрытие приложения
            Application.Exit();
        }

        // Обработчик нажатия на кнопку логина
        private void Login_button(object sender, EventArgs e)
        {
            // Создание объекта авторизации и отображение его на экране
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        // Обработчик события "ввод в текстовое поле" для поля "Имя"
        private void Name_textbox_Enter(object sender, EventArgs e)
        {
            // Установка плейсхолдера в текстовое поле "Имя"
            authorization.SetPlaceholder(name_textbox, namePlaceholder);
        }

        // Обработчик события "выход из текстового поля" для поля "Имя"
        private void Name_textbox_Leave(object sender, EventArgs e)
        {
            // Если поле для ввода пароля пустое, устанавливается плейсхолдер
            authorization.SetPlaceholder(name_textbox, namePlaceholder);
        }

        // Обработчик события "ввод в текстовое поле" для поля "Фамилия"
        private void Surname_textbox_Enter(object sender, EventArgs e)
        {
            // Установка плейсхолдера в текстовое поле "Фамилия"
            authorization.SetPlaceholder(surname_textbox, surnamePlaceholder);
        }

        // Обработчик события "выход из текстового поля" для поля "Фамилия"
        private void Surname_textbox_Leave(object sender, EventArgs e)
        {
            // Установка плейсхолдера в текстовое поле "Фамилия"
            authorization.SetPlaceholder(surname_textbox, surnamePlaceholder);
        }

        // Обработчик события "ввод в текстовое поле" для поля "Логин"
        private void Login_textbox_Enter(object sender, EventArgs e)
        {
            // Установка плейсхолдера в текстовое поле "Логин"
            authorization.SetPlaceholder(login_textbox, loginPlaceholder);
        }

        // Метод, который вызывается при покидании поля ввода логина
        private void Login_textbox_Leave(object sender, EventArgs e)
        {
            // Устанавливаем плейсхолдер для поля ввода логина
            authorization.SetPlaceholder(login_textbox, loginPlaceholder);
        }

        // Метод, который вызывается при входе в поле ввода электронной почты
        private void Email_textbox_Enter(object sender, EventArgs e)
        {
            // Устанавливаем плейсхолдер для поля ввода электронной почты
            authorization.SetPlaceholder(email_textbox, emailPlaceholder);
        }

        // Метод, который вызывается при покидании поля ввода электронной почты
        private void Email_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(email_textbox, emailPlaceholder);
        }

        // Метод, который вызывается при входе в поле ввода пароля
        private void Pwd_textbox_Enter(object sender, EventArgs e)
        {
            if (ShowPwd_picturebox.Visible == false)
                pwd_textbox.PasswordChar = '•';
            authorization.SetPlaceholder(pwd_textbox, pwdPlaceholder);


        }
        // Метод, который вызывается при выходе из поля "Пароль"
        private void Pwd_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(pwd_textbox, pwdPlaceholder);
        }

        // Метод, который вызывается при входе в поле "Пароль повторно"
        private void PwdRetry_textbox_Enter(object sender, EventArgs e)
        {
            if (ShowPwdRetry_picturebox.Visible == false)
                pwdretry_textbox.PasswordChar = '•';
            authorization.SetPlaceholder(pwdretry_textbox, pwdRetryPlaceholder);
        }

        // Метод, который вызывается при выходе из поля "Пароль повторно"
        private void PwdRetry_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(pwdretry_textbox, pwdRetryPlaceholder);

        }

        // Метод, который вызывается при клике на картинку "Показать пароль"
        private void ShowPwd_picturebox_Click(object sender, EventArgs e)
        {
            HidePwd_picturebox.Visible = true;
            ShowPwd_picturebox.Visible = false;
            pwd_textbox.PasswordChar = '•';
            if (pwd_textbox.Text == pwdPlaceholder)
                pwd_textbox.PasswordChar = '\0';
        }
        // Метод, который вызывается при клике на картинку "Скрыть пароль"
        private void HidePwd_picturebox_Click(object sender, EventArgs e)
        {
            HidePwd_picturebox.Visible = false;
            ShowPwd_picturebox.Visible = true;
            pwd_textbox.PasswordChar = '\0';
            if (pwd_textbox.Text == pwdPlaceholder)
                pwd_textbox.PasswordChar = '•';
        }

        // Метод, который вызывается при клике на картинку "Показать пароль повторно"
        private void ShowPwdRetry_picturebox_Click(object sender, EventArgs e)
        {
            HidePwdRetry_picturebox.Visible = true;
            ShowPwdRetry_picturebox.Visible = false;
            pwdretry_textbox.PasswordChar = '•';
            if (pwdretry_textbox.Text == pwdRetryPlaceholder)
                pwdretry_textbox.PasswordChar = '\0';
        }
        // Метод, который вызывается при клике на картинку "Скрыть пароль повторно"
        private void HidePwdRetry_picturebox_Click(object sender, EventArgs e)
        {
            HidePwdRetry_picturebox.Visible = false;
            ShowPwdRetry_picturebox.Visible = true;
            pwdretry_textbox.PasswordChar = '\0';
            if (pwdretry_textbox.Text == pwdRetryPlaceholder)
                pwdretry_textbox.PasswordChar = '•';
        }

        // Обработчик события клика по кнопке "Зарегистрироваться"
        private void Register_button_Click(object sender, EventArgs e)
        {
            // Создание списка невалидных полей
            List<TextBox> invalidTextBoxes = new List<TextBox>();
            // Получение значений полей ввода
            TextBox[] newDataUser = {name_textbox, surname_textbox, login_textbox, email_textbox, pwd_textbox, pwdretry_textbox };
            string[] fieldNames = { "Имя", "Фамилия", "Логин", "Почта", "Пароль", "Пароль повторно" };
            Label[] errorLabels = { nameError_label, surnameError_label, loginError_label, emailError_label, pwdError_label, pwdRetryError_label };
            string[] placeHolders = { namePlaceholder, surnamePlaceholder, loginPlaceholder, emailPlaceholder, pwdPlaceholder, pwdRetryPlaceholder };

            // Проверка валидности каждого поля
            bool allValid = ValidateTextbox(newDataUser, fieldNames, errorLabels, invalidTextBoxes, placeHolders);

            // Если есть невалидные поля, то изменить их цвет на красный и выйти из метода
            if (!allValid)
            {
                foreach (TextBox invalidTextBox in invalidTextBoxes)
                {
                    invalidTextBox.BackColor = ColorTranslator.FromHtml("#E89696");
                }
                return;
            }


            string registerUserQueryString = $"insert into Userdata(login_user, name_user, surname_user, email_user, password_user) " +
            $"VALUES('{newDataUser[0].Text}', '{newDataUser[1].Text}', '{newDataUser[2].Text}', '{newDataUser[3].Text}', '{newDataUser[4].Text}')";
            
            string checkUserQueryString = $"select id_user, login_user, email_user from Userdata where login_user = '{newDataUser[2].Text}' or email_user = '{newDataUser[3].Text}'";
            
            bool isRegistered = MyWoggi.InsertUpdateData(registerUserQueryString);
            bool isSuchUser = MyWoggi.SelectData(checkUserQueryString);

            // Если пользователь уже зарегистрирован, то вывести сообщение и выйти из метода
            if (isSuchUser)
            {
                registrationError_label.Visible = true;
                registrationError_label.Text = "Пользователь с такими данными уже существует";
                return;
            }
            // Если регистрация прошла успешно, то показать форму регистрации и скрыть текущую форму
            else if (isRegistered)
            {
                MessageBox.Show("Регистрация прошла успешно...", "Успех", MessageBoxButtons.OK);
                authorization.Show();
                this.Hide();
            }
            // Если произошла ошибка регистрации, то вывести сообщение об ошибке
            else
            {
                registrationError_label.Visible = true;
                registrationError_label.Text = "Произошла ошибка регистрации";
            }




        }
    }
}
