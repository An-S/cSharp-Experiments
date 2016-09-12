using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextShape
{
    class testTextShape
    {
        static void Main(string[] args)
        {
            Shape shp = new Shape(5, 10);
            shp.draw();
            Console.WriteLine();
            shp = new Shape(10, 10, 5, 1, -1);
            shp.draw();
            Console.WriteLine();
            shp = new Shape(10, 1, 9, -1, 2);
            shp.draw();
            Console.WriteLine();
            shp = new Shape(10, 19, 0, 1, -2);
            shp.draw();
        }
    }
}
