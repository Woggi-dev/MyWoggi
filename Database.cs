using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyWoggi
{
    class Database
    {
        MySqlConnection sqlConnection = new MySqlConnection("Server=sql7.freemysqlhosting.net;Port=3306;Database=sql7609259;Uid=sql7609259;Pwd=em89xPl4pT;");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
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
