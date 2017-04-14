using snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //отрисовка рамки

            Console.SetBufferSize(85, 25);
            Console.SetWindowSize(85, 25);

            verticalLine Lline = new verticalLine(80, 0, 24, '+');
            Lline.Draw();

            verticalLine Rline = new verticalLine(0, 0, 24, '+');
            Rline.Draw();

            horizontalLine Uline = new horizontalLine(0, 80, 0, '+');
            Uline.Draw();

            horizontalLine Dline = new horizontalLine(0, 80, 24, '+');
            Dline.Draw();

            //отрисовка точек

            Point p = new Point(40, 5, ')');
            snake snake1 = new snake(p, 5, direction.RIGHT );
            snake1.Draw();

            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake1.HandleKey(key.Key);
                    }
                                       
                    Thread.Sleep(100);
                    snake1.move();

                  //  Console.ReadLine();

                }

            }
        }
    }

