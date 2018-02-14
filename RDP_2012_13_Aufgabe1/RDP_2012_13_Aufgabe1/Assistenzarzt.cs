using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_2012_13_Aufgabe1
{
    class Assistenzarzt : Arzt, IAktivitaeten
    {
        public bool AusbildungAbgeschlossen { get; set; }

        public Assistenzarzt(int id, string v, string n, bool aus) : base(id, v, n)
        {
            this.AusbildungAbgeschlossen = aus;
        }

        public void operieren()
        {
            throw new NotImplementedException();
        }

        public void PatientAufnehmen()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Assistenzarzt: " + this.Vorname + " " + this.Nachname + "\n";
        }
    }
}
