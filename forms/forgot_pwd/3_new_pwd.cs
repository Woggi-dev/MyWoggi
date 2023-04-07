using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyWoggi
{
    public partial class ForgotPwdNewPwd : Form
    {
        // Создание экземпляров классов Authorization и Database
        Authorization authorization = new Authorization();
        Registration registration = new Registration();
        Database MyWoggi = new Database();
        // Экземпляр класса подсказок
        ToolTip toolTip = new ToolTip();


        // Установка значений по умолчанию для полей ввода нового пароля
        string newLoginPlaceholder = "Ваш новый логин";
        string newLoginRetryPlaceholder = "Ваш новый логин повторно";
        string newPwdPlaceholder = "Ваш новый пароль";
        string newPwdRetryPlaceholder = "Ваш новый пароль повторно";

        // Переменная для хранения адреса электронной почты пользователя
        private string userEmail;


        // Конструктор формы
        public ForgotPwdNewPwd(string userEmail)
        {
            // Подсказки при наведении на кнопку
            toolTip.SetToolTip(restoreAccount_button, "Восстановить аккаунт");
            toolTip.SetToolTip(login_button, "Вернуться в окно авторизации");
            toolTip.SetToolTip(hidePwd_picturebox, "Показать пароль");
            toolTip.SetToolTip(hidePwdRetry_picturebox, "Показать пароль");
            toolTip.SetToolTip(showPwd_picturebox, "Скрыть пароль");
            toolTip.SetToolTip(showPwdRetry_picturebox, "Скрыть пароль");
            InitializeComponent();
            this.userEmail = userEmail;
        }
        // Метод для проверки соответствия введенных логинов
        private void ValidateTextboxLogin(TextBox login, TextBox loginRetry, Label loginErrorLabel, Label loginRetryErrorLabel, List<TextBox> invalidTextBoxes)
        {
            bool areLoginsEqual = login.Text != loginRetry.Text;
            bool loginLength = registration.ValidateTextboxLength(login, loginErrorLabel, invalidTextBoxes, newLoginPlaceholder);
            bool loginRetryLength = registration.ValidateTextboxLength(loginRetry, loginRetryErrorLabel, invalidTextBoxes, newLoginRetryPlaceholder);

            if ((areLoginsEqual) && (loginLength && loginRetryLength))
            {
                invalidTextBoxes.Add(login);
                loginErrorLabel.Visible = true;
                loginErrorLabel.Text = "Логины не совпадают";
                invalidTextBoxes.Add(loginRetry);
                loginRetryError_label.Visible = true;
                loginRetryError_label.Text = "Логины не совпадают";
            }
        }
        // Проверка текстовых полей на валидность
        private bool ValidateTextbox(TextBox[] textBoxes, string[] fieldNames, Label[] errorLabels, List<TextBox> invalidTextBoxes, string[] placeHolders)
        {
            for (int index = 0; index < textBoxes.Length; index++)
            {
                if (fieldNames[index] == "Новый логин" || fieldNames[index] == "Новый логин повторно")
                {
                    registration.ValidateTextboxSymbols(textBoxes[index], fieldNames[index], errorLabels[index], invalidTextBoxes);
                }
                registration.ValidateTextboxLength(textBoxes[index], errorLabels[index], invalidTextBoxes, placeHolders[index]);

                if (!invalidTextBoxes.Contains(textBoxes[index]))
                {
                    textBoxes[index].BackColor = SystemColors.Window;
                    errorLabels[index].Visible = false;
                }
            }
            ValidateTextboxLogin(newLogin_textbox, newLoginRetry_textbox, loginError_label, loginRetryError_label, invalidTextBoxes);
            registration.ValidateTextboxPwd(newPwd_textbox, newPwdRetry_textbox, pwdError_label, pwdretryError_label, invalidTextBoxes, newPwdPlaceholder, newPwdRetryPlaceholder);

            if (invalidTextBoxes.Count > 0)
                return false;

            return true;
        }


        // Обработчик события загрузки формы
        private void ForgotPwdNewPwd_Load(object sender, EventArgs e)
        {
            newLogin_textbox.Text = newLoginPlaceholder;
            newLogin_textbox.ForeColor = Color.Gray;
            newLoginRetry_textbox.Text = newLoginRetryPlaceholder;
            newLoginRetry_textbox.ForeColor = Color.Gray;
            newPwd_textbox.Text = newPwdPlaceholder;
            newPwd_textbox.ForeColor = Color.Gray;
            newPwdRetry_textbox.Text = newPwdRetryPlaceholder;
            newPwdRetry_textbox.ForeColor = Color.Gray;
        }

        // Обработчик события закрытия формы
        private void ForgotPwdNewPwd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Обработчик входа в текстовое поле логина 

        private void newLogin_textbox_Enter(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(newLogin_textbox, newLoginPlaceholder);

        }
        // Обработчик выхода в текстовое поле логина
        private void newLogin_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(newLogin_textbox, newLoginPlaceholder);

        }
        // Обработчик входа в текстовое поле повторного логина
        private void newLoginRetry_textbox_Enter(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(newLoginRetry_textbox, newLoginRetryPlaceholder);

        }
        // Обработчик выхода из текстового поля повторного логина
        private void newLoginRetry_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(newLoginRetry_textbox, newLoginRetryPlaceholder);

        }

        // Обработчики событий ввода и вывода фокуса текстовых полей нового пароля
        private void Newpwd_textbox_Enter(object sender, EventArgs e)
        {
            if (showPwd_picturebox.Visible == false)
                newPwd_textbox.PasswordChar = '•';
            authorization.SetPlaceholder(newPwd_textbox, newPwdPlaceholder);
        }

        // Обработчик события Leave для текстового поля нового пароля
        private void Newpwd_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(newPwd_textbox, newPwdPlaceholder);
        }

        // Обработчик события Enter для текстового поля подтверждения нового пароля
        private void NewPwdRetry_textbox_Enter(object sender, EventArgs e)
        {
            if (showPwdRetry_picturebox.Visible == false)
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
            TextBox[] userData = { newLogin_textbox, newLoginRetry_textbox, newPwd_textbox, newPwdRetry_textbox };
            string[] fieldNames = { "Новый логин", "Новый логин повторно", "Новый пароль", "Новый пароль повторно"};
            Label[] errorLabels = {loginError_label, loginRetryError_label, pwdError_label, pwdretryError_label};
            string[] placeHolders = { newLoginPlaceholder, newLoginRetryPlaceholder, newPwdPlaceholder, newPwdRetryPlaceholder};

            // Проверка валидности каждого поля
            bool allValid = ValidateTextbox(userData, fieldNames, errorLabels, invalidTextBoxes, placeHolders);

            // Если есть невалидные поля, то изменить их цвет на красный и выйти из метода
            if (!allValid)
            {
                foreach (TextBox invalidTextBox in invalidTextBoxes)
                {
                    invalidTextBox.BackColor = ColorTranslator.FromHtml("#E89696");
                }
                return;
            }

            string updatePwdLoginQueryString = $"update Userdata set login_user = '{userData[0].Text}', password_user = '{userData[2].Text}' where email_user = '{userEmail}'";
            // Восстановление аккаунта
            bool isAccountRestored = MyWoggi.InsertUpdateData(updatePwdLoginQueryString);
            
            // Когда восстановление аккаунта - успешно
            if (isAccountRestored)
            {
                MessageBox.Show("Пароль был успешно восстановлен", "Успех", MessageBoxButtons.OK);
                Authorization authorization = new Authorization();
                authorization.Show();
                this.Hide();
            }
            // Когда восстановление аккаунта - неуспешно
            else
            {
                recoveryPwdError_label.Visible = true;
                recoveryPwdError_label.Text = "Произошла ошибка восстановления аккаунта";
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
            hidePwd_picturebox.Visible = true;
            showPwd_picturebox.Visible = false;
            newPwd_textbox.PasswordChar = '•';
            if (newPwd_textbox.Text == newPwdPlaceholder)
                newPwd_textbox.PasswordChar = '\0';
        }

        // Обработчик события Click для изображения скрытия пароля
        private void HidePwd_picturebox_Click(object sender, EventArgs e)
        {
            hidePwd_picturebox.Visible = false;
            showPwd_picturebox.Visible = true;
            newPwd_textbox.PasswordChar = '\0';
            if (newPwd_textbox.Text == newPwdPlaceholder)
                newPwd_textbox.PasswordChar = '•';
        }

        // Обработчик события Click для изображения отображения пароля
        private void ShowPwdRetry_picturebox_Click(object sender, EventArgs e)
        {
            hidePwdRetry_picturebox.Visible = true;
            showPwdRetry_picturebox.Visible = false;
            newPwdRetry_textbox.PasswordChar = '•';
            if (newPwdRetry_textbox.Text == newPwdRetryPlaceholder)
                newPwdRetry_textbox.PasswordChar = '\0';
        }

        // Обработчик события Click для изображения скрытия пароля
        private void HidePwdRetry_picturebox_Click(object sender, EventArgs e)
        {
            hidePwdRetry_picturebox.Visible = false;
            showPwdRetry_picturebox.Visible = true;
            newPwdRetry_textbox.PasswordChar = '\0';
            if (newPwdRetry_textbox.Text == newPwdRetryPlaceholder)
                newPwdRetry_textbox.PasswordChar = '•';
        }

    }
}
