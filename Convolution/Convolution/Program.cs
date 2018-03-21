using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convolution
{
    class Program
    {
        static void Main(string[] args)
        {
            SMatrix matrix1 = new SMatrix();
            SMatrix matrix2 = new SMatrix();
            int[,] arr1 = new int[4, 4];
            int[,] arr2 = new int[2, 2];
            Random rnd = new Random();

            Console.WriteLine("Matrix 1: ");
            for (int y = 0; y < arr1.GetLength(1); y++)
            {
                for (int x = 0; x < arr1.GetLength(0); x++)
                {
                    arr1[x, y] = rnd.Next(0, 4);
                    Console.Write(arr1[x, y] + "| ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix 2: ");
            for (int y = 0; y < arr2.GetLength(1); y++)
            {
                for (int x = 0; x < arr2.GetLength(0); x++)
                {
                    arr2[x, y] = 1;
                    Console.Write(arr2[x, y] + "| ");
                }
                Console.WriteLine();
            }

            matrix1.Dimension = arr1;
            matrix2.Dimension = arr2;

            SMatrix asd = matrix1 * matrix2;

            Console.WriteLine("\nResult:");

            for (int y = 0; y < asd.Dimension.GetLength(1); y++)
            {
                for (int x = 0; x < asd.Dimension.GetLength(0); x++)
                {
                    Console.Write(asd.Dimension[x, y] + "|");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
