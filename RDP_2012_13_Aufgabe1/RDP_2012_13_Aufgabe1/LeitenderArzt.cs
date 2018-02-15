using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_2012_13_Aufgabe1
{
    class LeitenderArzt : Arzt, IAktivitaeten
    {
        public Funktion Funktion { get; set; }
        public LeitenderArzt(int id, string v, string n, Funktion f) : base(id, v, n)
        {
            this.Funktion = f;
        }

        public override string ToString()
        {
            string visiten = " Visiten: ";
            foreach (DateTime item in this.visiten)
                visiten += item.ToShortDateString() + " ";

            return this.Funktion + ": " + this.Vorname + " " + this.Nachname + visiten + "\n";
            
        }

        public void operieren()
        {
            throw new NotImplementedException();
        }

        public void PatientAufnehmen()
        {
            throw new NotImplementedException();
        }
    }
}
