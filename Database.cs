using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyWoggi
{
    class Database
    {
        // Установка соединение с удаленной базой данных
        MySqlConnection sqlConnection = new MySqlConnection("Server=sql7.freemysqlhosting.net;Port=3306;Database=sql7609259;Uid=sql7609259;Pwd=em89xPl4pT;Charset=utf8");

        // Открыть связь с базой данных
        public void OpenConnection()
        {
            // Если состояние подключения - закрытое
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        // Выбрать данные из базы данных
        public bool SelectData(string querystring)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
                return false;
        }

        // Вставить или обновить данные в базе данных
        public bool InsertUpdateData(string querystring)
        {
            MySqlCommand command = new MySqlCommand(querystring, GetConnection());
            OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                CloseConnection();
                return true;

            }
            else
            {
                CloseConnection();
                return false;
            }
        }

        // Закрыть связь с базой данных
        public void CloseConnection()
        {
            // Если состояние бд - открытое
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // Вернуть соединение с базой данных
        public MySqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
