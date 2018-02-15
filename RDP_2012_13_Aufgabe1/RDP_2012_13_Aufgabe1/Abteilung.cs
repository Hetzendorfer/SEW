using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_2012_13_Aufgabe1
{
    class Abteilung
    {
        public List<Arzt> arztListe;

        public int ID { get; set; }
        public string Bezeichnung { get; set; }

        public Abteilung(int id, string b)
        {
            this.ID = id;
            this.Bezeichnung = b;
            this.arztListe = new List<Arzt>();
        }

        public void arztHinzufuegen(Arzt a)
        {
            this.arztListe.Add(a);
        }

        public override string ToString()
        {

            this.arztListe.Sort(delegate(Arzt x, Arzt y)
            {
                Type t1 = x.GetType();
                Type t2 = y.GetType();
                if (t1 == typeof(LeitenderArzt) && t2 == typeof(LeitenderArzt))
                {
                    return ((LeitenderArzt)x).Funktion.CompareTo(((LeitenderArzt)y).Funktion);
                }
                else if (t1 == typeof(LeitenderArzt) && t2 == typeof(Assistenzarzt))
                    return -1;
                else if (t1 == typeof(LeitenderArzt) && t2 != typeof(Assistenzarzt))
                    return -1;
                else if (t1 != typeof(LeitenderArzt) && t2 == typeof(Assistenzarzt))
                    return 1;
                else if (t1 == typeof(LeitenderArzt) && t2 == typeof(Turnusarzt))
                    return 1;
                else if (t1 != typeof(LeitenderArzt) && t2 == typeof(Turnusarzt))
                    return -1;
                else if (t1 == typeof(Assistenzarzt) && t2 == typeof(Turnusarzt))
                    return 1;
                else if (t1 != typeof(Assistenzarzt) && t2 == typeof(Turnusarzt))
                    return -1;

                return 0;
            });

            string s = "Abteilung: " + this.Bezeichnung + "\nÄrzteteam: \n\n" ;

            foreach (var item in this.arztListe)
            {
                s += item.ToString();
            }

            return s;
        }
    }
}
