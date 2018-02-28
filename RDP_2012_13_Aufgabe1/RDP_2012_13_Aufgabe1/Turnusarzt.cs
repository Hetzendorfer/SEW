using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_2012_13_Aufgabe1
{
    class Turnusarzt : Arzt
    {
        public int Dauer { get; set; }
        public Turnusarzt(int id, string v, string n, int dauer) : base(id, v, n)
        {
            this.Dauer = dauer;
        }

        public override string ToString()
        {
            string visiten = " Visiten: ";
            foreach (DateTime item in this.visiten)
                visiten += item.ToShortDateString() + " ";
            
            return "Turnusarzt: " + this.Vorname + " " + this.Nachname + visiten + "[" + this.Dauer.ToString() + " Monate]" + "\n";
        }
    }
}
