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
    public partial class NewPwd : Form
    {
        public NewPwd()
        {
            InitializeComponent();
        }

        private void ForgotPwd_NewPwd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Restore_Pwd_Button(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
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
