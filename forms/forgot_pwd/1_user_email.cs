using System;
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
    public partial class UserEmail : Form
    {
        string email_placeholder = "Ваша почта";
        private void Set_Placeholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public UserEmail()
        {
            InitializeComponent();
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
            RecoveryCode forgotpwd_code = new RecoveryCode();
            forgotpwd_code.Show();
            this.Hide();
        }

        private void Enter_Account_Button(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }


    }
}
