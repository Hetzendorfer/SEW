using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Übung.data;

namespace Übung
{
    class SQL
    {
        static public bool DeleteAll()
        {
            Datenbank db = Datenbank.GetInstance();
            try
            {
                OleDbCommand cmd = new OleDbCommand("DELETE FROM patient;");
                OleDbCommand cmd2 = new OleDbCommand("DELETE FROM behandlung;");
                OleDbCommand cmd3 = new OleDbCommand("DELETE FROM patientbehandlungen;");
                if (!db.isOpen())
                    db.Open();
                cmd.Connection = db.Connection;
                cmd2.Connection = db.Connection;
                cmd3.Connection = db.Connection;

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        static public List<Patient> ReadPatienten()
        {
            List<Patient> patienten = new List<Patient>();
            Datenbank db = Datenbank.GetInstance();
            //try
            //{
                OleDbCommand cmd = new OleDbCommand("SELECT id, vorname, nachname, svnr FROM patient;");
                cmd.Connection = db.Connection;
                if (!db.isOpen())
                    db.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Patient p = new Patient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    p.Behandlungen = ReadBehandlungen(p.ID);
                    patienten.Add(p);
                }

            //}
            //catch(Exception ex)
            //{

            //}

            return patienten;
        }

        static private List<Behandlung> ReadBehandlungen(long patientID)
        {
            List<Behandlung> behandlungen = new List<Behandlung>();
            Datenbank db = Datenbank.GetInstance();
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT behandlungsid, dauer, datum FROM patientbehandlungen WHERE patientbehandlungen.patientID = " + patientID);
                cmd.Connection = db.Connection;
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id = reader.GetInt32(0);
                    OleDbCommand cmd2 = new OleDbCommand("SELECT bezeichnung FROM behandlung WHERE behandlung.ID =" + id);
                    cmd2.Connection = db.Connection;
                    var row = cmd2.ExecuteScalar();
                    string bezeichnung = Convert.ToString(row);
                    behandlungen.Add(new Behandlung(bezeichnung, reader.GetInt32(1), reader.GetDateTime(2), id));
                }

            }
            catch (Exception ex)
            {

            }
            return behandlungen;
        }
    }
}
