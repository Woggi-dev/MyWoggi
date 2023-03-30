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
        Database MyWoggi = new Database();
        string newpwd_placeholder = "Ваш новый пароль";
        string newpwdretry_placeholder = "Ваш новый пароль повторно";
        private string userEmail;

        private bool Validate_TextBox(TextBox textBox, string fieldName, Label errorLabel, List<TextBox> invalidTextBoxes, string placeHolder)
        {
            bool isValid = true;
            // Check if the textbox is empty or whitespace
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == placeHolder)
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Поле пустое";

            }
            else if (textBox.Text.Contains(" "))
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                errorLabel.Visible = true;
                errorLabel.Text = "Поле содержит пробелы";
            }
            // Check for special characters in name and surname

            else if (fieldName == "Pwd" && textBox.Text != NewPwd_Newpwdretry_textbox.Text)
            {
                isValid = false;
                invalidTextBoxes.Add(textBox);
                invalidTextBoxes.Add(NewPwd_Newpwdretry_textbox);
                errorLabel.Visible = true;
                errorLabel.Text = "Пароли не совпадают";
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
                errorLabel.Visible = false;

            }

            return isValid;
        }
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
        public NewPwd(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;

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
            List<TextBox> invalidTextBoxes = new List<TextBox>();
            var userNewRestorePwd = NewPwd_Newpwd_textbox;
            var userNewRestorePwdRetry = NewPwd_Newpwdretry_textbox;

            bool allValid = Validate_TextBox(userNewRestorePwd, "Pwd", pwdError_label, invalidTextBoxes, newpwd_placeholder);
            allValid &= Validate_TextBox(userNewRestorePwdRetry, "Pwdretry", pwdretryError_label, invalidTextBoxes, newpwdretry_placeholder);

            if (!allValid)
            {
                foreach (TextBox invalidTextBox in invalidTextBoxes)
                {
                    invalidTextBox.BackColor = ColorTranslator.FromHtml("#E89696");
                }
                return;
            }


            bool isrestored = MyWoggi.updatePwd(userNewRestorePwd.Text, userEmail);
            if (isrestored)
            {
                Authorization authorization = new Authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                recoverypwdError_label.Visible = true;
                recoverypwdError_label.Text = "Произошла ошибка восстановления пароля";
                NewPwd_Newpwdretry_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
            }
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
