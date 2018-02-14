using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_2012_13_Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Abteilung a = new Abteilung(1, "asd");
            a.arztHinzufügen(new LeitenderArzt(1, "1", "1", Funktion.Oberarzt));
            a.arztHinzufügen(new LeitenderArzt(3, "Stv", "Stv", Funktion.Oberarzt_Stv));
            a.arztHinzufügen(new Turnusarzt(2, "2", "2", 123));
            Console.WriteLine(a.ToString()); */

            Abteilung hno = new Abteilung(1, "HNO");
            Turnusarzt t1 = new Turnusarzt(201, "Anton", "Turner", 10);
            Turnusarzt t2 = new Turnusarzt(202, "Theresa", "Turing", 6);
            t2.Visitieren(DateTime.Parse("12.12.2012"));
            t2.Visitieren(DateTime.Parse("13.12.2012"));
            Turnusarzt t3 = new Turnusarzt(203, "Fritz", "Azubius", 12);
            LeitenderArzt prim = new LeitenderArzt(4711, "Ferdinand", "Jünger", Funktion.Primarius);
            LeitenderArzt ober = new LeitenderArzt(815, "Stephanie", "Hogan", Funktion.Oberarzt);
            LeitenderArzt oberstv = new LeitenderArzt(915, "Edith", "Ganz", Funktion.Oberarzt_Stv);
            ober.Visitieren(DateTime.Parse("12.12.2012"));
            ober.Visitieren(DateTime.Parse("13.12.2012"));
            Assistenzarzt ass1 = new Assistenzarzt(111, "Isabella", "Mayer", true);
            Assistenzarzt ass2 = new Assistenzarzt(111, "Werner", "Hochmut", false);
            hno.arztHinzufuegen(t1);
            hno.arztHinzufuegen(t2);
            hno.arztHinzufuegen(t3);
            hno.arztHinzufuegen(oberstv);
            hno.arztHinzufuegen(ober);
            hno.arztHinzufuegen(prim);
            hno.arztHinzufuegen(ass1);
            hno.arztHinzufuegen(ass2);
            Console.WriteLine(hno);

            Console.ReadLine();
        }
    }
}
