using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Übung.data;

namespace Übung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Patient p = new Patient(8, "Hetzendorfer", "Kevin", "123456");
            Behandlung b = new Behandlung("Kur", 100, DateTime.Now);
            p.Behandlungen.Add(b);
            Datenbank db = Datenbank.GetInstance();
            db.Open();
            p.SaveToDB(db);
            db.Close();
        }
    }
}
