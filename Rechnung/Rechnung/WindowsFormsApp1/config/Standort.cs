using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.config
{

    class Standort
    {
        public int ID { get; set; }
        public string Stadt { get; set; }
        public int PLZ { get; set; }
        public string Straße { get; set; }
        public string Hausnummer { get; set; }

        public Standort(int id)
        {
            this.ID = id;
            this.GetFromDB();
        }

        private void GetFromDB()
        {
            DBConnection dBConnection = DBConnection.Instance();
            if (dBConnection.IsConnect())
            {
                string query = string.Format("SELECT standort.STADT, standort.PLZ, standort.STRASSE, standort.HAUSNUMMER FROM standort WHERE standort.ID = {0};", this.ID);
                try
                {
                    var cmd = new MySqlCommand(query, dBConnection.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.Stadt = reader.GetString(0);
                        this.PLZ = reader.GetInt32(1);
                        this.Straße = reader.GetString(2);
                        this.Hausnummer = reader.GetString(3);
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
