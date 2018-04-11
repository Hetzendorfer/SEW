using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
    class Zahl
    {
        public int Value { get; set; }

        public Zahl(int i)
        {
            this.Value = i;
        }

        public static implicit operator Zahl(int i)
        {
            return new Zahl(i);
        }

        public static explicit operator int(Zahl z)
        {
            return z.Value;
        }

        public static int operator |(Zahl z1, Zahl z2)
        {
            return z1.Value | z2.Value;
        }
    }
}
