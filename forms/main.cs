using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWoggi.forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
    }
}
