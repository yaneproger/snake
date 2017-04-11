
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
            
            Point p1 = new Point(15, 1, '*');           
            p1.Draw();

            Point p2 = new Point(15, 2, '*');           
            p2.Draw();

            verticalLine vline = new verticalLine(50, 5, 80, '+');
            vline.Drow();




           horizontalLine line = new horizontalLine(5, 50, 8, '/');
               line.Drow();





            Console.ReadLine();

        }

    }
}
