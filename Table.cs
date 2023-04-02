using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWoggi.forms;

namespace MyWoggi
{
    enum RowState
    {
        Existed,
        New,
        Modified, 
        ModifiedNew,
        Deleted
    }
    public partial class Table : Form
    {
        Database MyWoggi = new Database();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("animal_id", "ИД животного");
            dataGridView1.Columns.Add("animal_name", "Имя животного");
            dataGridView1.Columns.Add("species_id", "Номер вида");
            dataGridView1.Columns.Add("enclosure_id", "Номер вольера");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from animals";

            MySqlCommand command = new MySqlCommand(queryString, MyWoggi.GetConnection());
            MyWoggi.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        public Table()
        {
            InitializeComponent();
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;

            // Set the height of the tab page switch
            tabControl1.ItemSize = new Size(tabControl1.ItemSize.Width, 33);

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
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Graphics g = e.Graphics;
            Rectangle r = tabControl.GetTabRect(e.Index);
            bool selected = (e.State == DrawItemState.Selected);

            // Set up a GraphicsPath with rounded corners
            GraphicsPath path = new GraphicsPath();
            int radius = 10; // adjust this value to change the amount of rounding
            path.StartFigure();
            path.AddArc(r.Left, r.Top, radius, radius, 180, 90);
            path.AddArc(r.Right - radius, r.Top, radius, radius, 270, 90);
            path.AddArc(r.Right - radius, r.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(r.Left, r.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Fill the background of the tab item
            using (SolidBrush brush = new SolidBrush(selected ? ColorTranslator.FromHtml("#A9A9A9") : Color.LightGray))
            {
                g.FillPath(brush, path);
            }

            // Draw the tab item text
            string text = tabControl.TabPages[e.Index].Text;
            using (Font font = new Font("Arial", 12))
            {
                SizeF size = g.MeasureString(text, font);
                float x = r.Left + (r.Width - size.Width) / 2;
                float y = r.Top + (r.Height - size.Height) / 2;
                using (SolidBrush brush = new SolidBrush(selected ? Color.Black : Color.Gray))
                {
                    g.DrawString(text, font, brush, x, y);
                }
            }

            // Draw the bottom border of the tab item
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawLine(pen, r.Left, r.Bottom - 1, r.Right, r.Bottom - 1);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
