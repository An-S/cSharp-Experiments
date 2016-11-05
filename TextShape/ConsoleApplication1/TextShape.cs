using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextShape
{
    class Shape
    {
        private byte lines; //total number of lines the text object consists of
        private byte linewidth; //width of top most line of text object
        private sbyte leftadd; //inc of first position of text object
        private sbyte lenadd; //inc of length of line
        private byte xstart;

        public Shape(byte height=5, byte width=5, byte xstart=0, sbyte leftadd=0, sbyte lenadd=0)
        {
            lines = height;
            this.linewidth = width;
            this.leftadd = leftadd;
            this.lenadd = lenadd;
            this.xstart = xstart;
        }
        
        public void draw()
        {
            for (byte j = lines; j != 0; --j)
            {
                for (byte i = xstart; i != 0; --i)
                {
                    Console.Write(" ");
                }

                for (byte i = linewidth; i != 0; --i)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();
                xstart = (byte)((sbyte)xstart + leftadd);
                linewidth = (byte)((sbyte)linewidth + lenadd);
            }
            
        }
    }
}
