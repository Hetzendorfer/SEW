using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
    class GrandFather
    {
        static GrandFather()
        {
            Console.WriteLine("static GrandFather()");
        }
        public GrandFather()
        {
            Console.WriteLine("public GrandFather()");
        }
    }
}
