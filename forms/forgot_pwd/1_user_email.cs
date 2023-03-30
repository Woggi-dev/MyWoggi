using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;

namespace MyWoggi
{
    public partial class UserEmail : Form
    {

        Database MyWoggi = new Database();
        string email_placeholder = "Ваша почта";
        private int recoveryCode;
        Random rand = new Random();

        public UserEmail()
        {
            InitializeComponent();
            recoveryCode = rand.Next(10000, 99999);
        }

        public static void SendRecoveryCode(string userEmail, int generatedRecoveryCode)
        {
            string senderEmail = "mywoggi@mail.ru"; // replace with your own sender email
            string senderPassword = "rcTj4ekuMgjvhMQHDpNx"; // replace with your own sender password
            string recipientEmail = $"{userEmail}";
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;

            SmtpClient mySsmtpClient = new SmtpClient(smtpServer, smtpPort);
            mySsmtpClient.EnableSsl = true;
            mySsmtpClient.UseDefaultCredentials = false;

            NetworkCredential basicAuthentificationinfo = new NetworkCredential(senderEmail, senderPassword);
            mySsmtpClient.Credentials = basicAuthentificationinfo;

            MailAddress from = new MailAddress(senderEmail, "MyWoggi - восстановление пароля");
            MailAddress to = new MailAddress(recipientEmail, "Пользователю");
            MailMessage mail = new MailMessage(from, to);

            MailAddress replyTo = new MailAddress(senderEmail);
            mail.ReplyToList.Add(replyTo);

            mail.Subject = $"MyWoggi | Восстановление пароля";
            mail.SubjectEncoding = Encoding.UTF8;
            mail.Body = $"Ваш код восстановления: {generatedRecoveryCode}";
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = false;
            try
            {
                mySsmtpClient.Send(mail);
                Console.WriteLine("Код восстановления успешно отправлен");
            }    
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка отправки кода восстановления: {ex.Message}");
            }

            RecoveryCode recoveryCode = new RecoveryCode(generatedRecoveryCode, userEmail);
            recoveryCode.Show();
        }

        private void Set_Placeholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void UserEmail_Load(object sender, EventArgs e)
        {
            UserEmail_Email_textbox.Text = email_placeholder;
            UserEmail_Email_textbox.ForeColor = Color.Gray;
        }


        private void ForgotPwd_Email_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserEmail_Email_textbox_Enter(object sender, EventArgs e)
        {
            Set_Placeholder(UserEmail_Email_textbox, email_placeholder);
        }

        private void UserEmail_Email_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(UserEmail_Email_textbox, email_placeholder);
        }

        private void Receive_Code_Button(object sender, EventArgs e)
        {
            bool isSuchEmail = MyWoggi.isSuchEmail(UserEmail_Email_textbox);
            
            if (isSuchEmail)
            {
                SendRecoveryCode(UserEmail_Email_textbox.Text, recoveryCode);
                this.Hide();
            }
            else
            {
                UserEmail_Email_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
                emailError_label.Visible = true;
                emailError_label.Text = "Неверно введена почта";
            }
        }

        private void Enter_Account_Button(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }


    }
}
