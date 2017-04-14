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
            snake snake1 = new snake(p, 5, direction.LEFT);
            snake1.Draw();


            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    //   public void handlekey(ConsoleKey but)
                    {
                        if (key.Key == ConsoleKey.LeftArrow)
                            snake1.direction = direction.LEFT;
                        else if (key.Key == ConsoleKey.RightArrow)
                            snake1.direction = direction.RIGHT;
                        else if (key.Key == ConsoleKey.UpArrow)
                            snake1.directon = direction.UP;
                        else if (key.Key == ConsoleKey.DownArrow)
                            snake1.direction = direction.DOWN;
                        
                    }
                                       
                    Thread.Sleep(100);
                    snake1.move();

                  //  Console.ReadLine();

                }

            }
        }
    }
}
