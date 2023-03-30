using System;
using System.Collections.Generic;
using System.Drawing;
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

        // Проверка текстовых полей на валидность
        private bool ValidateTextbox(TextBox textBox, string fieldName, Label errorLabel, List<TextBox> invalidTextBoxes, string placeHolder)
        {
            bool isValid = true; // значение валидность по умолчанию
            
            // Когда текстовое поле пустое или содержит наполнитель
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == placeHolder) 
            {
                isValid = false; // значение невалидное
                invalidTextBoxes.Add(textBox); // добавить текстовое поле в невалидный список
                errorLabel.Visible = true; // показать надпись ошибки
                errorLabel.Text = "Поле пустое"; // показать текст ошибки

            }
            // Когда текстовое поле содержит пробел
            else if (textBox.Text.Contains(" "))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Поле содержит пробелы";
            }
            // Когда текстовое поле "Имя" или "Фамилия" содержат цифры
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
            // Когда текстовое поле "Имя" или "Фамилия" содержат спец символы
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

            // Когда текстовое поле "Логин" содержит спец символы
            else if (fieldName == "Login" && !Regex.IsMatch(textBox.Text, "^[a-zA-Z0-9_]+$"))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Логин содержит спец символы";
            }

            // Когда текстовое поле "Почта" имеет невалидный формат
            else if (fieldName == "Email" && !Regex.IsMatch(textBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && (!textBox.Text.EndsWith("@gmail.com") && !textBox.Text.EndsWith("@mail.ru") && !textBox.Text.EndsWith("@inbox.ru") && !textBox.Text.EndsWith("@yandex.ru")))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Неверно введена почта";
            }
            
            // Когда текстовое поле "Пароль" не равно текстовому полю "Повторите пароль"
            else if (fieldName == "Pwd" && textBox.Text != pwdretry_textbox.Text)
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                invalidTextBoxes.Add(pwdretry_textbox);
                errorLabel.Visible = true;
                errorLabel.Text = "Пароли не совпадают";
            }
            // Иначе скрыть надписи ошибки и вернуть нормальное состояние текстовых полей
            else
            {
                textBox.BackColor = SystemColors.Window;
                errorLabel.Visible = false;
                pwdretryError_label.Visible = false;

            }

            return isValid;
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
            var newNameUser = name_textbox;
            var newSurnameUser = surname_textbox;
            var newLoginUser = login_textbox;
            var newEmailUser = email_textbox;
            var newPwdUser = pwd_textbox;
            var newPwdRetryUser = pwdretry_textbox;

            // Проверка валидности каждого поля
            bool allValid = ValidateTextbox(newNameUser, "Name", nameError_label, invalidTextBoxes, namePlaceholder);
            allValid &= ValidateTextbox(newSurnameUser, "Surname", surnameError_label, invalidTextBoxes, surnamePlaceholder);
            allValid &= ValidateTextbox(newLoginUser, "Login", loginError_label, invalidTextBoxes, loginPlaceholder);
            allValid &= ValidateTextbox(newEmailUser, "Email", emailError_label, invalidTextBoxes, emailPlaceholder);
            allValid &= ValidateTextbox(newPwdUser, "Pwd", pwdError_label, invalidTextBoxes, pwdPlaceholder);
            allValid &= ValidateTextbox(newPwdRetryUser, "Pwdretry", pwdretryError_label, invalidTextBoxes, pwdRetryPlaceholder);

            // Если есть невалидные поля, то изменить их цвет на красный и выйти из метода
            if (!allValid)
            {
                foreach (TextBox invalidTextBox in invalidTextBoxes)
                {
                    invalidTextBox.BackColor = ColorTranslator.FromHtml("#E89696");
                }
                return;
            }

            // Регистрация нового пользователя в системе
            int isregistered = MyWoggi.RegisterUser(newNameUser.Text, newSurnameUser.Text, newLoginUser.Text, newEmailUser.Text, newPwdUser.Text);

            // Если пользователь уже зарегистрирован, то вывести сообщение и выйти из метода
            if (isregistered == 0)
            {
                registrationError_label.Visible = true;
                registrationError_label.Text = "Пользователь с такими данными уже существует";
                return;
            }
            // Если регистрация прошла успешно, то показать форму регистрации и скрыть текущую форму
            else if (isregistered == 1)
            {
                Registration registration = new Registration();
                registration.Show();
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
