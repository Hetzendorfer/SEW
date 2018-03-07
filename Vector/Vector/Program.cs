using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector vec4 = new MyVector(1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
            MyVector vec2 = new MyVector(3, 3, 3, 3, 3, 3, 3, 3, 3, 3);

            vec4 += vec2;


            Stopwatch sw = new Stopwatch();
            /*sw.Start();
            MyVector vec1 = new MyVector(1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
            for (int i = 0; i < 1000000; i++)
            {
                MyVector vec3 = new MyVector(2, 2, 2, 2, 2, 2, 2, 2, 2, 2);
                vec1 += vec3;
                vec1 *= vec3;
            }
            sw.Stop(); */

            sw.Start();
            MyVectorClass vecClass1 = new MyVectorClass(1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
            for (int i = 0; i < 1000000; i++)
            {
                MyVectorClass vecClass3 = new MyVectorClass(2, 2, 2, 2, 2, 2, 2, 2, 2, 2);
                vecClass1 += vecClass3;
                vecClass1 *= vecClass3;
            }
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}
