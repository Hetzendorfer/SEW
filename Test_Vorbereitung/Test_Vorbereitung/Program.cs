using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex comp = 3;
            Console.WriteLine(String.Format("{0}{1}", "Ergebnis des casten: ", (double)comp));

            Complex comp2 = new Complex(5, 4);

            Complex comp3 = comp + comp2;
            Console.WriteLine(String.Format("{0}, {1}", comp3.Real.ToString(), comp3.Imaginary));


            Zahl z1 = 4;
            Zahl z2 = 1;
            Console.WriteLine(z1 | z2 );

            ChildClass c = new ChildClass(2);

            FatherClass f = new ChildClass();

            f.myString();
            

            Console.ReadLine();
        }
    }
}
