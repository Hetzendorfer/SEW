using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.config
{
    public class Bankverbindung
    {
        public int ID { get; set; }
        public string Bankname { get; set; }
        public string BLZ { get; set; }
        public string Kontonummer { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }

        public Bankverbindung(int id)
        {
            this.ID = id;
            this.GetFromDB();
        }

        private void GetFromDB()
        {
            DBConnection dBConnection = DBConnection.Instance();
            if (dBConnection.IsConnect())
            {
                string query = string.Format("SELECT bankverbindung.BANKNAME, bankverbindung.BLZ, bankverbindung.KONTONUMMER, bankverbindung.IBAN, bankverbindung.BIC FROM bankverbindung WHERE bankverbindung.ID = {0};", this.ID);
                try
                {
                    var cmd = new MySqlCommand(query, dBConnection.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.Bankname = reader.GetString(0);
                        this.BLZ = reader.GetString(1);
                        this.Kontonummer = reader.GetString(2);
                        this.IBAN = reader.GetString(3);
                        this.BIC = reader.GetString(4);
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