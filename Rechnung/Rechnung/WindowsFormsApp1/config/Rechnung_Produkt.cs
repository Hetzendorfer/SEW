using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.config
{
    class Rechnung_Produkt
    {
        public int RechnungID { get; set; }
        public Produkt Produkt { get; set; }
        public int Menge { get; set; }
        public decimal Rabatt { get; set; }

        public Rechnung_Produkt(int rechnungID, int produktID)
        {
            this.RechnungID = rechnungID;
            this.Produkt = new Produkt(produktID);
            this.GetFromDB();
        }

        private void GetFromDB()
        {
            DBConnection dBConnection = DBConnection.Instance();
            if (dBConnection.IsConnect())
            {
                string query = string.Format("SELECT rechnung_produkt.MENGE, rechnung_produkt.RABATT FROM rechnung_produkt WHERE rechnung_produkt.RECHNUNG_ID = {0} AND rechnung_produkt.PRODUKT_ID = {1};", this.RechnungID, this.Produkt.ID);
                try
                {
                    var cmd = new MySqlCommand(query, dBConnection.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.Menge = reader.GetInt32(0);
                        this.Rabatt = reader.GetDecimal(1);
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
