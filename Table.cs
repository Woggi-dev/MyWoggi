using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWoggi.forms;

namespace MyWoggi
{
    public partial class Table : Form
    {
        
        
        public Table()
        {
            InitializeComponent();
            tabControl1.BackColor = Color.Green;

        }
        //закрытие формы
        private void Table_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //переход в Home
        private void button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Table_Load(object sender, EventArgs e)
        {
        }
    }
}
