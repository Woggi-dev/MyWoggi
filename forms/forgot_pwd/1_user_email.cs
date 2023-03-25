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
        public UserEmail()
        {
            InitializeComponent();
        }

        private void ForgotPwd_Email_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
