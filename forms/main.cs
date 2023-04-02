using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWoggi.forms
{
    public partial class Main : Form
    {
        Authorization authorization = new Authorization();
        Database MyWoggi = new Database();
        private string authTokenFilePath;
        private string authToken;
        public Main()
        {
            InitializeComponent();
            authTokenFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "authtoken.txt");

        }
        private string ReadAuthToken()
        {
            FileStream fileStream = new FileStream(authTokenFilePath, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            string authToken = streamReader.ReadLine();
            streamReader.Close();
            fileStream.Close();
            return authToken;
        }
        //переход на форму About_the_project
        private void button_about_the_project(object sender, EventArgs e)
        {
            About_the_project about_The_Project = new About_the_project();
            about_The_Project.Show();
            this.Hide();
        }
        //переход на форму Table
        private void buttonTable_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Show();
            this.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_button(object sender, EventArgs e)
        {
            authToken = ReadAuthToken();
            string rememberMeDisabledQueryString = $"update Userdata set rememberme_user = '0' where authtoken_user = '{authToken}'";
            bool isRememberDisabled = MyWoggi.InsertUpdateData(rememberMeDisabledQueryString);
            if (isRememberDisabled)
            {
                authorization.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Произошла ошибка выхода из аккаунта...", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
