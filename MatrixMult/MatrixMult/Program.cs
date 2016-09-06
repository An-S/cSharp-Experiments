using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMult
{
  
    class testMMult
    {
        public double[,] MatrixMult(double[,] a, double[,] b)
        {
            int rows = a.GetLength(0), cols = a.GetLength(1);

            if (cols != b.GetLength(0))
            {
                return new double[0, 0];
            }
            double[,] m = new double[rows, rows];
            for(uint r=0; r<rows;++r)
            {
                for (uint c = 0; c < cols; ++c)
                {
                    double t = 0;
                    for (uint i = 0; i < cols; ++i)
                    { 
                        t += a[r, i] * b[i, r];
                    }
                    m[r, c] = t;
                }
            }
            return m;
        }

        static void Main(string[] args)
        {
            double[,] a = { { 1 }, { 2 } };
            double[,] b = { { 1, 2 } };
            double[,] c = MatrixMult(a, b);

        }
    }
}
