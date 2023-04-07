using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
    public partial class AnimalTable : Form
    {
        Authorization authorization = new Authorization();
        Database MyWoggi = new Database();
        int selectedRow;
        string animalsQueryString = $"select * from animals";
        private string authToken;



        private void CreateColumns()
        {
            animals_DataGridView.Columns.Add("animal_id", "ИД животного");
            animals_DataGridView.Columns.Add("animal_name", "Имя животного");
            animals_DataGridView.Columns.Add("animal_weight", "Вес животного");
            animals_DataGridView.Columns.Add("animal_age", "Возраст животного");
            animals_DataGridView.Columns.Add("IsNew", String.Empty);
            animals_DataGridView.Columns["IsNew"].Visible = false;

        }

        private void Reader(DataGridView dwg, string queryString)
        {
            MySqlCommand com = new MySqlCommand(queryString, MyWoggi.GetConnection());

            MyWoggi.OpenConnection();

            MySqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dwg, read);
            }

            read.Close();
        }


        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }


        private void RefreshDataGrid(DataGridView dgw, string queryString)
        {
            dgw.Rows.Clear();

            Reader(dgw, queryString);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            Label label1 = new Label() { Text = "Животные" };
            label1.Dock = DockStyle.Fill;

            string animalsQueryString = $"select * from animals";


            CreateColumns();
            RefreshDataGrid(animals_DataGridView, animalsQueryString);

        }
        public AnimalTable()
        {
            InitializeComponent();
            ToolTip tooltip = new ToolTip();

            tooltip.SetToolTip(newWrite1_button, "Новая запись");
            tooltip.SetToolTip(deleteWrite1_button, "Удалить запись");
            tooltip.SetToolTip(changeWrite1_button, "Изменить запись");
            tooltip.SetToolTip(saveWrite1_button, "Сохранить запись");
            tooltip.SetToolTip(update_picturebox, "Обновить данные");
            // Set the height of the tab page switch

        }
        //закрытие формы
        private void AnimalTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //переход в Home
        private void Homepage_button_Click(object sender, EventArgs e)
        {
            Homepage main = new Homepage();
            main.Show();
            this.Hide();
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

        private void UpdatePicturebox_Click(object sender, EventArgs e)
        {
            string animalsQueryString = $"select * from animals";
            RefreshDataGrid(animals_DataGridView, animalsQueryString);
        }


        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string searchString = $"select * from animals where concat (animal_id, animal_name, animal_weight, animal_age) " +
                $"like'%" + Search_texBox.Text + "%' ";

            Reader(dwg, searchString);

        }



        private void DeleteRow()
        {
            int index = -1;

            if (animals_DataGridView.CurrentCell != null)
            {
                index = animals_DataGridView.CurrentCell.RowIndex;
            }
            else
            {
                MessageBox.Show("Вы не можете удалить пустую ячейку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            animals_DataGridView.Rows[index].Visible = false;

            if (animals_DataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                animals_DataGridView.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            animals_DataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
        }


        private new void Update()
        {
            for (int index = 0; index < animals_DataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)animals_DataGridView.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(animals_DataGridView.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from animals where animal_id = '{id}'";

                    bool isDeleted = MyWoggi.DeleteData(deleteQuery);

                    if (!isDeleted)
                    {
                        MessageBox.Show("Ошибка удаления записи", "Update()", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                if (rowState == RowState.Modified)
                {
                    var id_animal = animals_DataGridView.Rows[index].Cells[0].Value.ToString();
                    var name_animal = animals_DataGridView.Rows[index].Cells[1].Value.ToString();
                    var weight_animal = animals_DataGridView.Rows[index].Cells[2].Value.ToString();
                    var age_animal = animals_DataGridView.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"update animals set animal_name = '{name_animal}', animal_weight = '{weight_animal}', animal_age = '{age_animal}' where animal_id = '{id_animal}'";
                    bool isUpdated = MyWoggi.InsertUpdateData(changeQuery);

                    if (!isUpdated)
                    {
                        MessageBox.Show("Ошибка обновления базы данных", "Update()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }
        }
        private void Change()
        {
            var selectRowIndex = animals_DataGridView.CurrentCell.RowIndex;

            var idAnimal = idAnimal_textbox.Text;
            var nameAnimal = nameAnimal_textbox.Text;
            var weightAnimal = animalWeight_textbox.Text;
            var ageAnimal = animalAge_textbox.Text;

            if (animals_DataGridView.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                animals_DataGridView.Rows[selectRowIndex].SetValues(idAnimal, nameAnimal, weightAnimal, ageAnimal);
                animals_DataGridView.Rows[selectRowIndex].Cells[4].Value = RowState.Modified;
            }
        }


        private void Logout_button_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void NewWrite_button_Click(object sender, EventArgs e)
        {
            NewAnimal add_New_Data = new NewAnimal();
            add_New_Data.Show();
        }

        private void DeleteWrite_button_Click(object sender, EventArgs e)
        {
            DeleteRow();

        }

        private void ChangeWrite_button_Click(object sender, EventArgs e)
        {
            Change();

        }

        private void SaveWrite_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Update();
            }

        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            Search(animals_DataGridView);

        }


        private void About_Button(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }

        private void DatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = animals_DataGridView.Rows[selectedRow];
                TextBox[] textBoxes = { idAnimal_textbox, nameAnimal_textbox, animalWeight_textbox, animalAge_textbox };

                for (int index = 0; index < textBoxes.Length; index++)
                {
                    textBoxes[index].Text = row.Cells[index].Value.ToString();
                }
            }
        }

        private void Visitors_button_Click(object sender, EventArgs e)
        {
            VisitorTable visitorTable = new VisitorTable();
            visitorTable.Show();
            this.Hide();
        }

        private void update_picturebox_Click(object sender, EventArgs e)
        {
            string animalsQueryString = $"select * from animals";
            RefreshDataGrid(animals_DataGridView, animalsQueryString);
        }
    }
}
