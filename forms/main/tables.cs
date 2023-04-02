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
        Database MyWoggi = new Database();
        int selectedRow;
        private string authTokenFilePath;
        private string authToken;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("animal_id", "ИД животного");
            dataGridView1.Columns.Add("animal_name", "Имя животного");
            dataGridView1.Columns.Add("species_id", "Номер вида");
            dataGridView1.Columns.Add("enclosure_id", "Номер вольера");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            dataGridView2.Columns.Add("category_id", "ИД категории");
            dataGridView2.Columns.Add("category_name", "Имя категории");
            dataGridView2.Columns.Add("IsNew", String.Empty);

            dataGridView3.Columns.Add("enclosure_id", "ИД вольера");
            dataGridView3.Columns.Add("enclosure_name", "Имя вольера");
            dataGridView3.Columns.Add("enclosure_size", "Размер вольера");
            dataGridView3.Columns.Add("IsNew", String.Empty);

            dataGridView4.Columns.Add("species_id", "ИД вида");
            dataGridView4.Columns.Add("species_name", "Имя вида");
            dataGridView4.Columns.Add("category_id", "Номер категории");
            dataGridView4.Columns.Add("IsNew", String.Empty);

            dataGridView5.Columns.Add("visitor_id", "ИД посетителя");
            dataGridView5.Columns.Add("visitor_name", "Имя посетителя");
            dataGridView5.Columns.Add("ticket_id", "Номер билета");
            dataGridView5.Columns.Add("IsNew", String.Empty);
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
        private void DeleteRow(DataGridView dataGridView)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows[index].Visible = false;

            if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView.Rows[index].Cells[3].Value = RowState.Deleted;
        }

        private void Update(DataGridView dataGridView, string table, string id_table)
        {
            MyWoggi.OpenConnection();

            for (int index = 0; index < dataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView.Rows[index].Cells[2].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from {table} where {id_table} = {id}";
                    var command = new MySqlCommand(deleteQuery, MyWoggi.GetConnection());
                    command.ExecuteNonQuery();
                }
                        

            }
            MyWoggi.CloseConnection();
        }

        private void Change(DataGridView dataGridView, string table)
        {
            var selectedRowIndex = dataGridView.CurrentCell.RowIndex;

            if (table == "animals")
            {
                int animal_id;
                var animal_name = nameAnimal_textbox.Text;
                int species_id;
                int enclosure_id;
                if (dataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    if (int.TryParse(idAnimal_textbox.Text, out animal_id) || int.TryParse(idSpecies_textbox.Text, out species_id) || int.TryParse(idEnclosure_textbox.Text, out enclosure_id))
                    {
                    }
                }
            }
            else if (table == "categories")
            {
                //int category_id = idAnimal_textbox;
                //var category_name = idAnimal_textbox;

            }

            else if (table == "enclosures")
            {
                //int enclosure_id = idAnimal_textbox;
                //var enclosure_name = idAnimal_textbox;
                //int enclosure_size = idAnimal_textbox;
            }

            else if (table == "species")
            {
                //int species_id = idAnimal_textbox;
                //var species_name = idAnimal_textbox;
                //int category_id = idAnimal_textbox;
            }

            else if (table == "visitors")
            {
                //int visitor_id = idAnimal_textbox;
                //var visitor_name = idAnimal_textbox;
                //int ticket_id = idAnimal_textbox;
            }
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            if (dgw == dataGridView1)
            {
                dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), RowState.ModifiedNew);

            }
            else if (dgw == dataGridView2)
            {
                dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);

            }
            else
            {
                dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);

            }
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
            string categoriesQueryString = $"select * from categories";
            string enclosuresQueryString = $"select * from enclosures";
            string speciesQueryString = $"select * from species";
            string visitorsQueryString = $"select * from visitors";

            CreateColumns();
            RefreshDataGrid(dataGridView1, animalsQueryString);
            RefreshDataGrid(dataGridView2, categoriesQueryString);
            RefreshDataGrid(dataGridView3, enclosuresQueryString);
            RefreshDataGrid(dataGridView4, speciesQueryString);
            RefreshDataGrid(dataGridView5, visitorsQueryString);
        }
        public tables()
        {
            InitializeComponent();
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            authTokenFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "authtoken.txt");

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                idAnimal_textbox.Text = row.Cells[0].Value.ToString();
                nameAnimal_textbox.Text = row.Cells[1].Value.ToString();
                typeSpecies_textbox.Text = row.Cells[2].Value.ToString();
                idEnclosure_textbox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                idCategory_textbox.Text = row.Cells[0].Value.ToString();
                nameCategory_textbox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];
                idEnclosure1_textbox.Text = row.Cells[0].Value.ToString();
                nameEnclosure_textbox.Text = row.Cells[1].Value.ToString();
                sizeEnclosure_textbox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[selectedRow];
                idSpecies_textbox.Text = row.Cells[0].Value.ToString();
                nameSpecies_textbox.Text = row.Cells[1].Value.ToString();
                idCategory1_textbox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView5.Rows[selectedRow];
                idVisitor_textbox.Text = row.Cells[0].Value.ToString();
                nameVisitor_textbox.Text = row.Cells[1].Value.ToString();
                idTicket_textbox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void newWrite1_button_Click(object sender, EventArgs e)
        {

        }

        private void deleteWrite1_button_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView1);
        }

        private void changeWrite1_button_Click(object sender, EventArgs e)
        {

        }

        private void saveWrite1_button_Click(object sender, EventArgs e)
        {
            Update(dataGridView1, "animals", "animal_id");
        }

        private void newWrite2_button_Click(object sender, EventArgs e)
        {

        }

        private void deleteWrite2_button_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView2);

        }

        private void changeWrite2_button_Click(object sender, EventArgs e)
        {

        }

        private void saveWrite2_button_Click(object sender, EventArgs e)
        {
            Update(dataGridView2, "categories", "category_id");

        }

        private void newWrite3_button_Click(object sender, EventArgs e)
        {

        }

        private void deleteWrite3_button_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView3);

        }

        private void changeWrite3_button_Click(object sender, EventArgs e)
        {

        }

        private void saveWrite3_button_Click(object sender, EventArgs e)
        {
            Update(dataGridView3, "enclosures", "enclosure_id");

        }

        private void newWrite4_button_Click(object sender, EventArgs e)
        {

        }

        private void deleteWrite4_button_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView4);

        }

        private void changeWrite4_button_Click(object sender, EventArgs e)
        {

        }

        private void saveWrite4_button_Click(object sender, EventArgs e)
        {
            Update(dataGridView4, "species", "species_id");

        }

        private void newWrite5_button_Click(object sender, EventArgs e)
        {

        }

        private void deleteWrite5_button_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView5);

        }

        private void changeWrite5_button_Click(object sender, EventArgs e)
        {

        }

        private void saveWrite5_button_Click(object sender, EventArgs e)
        {
            Update(dataGridView1, "visitors", "visitor_id");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
