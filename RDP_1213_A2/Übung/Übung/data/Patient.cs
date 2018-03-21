using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Übung.data
{
    class Patient
    {
        public long ID { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string SVNR { get; set; }

        public List<Behandlung> Behandlungen;

        public Patient(long id, string nm, string vn, string svnr)
        {
            this.ID = id;
            this.Nachname = nm;
            this.Vorname = vn;
            this.SVNR = svnr;
            this.Behandlungen = new List<Behandlung>();
        }

        public void SaveToDB(Datenbank db)
        {
            string query = $"INSERT INTO patient (id, nachname, vorname, svnr) VALUES ({this.ID}, '{this.Nachname}', '{this.Vorname}', '{this.SVNR}')";
            OleDbCommand cmd = new OleDbCommand(query, db.Connection);
            cmd.ExecuteScalar();

            foreach (Behandlung item in this.Behandlungen)
            {
                item.SaveToDB(db);
                cmd = new OleDbCommand($"INSERT INTO patientbehandlungen(patientid, behandlungsid, dauer, datum) VALUES ({this.ID}, {item.ID}, '{item.Dauer}', '{item.Datum.ToShortDateString()}')", db.Connection);
                cmd.ExecuteScalar();
            }
        }
    }
}
