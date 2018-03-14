using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class MyVectorClass
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int Dimension4 { get; set; }
        public int Dimension5 { get; set; }
        public int Dimension6 { get; set; }
        public int Dimension7 { get; set; }
        public int Dimension8 { get; set; }
        public int Dimension9 { get; set; }
        public int Dimension10 { get; set; }

        public MyVectorClass(int x, int y, int z, int a, int b, int c, int d, int e, int f, int g)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Dimension4 = a;
            this.Dimension5 = b;
            this.Dimension6 = c;
            this.Dimension7 = d;
            this.Dimension8 = e;
            this.Dimension9 = f;
            this.Dimension10 = g;
        }

        public MyVectorClass()
        {

        }

        public void Methode1()
        {
            Console.WriteLine("asd");
        }

        public static MyVectorClass operator +(MyVectorClass left, MyVectorClass right)
        {
            MyVectorClass vector = new MyVectorClass();
            vector.X = left.X + right.X;
            vector.Y = left.Y + right.Y;
            vector.Z = left.Z + right.Z;
            vector.Dimension4 = left.Dimension4 + right.Dimension4;
            vector.Dimension5 = left.Dimension5 + right.Dimension5;
            vector.Dimension6 = left.Dimension6 + right.Dimension6;
            vector.Dimension7 = left.Dimension7 + right.Dimension7;
            vector.Dimension8 = left.Dimension8 + right.Dimension8;
            vector.Dimension9 = left.Dimension9 + right.Dimension9;
            vector.Dimension10 = left.Dimension10 + right.Dimension10;

            return vector;
        }
        public static MyVectorClass operator *(MyVectorClass left, MyVectorClass right)
        {
            MyVectorClass vector = new MyVectorClass();
            vector.X = left.X * right.X;
            vector.Y = left.Y * right.Y;
            vector.Z = left.Z * right.Z;
            vector.Dimension4 = left.Dimension4 * right.Dimension4;
            vector.Dimension5 = left.Dimension5 * right.Dimension5;
            vector.Dimension6 = left.Dimension6 * right.Dimension6;
            vector.Dimension7 = left.Dimension7 * right.Dimension7;
            vector.Dimension8 = left.Dimension8 * right.Dimension8;
            vector.Dimension9 = left.Dimension9 * right.Dimension9;
            vector.Dimension10 = left.Dimension10 * right.Dimension10;

            return vector;
        }
    }
}
