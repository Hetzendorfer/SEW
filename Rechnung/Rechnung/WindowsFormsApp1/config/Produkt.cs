using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.config
{
    class Produkt
    {
        public int ID { get; set; }
        public int Preis { get; set; }
        public string Name { get; set; }
        public decimal UST { get; set; }

        public Produkt(int id)
        {
            this.ID = id;
            this.GetFromDB();
        }

        private void GetFromDB()
        {
            DBConnection dBConnection = DBConnection.Instance();
            if (dBConnection.IsConnect())
            {
                string query = string.Format("SELECT produkt.Preis, produkt.Name, produkt.UST FROM produkt WHERE produkt.ID = {0};", this.ID);
                try
                {
                    var cmd = new MySqlCommand(query, dBConnection.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.Preis = reader.GetInt32(0);
                        this.Name = reader.GetString(1);
                        this.UST = reader.GetDecimal(2);
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
