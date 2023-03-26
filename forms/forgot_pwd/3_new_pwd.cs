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
        string newpwd_placeholder = "Ваш новый пароль";
        string newpwdretry_placeholder = "Ваш новый пароль повторно";

        private void Set_Placeholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            else if (textBox.Text == "")
            {
                textBox.PasswordChar = '\0';
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }
        public NewPwd()
        {
            InitializeComponent();
        }

        private void NewPwd_Load(object sender, EventArgs e)
        {
            NewPwd_Newpwd_textbox.Text = newpwd_placeholder;
            NewPwd_Newpwd_textbox.ForeColor = Color.Gray;
            
            NewPwd_Newpwdretry_textbox.Text = newpwdretry_placeholder;
            NewPwd_Newpwdretry_textbox.ForeColor = Color.Gray;
        }

        private void ForgotPwd_NewPwd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NewPwd_Newpwd_textbox_Enter(object sender, EventArgs e)
        {
            if (NewPwd_Showpwd_picturebox.Visible == false)
                NewPwd_Newpwd_textbox.PasswordChar = '•';
            Set_Placeholder(NewPwd_Newpwd_textbox, newpwd_placeholder);
        }

        private void NewPwd_Newpwd_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(NewPwd_Newpwd_textbox, newpwd_placeholder);

        }

        private void NewPwd_Newpwdretry_textbox_Enter(object sender, EventArgs e)
        {
            if (NewPwd_Showpwdretry_picturebox.Visible == false)
                NewPwd_Newpwdretry_textbox.PasswordChar = '•';
            Set_Placeholder(NewPwd_Newpwdretry_textbox, newpwdretry_placeholder);
        }

        private void NewPwd_Newpwdretry_textbox_Leave(object sender, EventArgs e)
        {
            Set_Placeholder(NewPwd_Newpwdretry_textbox, newpwdretry_placeholder);

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

        private void NewPwd_Showpwd_picturebox_Click(object sender, EventArgs e)
        {
            NewPwd_Hidepwd_picturebox.Visible = true;
            NewPwd_Showpwd_picturebox.Visible = false;
            NewPwd_Newpwd_textbox.PasswordChar = '•';
            if (NewPwd_Newpwd_textbox.Text == newpwd_placeholder)
                NewPwd_Newpwd_textbox.PasswordChar = '\0';
        }

        private void NewPwd_Hidepwd_picturebox_Click(object sender, EventArgs e)
        {
            NewPwd_Hidepwd_picturebox.Visible = false;
            NewPwd_Showpwd_picturebox.Visible = true;
            NewPwd_Newpwd_textbox.PasswordChar = '\0';
            if (NewPwd_Newpwd_textbox.Text == newpwd_placeholder)
                NewPwd_Newpwd_textbox.PasswordChar = '•';
        }

        private void NewPwd_Showpwdretry_picturebox_Click(object sender, EventArgs e)
        {
            NewPwd_Hidepwdretry_picturebox.Visible = true;
            NewPwd_Showpwdretry_picturebox.Visible = false;
            NewPwd_Newpwdretry_textbox.PasswordChar = '•';
            if (NewPwd_Newpwdretry_textbox.Text == newpwdretry_placeholder)
                NewPwd_Newpwdretry_textbox.PasswordChar = '\0';
        }

        private void NewPwd_Hidepwdretry_picturebox_Click(object sender, EventArgs e)
        {
            NewPwd_Hidepwdretry_picturebox.Visible = false;
            NewPwd_Showpwdretry_picturebox.Visible = true;
            NewPwd_Newpwdretry_textbox.PasswordChar = '\0';
            if (NewPwd_Newpwdretry_textbox.Text == newpwdretry_placeholder)
                NewPwd_Newpwdretry_textbox.PasswordChar = '•';
        }
    }
}
