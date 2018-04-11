using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
    class FatherClass : GrandFather
    {

        static FatherClass()
        {
            Console.WriteLine("static FatherClass()");
        }
        public FatherClass()
        {
            Console.WriteLine("public FatherClass()");
        }

        public virtual int GibZurück(int i)
        {
            return i + 4;
        }

        public void myString()
        {
            Console.WriteLine("Fatehr");
        }
    }
}
