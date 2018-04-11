using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
    struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        static Complex()
        {
            Console.WriteLine("static Complex()");
        }

        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public static Complex operator +(Complex comp1, Complex comp2)
        {
            comp1.Real += comp2.Real;
            comp1.Imaginary += comp2.Imaginary;

            return comp1;
        }
        
        public static implicit operator Complex(double real)
        {
            Complex comp = new Complex();
            comp.Real = real;
            return comp;
        }

        public static explicit operator double(Complex comp)
        {
            return comp.Real;
        }



    }
}
