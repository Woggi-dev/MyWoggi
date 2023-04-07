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
    public partial class NewVisitor : Form
    {
        Database MyWoggi = new Database();
        Registration registration = new Registration();
        public NewVisitor()
        {
            InitializeComponent();
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(saveWrite_button, "Сохранить запись");
        }

        private void SaveWrite_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите это сохранить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            VisitorTable visitor = new VisitorTable();
            if (result == DialogResult.Yes)
            {
                var name_visitor = nameVisitor_textbox.Text;
                var surname_visitor = surnameVisitor_textbox.Text;
                var patronymic_visitor = patronymicVisitor_textbox.Text;

                var addQuery = $"insert into visitors (visitor_name, visitor_surname, visitor_patronymic)" +
                    $"values ('{name_visitor}', '{surname_visitor}', '{patronymic_visitor}')";

                bool isSaved = MyWoggi.InsertUpdateData(addQuery);

                if (isSaved)
                {
                    MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ошибка создания записи", "Visitors: SaveWrite_button_Click()", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            this.Hide();
        }
    }
}
