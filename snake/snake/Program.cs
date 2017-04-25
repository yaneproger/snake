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

            Console.SetBufferSize(100, 100);
            //    Console.SetWindowSize(85, 80);

            horizontalLine Uline = new horizontalLine(0, 70, 0, '-');            
            horizontalLine Dline = new horizontalLine(0, 70, 24, '-');            
            verticalLine Lline = new verticalLine(70, 0, 24, '|');            
            verticalLine Rline = new verticalLine(0, 0, 24, '|');
            
            Uline.Draw();
            Dline.Draw();
            Lline.Draw();
            Rline.Draw();

            //отрисовка точек

            Point p = new Point(4, 5, '*');
            snake Snake = new snake(p, 5, direction.RIGHT);
            Snake.Draw();

            foodcreator foodcreator = new foodcreator(80, 25, '$');
            Point food = foodcreator.createfood();
            food.Draw();

            while (true)
            {   
                if(Snake.eat( food ))
                {
                    food = foodcreator.createfood();
                    food.Draw();
                }
                else
                {
                    Snake.move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snake.handlekey(key.Key);
                }                                                        
                    Thread.Sleep(100);
                    Snake.move();
                }

            }
        }
    }

