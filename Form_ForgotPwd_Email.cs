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
    public partial class ForgotPwd_Email : Form
    {
        public ForgotPwd_Email()
        {
            InitializeComponent();
        }

        private void ForgotPwd_Email_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Receive_Code_Button(object sender, EventArgs e)
        {
            ForgotPwd_Code forgotpwd_code = new ForgotPwd_Code();
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
