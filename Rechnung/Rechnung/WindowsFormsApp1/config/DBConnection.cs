using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.config
{
    public class DBConnection
    {
        private DBConnection()
        {
        }

        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public MySqlConnection Connection { get; private set; }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null || Connection.State == System.Data.ConnectionState.Closed || true)
            {
                if (String.IsNullOrEmpty(DatabaseName))
                    return false;
                string connstring = string.Format("Server=localhost; database={0}; UID={1}; password={2}", this.DatabaseName, this.Username, this.Password);
                this.Connection = new MySqlConnection(connstring);
                this.Connection.Open();
            }

            return true;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
