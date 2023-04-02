using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyWoggi
{
    public partial class ForgotPwdCode : Form
    {
        // Создание объекта класса Authorization
        Authorization authorization = new Authorization();

        // Задание текста-заполнителя для кода восстановления
        string recoveryCodePlaceholder = "Ваш код восстановления";
        // Экземпляр класса подсказок

        ToolTip toolTip = new ToolTip();

        // Переменные для кода восстановления и адреса электронной почты пользователя
        private int recoveryCode;
        private string userEmail;

        // Конструктор класса ForgotPwdCode с параметрами recoveryCode и userEmail
        public ForgotPwdCode(int recoveryCode, string userEmail)
        {
            InitializeComponent();
            // Подсказки при наведении на кнопку
            toolTip.SetToolTip(enterCode_button, "Перейти к восстановлению аккаунта");
            toolTip.SetToolTip(Login_Button, "Вернуться в окно авторизации");
            
            this.recoveryCode = recoveryCode;
            this.userEmail = userEmail;
        }

        // Обработчик события загрузки формы
        private void ForgotPwdCode_Load(object sender, EventArgs e)
        {
            recoveryCode_textbox.Text = recoveryCodePlaceholder;
            recoveryCode_textbox.ForeColor = Color.Gray;
        }

        // Обработчик события закрытия формы
        private void ForgotPwdCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Обработчик события входа в поле кода восстановления
        private void RecoveryCode_textbox_Enter(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(recoveryCode_textbox, recoveryCodePlaceholder);
        }

        // Обработчик события выхода из поля кода восстановления
        private void RecoveryCode_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(recoveryCode_textbox, recoveryCodePlaceholder);
        }

        // Обработчик события нажатия кнопки ввода кода восстановления
        private void EnterCode_Button(object sender, EventArgs e)
        {
            string userRecoveryCode = recoveryCode_textbox.Text;
            if (recoveryCode.ToString() == userRecoveryCode)
            {
                ForgotPwdNewPwd forgotPwdNewPwd = new ForgotPwdNewPwd(userEmail);
                forgotPwdNewPwd.Show();
                this.Hide();
            }
            else
            {
                recoverycodeError_label.Visible = true;
                recoverycodeError_label.Text = "Неверно введен код восстановления";
                recoveryCode_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
            }
        }

        // Обработчик события нажатия кнопки входа
        private void Enter_Button(object sender, EventArgs e)
        {
            authorization.Show();
            this.Hide();
        }

    }
}
