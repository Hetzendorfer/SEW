using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.config
{
    class Unternehmen
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Telefon { get; set; }
        public string FAX { get; set; }
        public string EMail { get; set; }

        public string UID { get; set; }
        public string Firmenbuchnummer { get; set; }

        public Standort Standort { get; set; }
        public Bankverbindung Bankverbindung { get; set; }

        public Unternehmen(int id)
        {
            this.ID = id;
            this.GetFromDB();
        }

        private void GetFromDB()
        {
            DBConnection dBConnection = DBConnection.Instance();
            if (dBConnection.IsConnect())
            {
                string query = string.Format("SELECT unternehmens_daten.NAME, unternehmens_daten.EMAIL, unternehmens_daten.TELEFON, unternehmens_daten.FAX, unternehmens_daten.UID, unternehmens_daten.FIRMENBUCHNUMMER, unternehmens_daten.STANDORT_ID, unternehmens_daten.BANKVERBINDUNG_ID FROM unternehmens_daten WHERE unternehmens_daten.ID = {0}; ", this.ID);
                try
                {
                    var cmd = new MySqlCommand(query, dBConnection.Connection);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.Name = reader.GetString(0);
                        this.EMail = reader.GetString(1);
                        this.Telefon = reader.GetString(2);
                        this.FAX = reader.GetString(3);
                        this.UID = reader.GetString(4);
                        this.Firmenbuchnummer = reader.GetString(5);
                        this.Standort = new Standort(reader.GetInt32(6));
                        this.Bankverbindung = new Bankverbindung(reader.GetInt32(7));
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
