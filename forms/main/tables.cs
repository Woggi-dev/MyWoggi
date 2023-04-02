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
using System.IO;

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
    public partial class tables : Form
    {
        Authorization authorization = new Authorization();
        Homepage homepage = new Homepage();
        Database MyWoggi = new Database();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("animal_id", "ИД животного");
            dataGridView1.Columns.Add("animal_name", "Имя животного");
            dataGridView1.Columns.Add("animal_weight", "Вес животного");
            dataGridView1.Columns.Add("animal_age", "Возраст животного");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
                dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }


        private void RefreshDataGrid(DataGridView dgw, string queryString)
        {
            dgw.Rows.Clear();

            MySqlCommand command = new MySqlCommand(queryString, MyWoggi.GetConnection());
            MyWoggi.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            string animalsQueryString = $"select * from animals";
            

            CreateColumns();
            RefreshDataGrid(dataGridView1, animalsQueryString);
            
        }
        public tables()
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
            Homepage main = new Homepage();
            main.Show();
            this.Hide();
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

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                idAnimal_textbox.Text = row.Cells[0].Value.ToString();
                nameAnimal_textbox.Text = row.Cells[1].Value.ToString();
                animalWeight_textbox.Text = row.Cells[2].Value.ToString();
                animalAge_textbox.Text = row.Cells[3].Value.ToString();
            }
        }

        

        private void newWrite1_button_Click(object sender, EventArgs e)
        {
            add_new_data add_New_Data = new add_new_data();
            add_New_Data.Show();
            
        }

        private void update_picturebox_Click(object sender, EventArgs e)
        {
            string animalsQueryString = $"select * from animals";
            RefreshDataGrid(dataGridView1, animalsQueryString);
        }


        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string searchString = $"select * from animals where concat (animal_id, animal_name, animal_weight, animal_age) " +
                $"like'%" + Search_texBox.Text + "%' ";

            MySqlCommand com = new MySqlCommand(searchString, MyWoggi.GetConnection());

            MyWoggi.OpenConnection();

            MySqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dwg, read);
            }

            read.Close();
        }


        private void Search_textbox(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }



        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
        }


        private void deleteWrite1_button_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private new void Update()
        {
            MyWoggi.OpenConnection();
            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from animals where animal_id = '{id}'";

                    var command = new MySqlCommand(deleteQuery, MyWoggi.GetConnection());
                    command.ExecuteNonQuery();

                }
                if (rowState == RowState.Modified)
                {
                    var id_animal = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name_animal = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var weight_animal = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var age_animal = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"update animals set animal_name = '{name_animal}', animal_weight = '{weight_animal}', animal_age = '{age_animal}' where animal_id = '{id_animal}'";
                    var command = new MySqlCommand(changeQuery, MyWoggi.GetConnection());
                    command.ExecuteNonQuery();


                }

            }
            MyWoggi.CloseConnection();
        }

        private void saveWrite1_button_Click(object sender, EventArgs e)
        {
            Update(); 
        }



        private void Change()
        {
            var selectRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id_animal = idAnimal_textbox.Text;
            var name_animal = nameAnimal_textbox.Text;
            var weight_animal = animalWeight_textbox.Text;
            var age_animal = animalAge_textbox.Text;

            if(dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectRowIndex].SetValues(id_animal, name_animal, weight_animal, age_animal);
                dataGridView1.Rows[selectRowIndex].Cells[4].Value = RowState.Modified;
            }
        }

        private void changeWrite1_button_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            homepage.LogOut();
        }
    }
}
