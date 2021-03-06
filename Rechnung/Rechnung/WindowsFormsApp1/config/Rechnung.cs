﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.config
{
    class Rechnung
    {
        public int ID { get; set; }
        public Unternehmen Unternehmen { get; set; }
        public Käufer Käufer { get; set; }
        public List<Rechnung_Produkt> Rechnung_Produkte { get; set; }

        public Rechnung(int id)
        {
            this.ID = id;
            this.Rechnung_Produkte = new List<Rechnung_Produkt>();
            this.GetFromDB();
        }

        private void GetFromDB()
        {
            DBConnection dBConnection = DBConnection.Instance();
            if (dBConnection.IsConnect())
            {
                string query = string.Format("SELECT rechnung.UNTERNEHMENS_DATEN_ID, rechnung.KLIENT_ID FROM rechnung WHERE rechnung.ID = {0}", this.ID);
                try
                {
                    var cmd = new MySqlCommand(query, dBConnection.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.Unternehmen = new Unternehmen(reader.GetInt32(0));
                        this.Käufer = new Käufer(reader.GetInt32(1));
                    }

                    dBConnection.IsConnect();
                    query = string.Format("SELECT rechnung_produkt.RECHNUNG_ID, rechnung_produkt.PRODUKT_ID FROM rechnung_produkt WHERE rechnung_produkt.RECHNUNG_ID = {0};", this.ID);
                    cmd = new MySqlCommand(query, dBConnection.Connection);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.Rechnung_Produkte.Add(new Rechnung_Produkt(reader.GetInt32(0), reader.GetInt32(1)));
                    }
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
