using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.config
{
    class Käufer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Standort Standort { get; set; }
        public Bankverbindung Bankverbindung { get; set; }

        public Käufer(int id)
        {
            this.ID = id;
            this.GetFromDB();
        }

        private void GetFromDB()
        {
            DBConnection dBConnection = DBConnection.Instance();
            if (dBConnection.IsConnect())
            {
                string query = string.Format("SELECT klient.NAME, klient.STANDORT_ID, klient.BANKVERBINDUNG_ID FROM klient WHERE klient.ID = {0};", this.ID);
                try
                {
                    var cmd = new MySqlCommand(query, dBConnection.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.Name = reader.GetString(0);
                        this.Standort = new Standort(reader.GetInt32(1));
                        this.Bankverbindung = new Bankverbindung(reader.GetInt32(2));
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
