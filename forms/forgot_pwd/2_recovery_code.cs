using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWoggi
{
    public partial class RecoveryCode : Form
    {
        string recoverycode_placeholder = "Ваш код восстановления";
        private int recoveryCode;
        private string userEmail;

        private void Set_Placeholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public RecoveryCode(int recoveryCode, string userEmail)
        {
            InitializeComponent();
            this.recoveryCode = recoveryCode;
            this.userEmail = userEmail;
            
        }
        private void RecoveryCode_Load(object sender, EventArgs e)
        {
            RecoveryCode_Recoverycode_textbox.Text = recoverycode_placeholder;
            RecoveryCode_Recoverycode_textbox.ForeColor = Color.Gray;
        }

        private void ForgotPwd_Code_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RecoveryCode_Recoverycode_textbox_Enter(object sender, EventArgs e)
        {
            Set_Placeholder(RecoveryCode_Recoverycode_textbox, recoverycode_placeholder);
        }

        private void RecoveryCode_Recoverycode_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(RecoveryCode_Recoverycode_textbox, recoverycode_placeholder);
        }

        private void Enter_Code_Button(object sender, EventArgs e)
        {
            string userRecoveryCode = RecoveryCode_Recoverycode_textbox.Text;
            if (recoveryCode.ToString() == userRecoveryCode)
            {
                NewPwd forgotpwd_newpwd = new NewPwd(userEmail);
                forgotpwd_newpwd.Show();
                this.Hide();
            }
            else
            {
                recoverycodeError_label.Visible = true;
                recoverycodeError_label.Text = "Неверно введен код восстановления";
                RecoveryCode_Recoverycode_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
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
