using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace MyWoggi
{
    public partial class ForgotPwdEmail : Form
    {
        // Создание объекта для аутентификации пользователя
        Authorization authorization = new Authorization();

        // Создание объекта базы данных MyWoggi
        Database MyWoggi = new Database();

        // Создание строки для заполнения плейсхолдера электронной почты
        string emailPlaceholder = "Ваша почта";


        // Создание переменной для кода восстановления пароля
        private int recoveryCode;

        // Создание объекта для генерации случайных чисел
        Random rand = new Random();

        // Конструктор класса UserEmail
        public ForgotPwdEmail()
        {
            InitializeComponent();
            // Генерация кода восстановления пароля
            recoveryCode = rand.Next(10000, 99999);
        }

        // Отправка кода восстановления на указанный адрес электронной почты
        public static void SendRecoveryCode(string userEmail, int generatedRecoveryCode)
        {
            // Указание email получателя, smtp-сервера и порта
            string senderEmail = "mywoggi@mail.ru";
            string senderPassword = "rcTj4ekuMgjvhMQHDpNx";
            string recipientEmail = $"{userEmail}";
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            
            // Создание объекта SmtpClient для отправки сообщения
            SmtpClient mySsmtpClient = new SmtpClient(smtpServer, smtpPort);
            mySsmtpClient.EnableSsl = true;
            mySsmtpClient.UseDefaultCredentials = false;
            
            // Установка параметров аутентификации
            NetworkCredential basicAuthentificationinfo = new NetworkCredential(senderEmail, senderPassword);
            mySsmtpClient.Credentials = basicAuthentificationinfo;

            // Установка адресов отправителя и получателя, а также темы и тела сообщения
            MailAddress from = new MailAddress(senderEmail, "MyWoggi - восстановление пароля");
            MailAddress to = new MailAddress(recipientEmail, "Пользователю");
            MailMessage mail = new MailMessage(from, to);

            // Установка адреса для ответа на сообщение
            MailAddress replyTo = new MailAddress(senderEmail);
            mail.ReplyToList.Add(replyTo);

            mail.Subject = $"MyWoggi | Восстановление пароля";
            mail.SubjectEncoding = Encoding.UTF8;
            mail.Body = $"Ваш код восстановления: {generatedRecoveryCode}";
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = false;
            try
            {
                // Отправка сообщения
                mySsmtpClient.Send(mail);
                Console.WriteLine("Код восстановления успешно отправлен");
            }    
            catch (Exception ex)
            {
                // Обработка ошибки отправки сообщения
                Console.WriteLine($"Ошибка отправки кода восстановления: {ex.Message}");
            }

            // Создание объекта для формы ввода кода восстановления и его отображение
            ForgotPwdCode recoveryCode = new ForgotPwdCode(generatedRecoveryCode, userEmail);
            recoveryCode.Show();
        }

        // Устанавливает начальное значение поля "Email" и цвет текста
        private void UserEmail_Load(object sender, EventArgs e)
        {
            email_textbox.Text = emailPlaceholder;
            email_textbox.ForeColor = Color.Gray;
        }

        // Обработчик события закрытия формы восстановления пароля
        private void ForgotPwdEmail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Обработчик события "вход фокуса в поле Email"
        private void Email_textbox_Enter(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(email_textbox, emailPlaceholder);
        }

        // Обработчик события "выход фокуса из поля Email"
        private void Email_textbox_Leave(object sender, EventArgs e)
        {
            authorization.SetPlaceholder(email_textbox, emailPlaceholder);
        }

        // Обработчик события нажатия на кнопку "Получить код"
        private void ReceiveCode_Button(object sender, EventArgs e)
        {
            var userEmail = email_textbox;
            string checkEmailQueryString = $"select id_user, email_user from Userdata " +
                $"where email_user = '{userEmail.Text}'";

            // Проверяет, есть ли такой Email в базе данных
            bool isSuchEmail = MyWoggi.SelectData(checkEmailQueryString);

            // Если Email есть в базе данных, отправляет код восстановления и скрывает форму восстановления пароля
            if (isSuchEmail)
            {
                SendRecoveryCode(userEmail.Text, recoveryCode);
                this.Hide();
            }
            // Если Email отсутствует в базе данных, выводит сообщение об ошибке и выделяет поле красным цветом
            else
            {
                userEmail.BackColor = ColorTranslator.FromHtml("#E89696");
                emailError_label.Visible = true;
                emailError_label.Text = "Неверно введена почта";
            }
        }

        // Обработчик события нажатия на кнопку "Войти"
        private void Enter_Button(object sender, EventArgs e)
        {
            // Создает новую форму авторизации и отображает ее, скрывая текущую форму восстановления пароля
            authorization.Show();
            this.Hide();
        }


    }
}
