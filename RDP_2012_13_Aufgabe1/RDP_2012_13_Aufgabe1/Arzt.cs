using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_2012_13_Aufgabe1
{
    abstract class Arzt
    {
        public List<DateTime> visiten;

        public int ID { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }

        public Arzt(int id, string v, string n)
        {
            this.ID = id;
            this.Vorname = v;
            this.Nachname = n;
            this.visiten = new List<DateTime>();
        }

        public void Visitieren(DateTime d)
        {
            this.visiten.Add(d);
        }

        public override string ToString()
        {
            return this.ID + " " + this.Vorname + " " + this.Nachname + "\n";
        }


    }
}
