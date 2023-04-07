using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MyWoggi
{
    public partial class VisitorTable : Form
    {
        Database MyWoggi = new Database();
        int selectedRow;
        string visitorsQueryString = $"select * from visitors";
        private string authToken;


        public VisitorTable()
        {
            InitializeComponent();
            ToolTip tooltip = new ToolTip();

            tooltip.SetToolTip(newWrite_button, "Новая запись");
            tooltip.SetToolTip(deleteWrite_button, "Удалить запись");
            tooltip.SetToolTip(changeWrite_button, "Изменить запись");
            tooltip.SetToolTip(saveWrite_button, "Сохранить запись");
            tooltip.SetToolTip(update_picturebox, "Обновить данные");
            tooltip.SetToolTip(logout_button, "Выйти из аккаунта");
            tooltip.SetToolTip(about_button, "Информация о проекте");
            tooltip.SetToolTip(animalTable_button, "Перейти в таблицу 'Животные'");
            tooltip.SetToolTip(homepage_button, "Перейти на главный экран");
        }

        private void CreateColumns()
        {
            visitors_DatagridView.Columns.Add("visitor_id", "ИД");
            visitors_DatagridView.Columns.Add("visitor_name", "Имя");
            visitors_DatagridView.Columns.Add("visitor_surname", "Фамилия");
            visitors_DatagridView.Columns.Add("visitor_patronymic", "Отчество");
            visitors_DatagridView.Columns.Add("IsNew", String.Empty);
            visitors_DatagridView.Columns["IsNew"].Visible = false;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }


        private void RefreshDataGrid(DataGridView dgw, string queryString)
        {
            dgw.Rows.Clear();
            Reader(dgw, queryString);
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

        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string searchString = $"select * from visitors where concat (visitor_id, visitor_name, visitor_surname, visitor_patronymic) " +
                $"like'%" + search_texbox.Text + "%' ";
            Reader(dwg, searchString);
        }



        private void DeleteRow()
        {
            int index;

            if (visitors_DatagridView.CurrentCell != null)
            {
                index = visitors_DatagridView.CurrentCell.RowIndex;
            }
            else
            {
                MessageBox.Show("Вы не можете удалить пустую ячейку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            visitors_DatagridView.Rows[index].Cells[4].Value = RowState.Deleted;
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
            for (int index = 0; index < visitors_DatagridView.Rows.Count; index++)
            {
                var rowState = (RowState)visitors_DatagridView.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(visitors_DatagridView.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from visitors where visitor_id = '{id}'";

                    bool isDeleted = MyWoggi.DeleteData(deleteQuery);

                    if (!isDeleted)
                    {
                        MessageBox.Show("Ошибка удаления записи", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                if (rowState == RowState.Modified)
                {
                    var idVisitor = visitors_DatagridView.Rows[index].Cells[0].Value.ToString();
                    var nameVisitor = visitors_DatagridView.Rows[index].Cells[1].Value.ToString();
                    var surnameVisitor = visitors_DatagridView.Rows[index].Cells[2].Value.ToString();
                    var patronymicVisitor = visitors_DatagridView.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"update visitors set visitor_name = '{nameVisitor}', visitor_surname = '{surnameVisitor}', visitor_patronymic = '{patronymicVisitor}' where visitor_id = '{idVisitor}'";
                    bool isUpdated = MyWoggi.InsertUpdateData(changeQuery);
                    if (!isUpdated)
                    {
                        MessageBox.Show("Ошибка обновления БД", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }


        private void Change()
        {
            var selectRowIndex = visitors_DatagridView.CurrentCell.RowIndex;

            var idVisitor = idVisitor_textbox.Text;
            var nameVisitor = nameVisitor_textbox.Text;
            var surnameVisitor = surnameVisitor_textbox.Text;
            var patronymicVisitor = patronymicVisitor_textbox.Text;

            if (visitors_DatagridView.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                visitors_DatagridView.Rows[selectRowIndex].SetValues(idVisitor, nameVisitor, surnameVisitor, patronymicVisitor);
                visitors_DatagridView.Rows[selectRowIndex].Cells[4].Value = RowState.Modified;
            }
        }


        private void VisitorTable_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(visitors_DatagridView, visitorsQueryString);
        }

        private void NewWrite_button(object sender, EventArgs e)
        {
            NewVisitor visitor_New = new NewVisitor();
            visitor_New.Show();
        }

        private void DeleteWrite_button(object sender, EventArgs e)
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
            Search(visitors_DatagridView);

        }

        private void UpdatePicturebox_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(visitors_DatagridView, visitorsQueryString);
        }


        private void VisitorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = visitors_DatagridView.Rows[selectedRow];
                TextBox[] textBoxes = { idVisitor_textbox, nameVisitor_textbox, surnameVisitor_textbox, patronymicVisitor_textbox };

                for (int index = 0; index < textBoxes.Length; index++)
                {
                    textBoxes[index].Text = row.Cells[index].Value.ToString();
                }
            }
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void AnimalTable_button_Click(object sender, EventArgs e)
        {
            AnimalTable animalTable = new AnimalTable();
            animalTable.Show();
            this.Hide();
        }

        private void VisitorTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Homepage_button_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
    }
}
