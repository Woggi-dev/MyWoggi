using MySql.Data.MySqlClient;
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
    public partial class visitor_table : Form
    {
        Database MyWoggi = new Database();
        int selectedRow;
        private string authToken;


        public visitor_table()
        {
            InitializeComponent();
        }

        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string searchString = $"select * from visitors where concat (visitor_id, visitor_name, visitor_surname, visitor_patronymic) " +
                $"like'%" + search_texbox.Text + "%' ";

            MySqlCommand com = new MySqlCommand(searchString, MyWoggi.GetConnection());

            MyWoggi.OpenConnection();

            MySqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dwg, read);
            }

            read.Close();
        }



        private void deleteRow()
        {
            int index = visitors.CurrentCell.RowIndex;
            visitors.Rows[index].Visible = false;

            if (visitors.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                visitors.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            visitors.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void LogOut()
        {
            Authorization authorization = new Authorization();
            // Получить токен авторизации
            authToken = authorization.ReadAuthToken();
            // Отключить функцию "запомнить меня"
            string rememberMeDisabledQueryString = $"update Userdata set rememberme_user = '0' where authtoken_user = '{authToken}'";
            bool isRememberDisabled = MyWoggi.InsertUpdateData(rememberMeDisabledQueryString);
            // Если отключено успешно
            if (isRememberDisabled)
            {
                authorization.Show();
                this.Hide();
            }
            // Если нет
            else
            {
                MessageBox.Show("Произошла ошибка выхода из аккаунта...", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private new void Update()
        {
            MyWoggi.OpenConnection();
            for (int index = 0; index < visitors.Rows.Count; index++)
            {
                var rowState = (RowState)visitors.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(visitors.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from visitors where visitor_id = '{id}'";

                    var command = new MySqlCommand(deleteQuery, MyWoggi.GetConnection());
                    command.ExecuteNonQuery();

                }
                if (rowState == RowState.Modified)
                {
                    var id_visitor = visitors.Rows[index].Cells[0].Value.ToString();
                    var name_visitor = visitors.Rows[index].Cells[1].Value.ToString();
                    var surname_visitor = visitors.Rows[index].Cells[2].Value.ToString();
                    var patronymic_visitor = visitors.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"update visitors set visitor_name = '{name_visitor}', visitor_surname = '{surname_visitor}', visitor_patronymic = '{patronymic_visitor}' where visitor_id = '{id_visitor}'";
                    var command = new MySqlCommand(changeQuery, MyWoggi.GetConnection());
                    command.ExecuteNonQuery();


                }

            }
            MyWoggi.CloseConnection();
        }


        private void Change()
        {
            var selectRowIndex = visitors.CurrentCell.RowIndex;

            var id_animal = idVisitor_textbox.Text;
            var name_animal = nameVisitor_textbox.Text;
            var weight_animal = surnameVisitor_textbox.Text;
            var age_animal = patronymicVisitor_textbox.Text;

            if (visitors.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                visitors.Rows[selectRowIndex].SetValues(id_animal, name_animal, weight_animal, age_animal);
                visitors.Rows[selectRowIndex].Cells[4].Value = RowState.Modified;
            }
        }

        private void CreateColumns()
        {
            visitors.Columns.Add("visitor_id", "ИД");
            visitors.Columns.Add("visitor_name", "Имя");
            visitors.Columns.Add("visitor_surname", "Фамилия");
            visitors.Columns.Add("visitor_patronymic", "Отчество");
            visitors.Columns.Add("IsNew", String.Empty);
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
        private void visitor_table_Load(object sender, EventArgs e)
        {
            string animalsQueryString = $"select * from visitors";


            CreateColumns();
            RefreshDataGrid(visitors, animalsQueryString);
        }

        private void newWrite1_button_Click(object sender, EventArgs e)
        {
            visitor_new visitor_New = new visitor_new();
            visitor_New.Show();
        }

        private void deleteWrite1_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить это?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                deleteRow();

            }
        }

        private void changeWrite1_button_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void saveWrite1_button_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Search_texBox_TextChanged(object sender, EventArgs e)
        {
            Search(visitors);

        }

        private void update_picturebox_Click(object sender, EventArgs e)
        {
            string animalsQueryString = $"select * from visitors";
            RefreshDataGrid(visitors, animalsQueryString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = visitors.Rows[selectedRow];
                idVisitor_textbox.Text = row.Cells[0].Value.ToString();
                nameVisitor_textbox.Text = row.Cells[1].Value.ToString();
                surnameVisitor_textbox.Text = row.Cells[2].Value.ToString();
                patronymicVisitor_textbox.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
