using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Convolution;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMatrix()
        {
            SMatrix matrix1 = new SMatrix();
            SMatrix matrix2 = new SMatrix();
            int[,] arr1 = new int[8, 10];
            int[,] arr2 = new int[3, 3];

            Console.WriteLine("Matrix 1: ");
            for (int y = 0; y < arr1.GetLength(1); y++)
            {
                for (int x = 0; x < arr1.GetLength(0); x++)
                {
                    arr1[x, y] = 3;
                    Console.Write(arr1[x, y] + "| ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix 2: ");
            for (int y = 0; y < arr2.GetLength(1); y++)
            {
                for (int x = 0; x < arr2.GetLength(0); x++)
                {
                    arr2[x, y] = 2;
                    Console.Write(arr2[x, y] + "| ");
                }
                Console.WriteLine();
            }

            matrix1.Dimension = arr1;
            matrix2.Dimension = arr2;

            SMatrix asd = matrix1 * matrix2;

            for (int y = 0; y < asd.Dimension.GetLength(1); y++)
            {
                for (int x = 0; x < asd.Dimension.GetLength(0); x++)
                {
                    Console.Write(asd.Dimension[x, y] + "|");
                }
                Console.WriteLine();
            }

            Assert.AreEqual(asd.Dimension.GetLength(0), 6);
            Assert.AreEqual(asd.Dimension.GetLength(1), 8);
        }

    
    }
}
