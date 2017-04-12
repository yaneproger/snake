
using snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main( string[] args)
        {
             Console.SetBufferSize(80, 80);

            verticalLine Lline = new verticalLine(50, 0, 24, '+');
              Lline.Drow();

            verticalLine Rline = new verticalLine(0, 0, 24, '+');
              Rline.Drow();

            horizontalLine Uline = new horizontalLine(0, 50, 0, '+');
              Uline.Drow();

            horizontalLine Dline = new horizontalLine(0, 50, 24, '+');
              Dline.Drow();

            Point p = new Point(5, 5, '*');
            p.Draw();


            Console.ReadLine();

        }

    }
}
