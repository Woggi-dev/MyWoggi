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
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        // Функция проверки "Есть ли такой пользователь в бд"
        public bool IsSuchUser(string loginUser, string passwordUser)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from Userdata " +
                $"where login_user = '{loginUser}' and password_user = '{passwordUser}'";

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

        // Функция проверки "Есть ли такая почта в бд"
        public bool IsSuchEmail(string emailUser)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string checkemail_querystring = $"select id_user, email_user from Userdata where email_user = '{emailUser}'";

            MySqlCommand command = new MySqlCommand(checkemail_querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
                return false;
        }

        // Функция регистрации и проверки "Есть ли уже такой зарегистрированный пользователь"
        public int RegisterUser(string newnameUser, string newsurnameUser, string newloginUser, string newemailUser, string newpwdUser)
        {
            string checkuser_querystring = $"select id_user, login_user, email_user from Userdata " +
                $"where login_user = '{newloginUser}' or email_user = '{newemailUser}'";
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand checkuser_command = new MySqlCommand(checkuser_querystring, GetConnection());
            
            adapter.SelectCommand = checkuser_command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return 0;

            string register_querystring = $"insert into Userdata(login_user, name_user, surname_user, email_user, password_user) " +
                $"VALUES('{newloginUser}', '{newnameUser}', '{newsurnameUser}', '{newemailUser}', '{newpwdUser}')";
            
            MySqlCommand register_command = new MySqlCommand(register_querystring, GetConnection());
            OpenConnection();

            if (register_command.ExecuteNonQuery() == 1)
            {
                CloseConnection();
                return 1;

            }
            else
            {
                CloseConnection();
                return -1;
            }
        }

        // Функция восстановления пароля
        public bool UpdatePwd(string NewPwdRestored, string userEmail)
        {
            string updatepwd_querystring = $" update Userdata set password_user = ( '{NewPwdRestored}') where email_user = '{userEmail}'";
            MySqlCommand command = new MySqlCommand(updatepwd_querystring, GetConnection());// связь таблицы и запроса
            OpenConnection();
            if (command.ExecuteNonQuery() == 1)// при успешном вводе
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
