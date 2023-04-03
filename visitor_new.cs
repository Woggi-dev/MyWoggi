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
    public partial class visitor_new : Form
    {
        Database MyWoggi = new Database();
        public visitor_new()
        {
            InitializeComponent();
        }

        private void saveWrite1_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите это сохранить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            visitor_table visitor = new visitor_table();
            if (result == DialogResult.Yes)
            {
                MyWoggi.OpenConnection();

                var name_animal = nameVisitor_textbox.Text;
                var weight_animal = surnameVisitor_textbox.Text;
                var age_animal = patronymicVisitor_textbox.Text;

                var addQuery = $"insert into visitors (visitor_name, visitor_surname, visitor_patronymic)" +
                    $"values ('{name_animal}', '{weight_animal}', '{age_animal}')";

                var command = new MySqlCommand(addQuery, MyWoggi.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MyWoggi.CloseConnection();
            }
            visitor.Show();
            this.Hide();
        }
    }
}
