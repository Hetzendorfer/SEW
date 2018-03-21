using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Übung
{
    class Datenbank
    {
        private static Datenbank instance;

        public OleDbConnection Connection { get; private set; }

        private Datenbank()
        {
            this.Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Transfer.accdb;Persist Security Info=False;");
        }

        static public Datenbank GetInstance()
        {
            if (instance == null)
            {
                instance = new Datenbank();
            }
            return instance;
        }



        public void Open()
        {
            this.Connection.Open();
        }

        public void Close()
        {
            this.Connection.Close();
        }


    }
}
