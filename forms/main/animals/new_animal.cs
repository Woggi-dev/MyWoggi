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
    public partial class NewAnimal : Form
    {
        Database MyWoggi = new Database();
        public NewAnimal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            ToolTip tooltip = new ToolTip();

            tooltip.SetToolTip(saveWrite1_button, "Сохранить запись");
        }



        private void SaveWrite_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите это сохранить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var name_animal = nameAnimal_textbox.Text;
                var weight_animal = animalWeight_textbox.Text;
                var age_animal = animalAge_textbox.Text;


                var addQuery = $"insert into animals (animal_name, animal_weight, animal_age)" +
                    $"values ('{name_animal}', '{weight_animal}', '{age_animal}')";

                bool isSaved = MyWoggi.InsertUpdateData(addQuery);

                if (isSaved)
                {
                    MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ошибка создания записи", "Animals: SaveWrite_button_Click()", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            this.Hide();
        }
    }
}
