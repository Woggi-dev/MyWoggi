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
        MySqlConnection sqlConnection = new MySqlConnection("Server=sql7.freemysqlhosting.net;Port=3306;Database=sql7609259;Uid=sql7609259;Pwd=em89xPl4pT;Charset=utf8");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public bool isSuchUser(TextBox loginUser, TextBox passwordUser)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from Userdata where login_user = '{loginUser.Text}' and password_user = '{passwordUser.Text}'";

            MySqlCommand command = new MySqlCommand(querystring, getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
                return false;
        }

        public bool isSuchEmail(TextBox emailUser)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string checkemail_querystring = $"select id_user, email_user from Userdata where email_user = '{emailUser.Text}'";

            MySqlCommand command = new MySqlCommand(checkemail_querystring, getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
                return false;
        }

        public int registerUser(TextBox newnameUser, TextBox newsurnameUser, TextBox newloginUser, TextBox newemailUser, TextBox newpwdUser)
        {
            string checkuser_querystring = $"select id_user, login_user, email_user from Userdata where login_user = '{newloginUser.Text}' or email_user = '{newemailUser.Text}'";
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand checkuser_command = new MySqlCommand(checkuser_querystring, getConnection());
            
            adapter.SelectCommand = checkuser_command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return 0;

            string register_querystring = $"insert into Userdata(login_user, name_user, surname_user, email_user, password_user) " +
                $"VALUES('{newloginUser.Text}', '{newnameUser.Text}', '{newsurnameUser.Text}', '{newemailUser.Text}', '{newpwdUser.Text}')";
            
            MySqlCommand register_command = new MySqlCommand(register_querystring, getConnection());
            openConnection();

            if (register_command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return 1;

            }
            else
            {
                closeConnection();
                return -1;
            }
        }

        public bool updatePwd(string NewPwdRestored, string userEmail)
        {
            string updatepwd_querystring = $" update Userdata set password_user = ( '{NewPwdRestored}') where email_user = '{userEmail}'";
            MySqlCommand command = new MySqlCommand(updatepwd_querystring, getConnection());// связь таблицы и запроса
            openConnection();
            if (command.ExecuteNonQuery() == 1)// при успешном вводе
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
