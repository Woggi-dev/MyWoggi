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
    public partial class RecoveryCode : Form
    {
        string recoverycode_placeholder = "Ваш код восстановления";

        private void Set_Placeholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public RecoveryCode()
        {
            InitializeComponent();
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
            NewPwd forgotpwd_newpwd = new NewPwd();
            forgotpwd_newpwd.Show();
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
