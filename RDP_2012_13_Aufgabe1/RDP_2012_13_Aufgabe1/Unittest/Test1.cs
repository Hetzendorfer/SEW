using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RDP_2012_13_Aufgabe1.Unittest
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void SortTest()
        {
            Turnusarzt t = new Turnusarzt(1, "Muamemr", "Keskin", 10);
            LeitenderArzt l = new LeitenderArzt(2, "Kevin", "Hetzendorfer", Funktion.Oberarzt);
            Turnusarzt t2 = new Turnusarzt(1, "Muamemr2", "Keskin2", 10);
            LeitenderArzt l2 = new LeitenderArzt(4, "Nico", "Windtner", Funktion.Oberarzt_Stv);
            Assistenzarzt a = new Assistenzarzt(3, "Bernhard", "Traschl", true);
            Assistenzarzt a2 = new Assistenzarzt(3, "Bernhard2", "Traschl2", true);

            Abteilung ab = new Abteilung(1, "IT");
            ab.arztHinzufuegen(t);
            ab.arztHinzufuegen(t2);
            ab.arztHinzufuegen(l);
            ab.arztHinzufuegen(a);
            ab.arztHinzufuegen(a2);
            ab.arztHinzufuegen(l2);



            Console.WriteLine(ab.ToString());
            Assert.AreEqual(ab.arztListe[0], l);
        }

        [TestMethod]
        public void Visiten()
        {
            LeitenderArzt l = new LeitenderArzt(2, "Kevin", "Hetzendorfer", Funktion.Oberarzt);
            l.Visitieren(DateTime.Parse("12.12.2012"));
            l.Visitieren(DateTime.Parse("12.12.2011"));
            l.Visitieren(DateTime.Parse("12.12.2010"));
            string date = l.visiten[0].ToShortDateString();
            Assert.AreEqual(date, "12.12.2012");
        }
    }
}
