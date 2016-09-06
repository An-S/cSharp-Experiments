using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *          ..    x   .... = ....
 *          ..        ....   ....
 *          ..               ....
 *          ..               ....   
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
 
namespace MatrixMult
{
  
    class testMMult
    {
        static public double[,] MatrixMult(ref double[,] a, ref double[,] b)
        {
            int rows = a.GetLength(0), cols = a.GetLength(1);

            if (cols != b.GetLength(0))
            {
                return new double[0, 0];
            }
            double[,] m = new double[rows, rows];
            for(uint r = 0; r < rows; ++r)
            {
                for (uint c = 0; c < rows; ++c)
                {
                    double t = 0;
                    for (uint i = 0; i < cols; ++i)
                    { 
                        t += a[r, i] * b[i, c];
                    }
                    m[r, c] = t;
                }
            }
            return m;
        }

        static void PrintMatrix(ref double[,] m)
        {
            int ccol = Console.CursorLeft;

            for (uint j = 0; j < m.GetLength(0); ++j)
            {
                for (uint i = 0; i < m.GetLength(1); ++i)
                {
                    Console.Write("{0,5:f2}", m[j, i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.CursorLeft = ccol;
            }
            Console.CursorLeft = ccol+m.GetLength(1)*5;
        }

        static void Main(string[] args)
        {
            double[,] a = { { 1 }, { 2 } };
            double[,] b = { { 1, 2 } };
            double[,] c = MatrixMult(ref a, ref b);
            int crow = Console.CursorTop;

            PrintMatrix(ref a);
            Console.CursorTop = crow;
            Console.Write("*");
            PrintMatrix(ref b);
            Console.CursorTop = crow;
            Console.Write("=");
            PrintMatrix(ref c);

            Console.WriteLine();
            Console.WriteLine();

            crow = Console.CursorTop;

            PrintMatrix(ref b);
            Console.CursorTop = crow;
            Console.Write("*");
            PrintMatrix(ref a);
            Console.CursorTop = crow;
            Console.Write("=");
            c = MatrixMult(ref b, ref a);
            PrintMatrix(ref c);

            Console.WriteLine();
            Console.WriteLine();

            crow = Console.CursorTop;

            PrintMatrix(ref a);
            Console.CursorTop = crow;
            Console.Write("*");
            PrintMatrix(ref a);
            Console.CursorTop = crow;
            Console.Write("=");
            c = MatrixMult(ref a, ref a);
            PrintMatrix(ref c);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
