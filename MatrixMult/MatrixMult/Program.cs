using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMult
{
  
    class testMMult
    {
        double[,] MatrixMult(double[,] a, double[,] b)
        {
            if (a.GetLength(0) != b.GetLength(1))
            {
                return new double[0, 0];
            }
            double[,] m = new double[a.GetLength(1) * b.GetLength(0), a.GetLength(1) * b.GetLength(0)];
            foreach(double s in a[1])
            {
                foreach(double c in b[0])
                {

                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
