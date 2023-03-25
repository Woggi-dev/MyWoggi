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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            Authorization_Panel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();

        }

        private void ForgotPwd_Button_Click(object sender, EventArgs e)
        {
            ForgotPwd_Email forgotpwd_email = new ForgotPwd_Email();
            forgotpwd_email.Show();
            this.Hide();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
