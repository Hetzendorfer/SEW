using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convolution
{
    class SMatrix
    {
        public int[,] Dimension { get; set; }

        public SMatrix(int[,] dimension)
        {
            this.Dimension = dimension;
        }
        public SMatrix()
        {

        }

        public static SMatrix operator *(SMatrix links, SMatrix rechts)
        {
            int[,] arr = new int[links.Dimension.GetLength(0) - rechts.Dimension.GetLength(0) + 1, links.Dimension.GetLength(1) - rechts.Dimension.GetLength(1) + 1];
            

            for (int x = 0; x < arr.GetLength(1); x++)
                for (int y = 0; y < arr.GetLength(0); y++)
                    for (int i = 0; i < rechts.Dimension.GetLength(1); i++)
                        for (int j = 0; j < rechts.Dimension.GetLength(0); j++)
                            arr[y, x] += links.Dimension[y + j, x + i] * rechts.Dimension[j, i];


            SMatrix smatrix = new SMatrix();
            smatrix.Dimension = arr;
            return smatrix;
        }
    }
}
