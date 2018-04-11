using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
    class ChildClass : FatherClass
    {
        static ChildClass()
        {
            Console.WriteLine("static ChildClass()");
        }

        public ChildClass()
        {
            Console.WriteLine("public ChildClass()");
        }

        public ChildClass(int i) : this()
        {
            Console.WriteLine("public ChildClass(int i)");
        }

        public new int GibZurück(int i)
        {
            return i;
        }

        public void myString()
        {
            Console.WriteLine("Child");
        }
    }
}
