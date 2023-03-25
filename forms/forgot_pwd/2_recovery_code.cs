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
        public RecoveryCode()
        {
            InitializeComponent();
        }

        private void ForgotPwd_Code_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
