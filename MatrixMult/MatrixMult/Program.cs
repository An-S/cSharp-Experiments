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
            int arows = a.GetLength(0), acols = a.GetLength(1);
            int brows = b.GetLength(0), bcols = b.GetLength(1);

            if (acols != brows)
            {
                return new double[0, 0];
            }
            double[,] m = new double[arows, bcols];
            for(uint r = 0; r < arows; ++r)
            {
                for (uint c = 0; c < bcols; ++c)
                {
                    double t = 0;
                    for (uint i = 0; i < acols; ++i)
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
            Console.WriteLine();
            Console.WriteLine();

            crow = Console.CursorTop;

            a = new double [,] { { 1 }, { 2 }, { 3 }, { 4} };
            b = new double[,] { { 1, 2, 3 } };

            PrintMatrix(ref a);
            Console.CursorTop = crow;
            Console.Write("*");
            PrintMatrix(ref b);
            Console.CursorTop = crow;
            Console.Write("=");
            c = MatrixMult(ref a, ref b);
            PrintMatrix(ref c);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
