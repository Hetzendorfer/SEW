using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Übung.data
{
    class Behandlung
    {
        public long ID { get; set; }
        public string Bezeichnung { get; set; }
        public int Dauer { get; set; }
        public DateTime Datum { get; set; }

        public Behandlung(string bezeichnung, int dauer, DateTime datum)
        {
            this.Bezeichnung = bezeichnung;
            this.Dauer = dauer;
            this.Datum = datum;
        }

        public void SaveToDB(Datenbank db)
        {
            OleDbCommand getMaxID = new OleDbCommand("SELECT MAX(id) as id from behandlung");
            getMaxID.Connection = db.Connection;
            var id = getMaxID.ExecuteScalar();
            this.ID = id.GetType() == typeof(int)? (int)id + 1 : 1;
            OleDbCommand cmd = new OleDbCommand($"INSERT INTO behandlung (id, bezeichnung) VALUES ({this.ID}, '{this.Bezeichnung}')");
            cmd.Connection = db.Connection;
            var anzahl = cmd.ExecuteScalar();
        }
    }
}
