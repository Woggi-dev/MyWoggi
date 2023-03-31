using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyWoggi
{
    public partial class ForgotPwdNewPwd : Form
    {
        // Создание экземпляров классов Authorization и Database
        Authorization authorization = new Authorization();
        Database MyWoggi = new Database();

        // Установка значений по умолчанию для полей ввода нового пароля
        string newPwdPlaceholder = "Ваш новый пароль";
        string newPwdRetryPlaceholder = "Ваш новый пароль повторно";

        // Переменная для хранения адреса электронной почты пользователя
        private string userEmail;

        private bool ValidateTextbox(TextBox textBox, string fieldName, Label errorLabel, List<TextBox> invalidTextBoxes, string placeHolder)
        {
            bool isValid = true;

            // Когда текстовое поле пустое или содержит наполнитель
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == placeHolder)
            {
                isValid = false; // значение невалидное
                invalidTextBoxes.Add(textBox);  // добавить текстовое поле в невалидный список
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
            else if (fieldName == "Pwd" && textBox.Text != newPwdRetry_textbox.Text)
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                invalidTextBoxes.Add(newPwdRetry_textbox);
                errorLabel.Visible = true;
                errorLabel.Text = "Пароли не совпадают";
            }
            // Иначе скрыть надписи ошибки и вернуть нормальное состояние текстовых полей
            else
            {
                textBox.BackColor = SystemColors.Window;
                errorLabel.Visible = false;
            }
            return isValid;
        }

        // Конструктор формы
        public ForgotPwdNewPwd(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
        }

        // Обработчик события загрузки формы
        private void ForgotPwdNewPwd_Load(object sender, EventArgs e)
        {
            newpwd_textbox.Text = newPwdPlaceholder;
            newpwd_textbox.ForeColor = Color.Gray;
            newPwdRetry_textbox.Text = newPwdRetryPlaceholder;
            newPwdRetry_textbox.ForeColor = Color.Gray;
        }

        // Обработчик события закрытия формы
        private void ForgotPwdNewPwd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Обработчики событий ввода и вывода фокуса текстовых полей нового пароля
        private void Newpwd_textbox_Enter(object sender, EventArgs e)
        {
            if (NewPwd_Showpwd_picturebox.Visible == false)
                newpwd_textbox.PasswordChar = '•';
            authorization.SetPlaceholder(newpwd_textbox, newPwdPlaceholder);
        }

        // Обработчик события Leave для текстового поля нового пароля
        private void Newpwd_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(newpwd_textbox, newPwdPlaceholder);
        }

        // Обработчик события Enter для текстового поля подтверждения нового пароля
        private void NewPwdRetry_textbox_Enter(object sender, EventArgs e)
        {
            if (NewPwd_Showpwdretry_picturebox.Visible == false)
                newPwdRetry_textbox.PasswordChar = '•';
            authorization.SetPlaceholder(newPwdRetry_textbox, newPwdRetryPlaceholder);
        }

        // Обработчик события Leave для текстового поля подтверждения нового пароля
        private void NewPwdRetry_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(newPwdRetry_textbox, newPwdRetryPlaceholder);
        }

        // Обработчик события Click для кнопки восстановления пароля
        private void RestorePwd_Button(object sender, EventArgs e)
        {
            // Создание списка невалидных полей
            List<TextBox> invalidTextBoxes = new List<TextBox>();
            // Получение значений полей ввода
            var userNewRestorePwd = newpwd_textbox;
            var userNewRestorePwdRetry = newPwdRetry_textbox;

            // Проверка валидности каждого поля
            bool allValid = ValidateTextbox(userNewRestorePwd, "Pwd", pwdError_label, invalidTextBoxes, newPwdPlaceholder);
            allValid &= ValidateTextbox(userNewRestorePwdRetry, "Pwdretry", pwdretryError_label, invalidTextBoxes, newPwdRetryPlaceholder);

            // Если есть невалидные поля, то изменить их цвет на красный и выйти из метода
            if (!allValid)
            {
                foreach (TextBox invalidTextBox in invalidTextBoxes)
                {
                    invalidTextBox.BackColor = ColorTranslator.FromHtml("#E89696");
                }
                return;
            }

            string updatePwdQueryString = $"update Userdata set password_user = ( '{userNewRestorePwd.Text}') where email_user = '{userEmail}'";
            // Восстановление пароля
            bool isRestored = MyWoggi.InsertUpdateData(updatePwdQueryString);
            
            // Когда восстановление пароля - успешно
            if (isRestored)
            {
                MessageBox.Show("Пароль был успешно восстановлен...", "Успех", MessageBoxButtons.OK);
                Authorization authorization = new Authorization();
                authorization.Show();
                this.Hide();
            }
            // Когда восстановление пароля - неуспешно
            else
            {
                recoveryPwdError_label.Visible = true;
                recoveryPwdError_label.Text = "Произошла ошибка восстановления пароля";
                newPwdRetry_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
            }
        }

        // Обработчик события Click для кнопки входа
        private void Enter_Button(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        // Обработчик события Click для изображения отображения пароля
        private void ShowPwd_picturebox_Click(object sender, EventArgs e)
        {
            NewPwd_Hidepwd_picturebox.Visible = true;
            NewPwd_Showpwd_picturebox.Visible = false;
            newpwd_textbox.PasswordChar = '•';
            if (newpwd_textbox.Text == newPwdPlaceholder)
                newpwd_textbox.PasswordChar = '\0';
        }

        // Обработчик события Click для изображения скрытия пароля
        private void HidePwd_picturebox_Click(object sender, EventArgs e)
        {
            NewPwd_Hidepwd_picturebox.Visible = false;
            NewPwd_Showpwd_picturebox.Visible = true;
            newpwd_textbox.PasswordChar = '\0';
            if (newpwd_textbox.Text == newPwdPlaceholder)
                newpwd_textbox.PasswordChar = '•';
        }

        // Обработчик события Click для изображения отображения пароля
        private void ShowPwdRetry_picturebox_Click(object sender, EventArgs e)
        {
            NewPwd_Hidepwdretry_picturebox.Visible = true;
            NewPwd_Showpwdretry_picturebox.Visible = false;
            newPwdRetry_textbox.PasswordChar = '•';
            if (newPwdRetry_textbox.Text == newPwdRetryPlaceholder)
                newPwdRetry_textbox.PasswordChar = '\0';
        }

        // Обработчик события Click для изображения скрытия пароля
        private void HidePwdRetry_picturebox_Click(object sender, EventArgs e)
        {
            NewPwd_Hidepwdretry_picturebox.Visible = false;
            NewPwd_Showpwdretry_picturebox.Visible = true;
            newPwdRetry_textbox.PasswordChar = '\0';
            if (newPwdRetry_textbox.Text == newPwdRetryPlaceholder)
                newPwdRetry_textbox.PasswordChar = '•';
        }
    }
}
