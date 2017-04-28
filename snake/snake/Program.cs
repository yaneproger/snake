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
            Console.SetBufferSize(80, 25);

            walls walls = new walls(80, 25);
            walls.Draw();

            //отрисовка точек
            Point p = new Point(4, 5, '*');
            snake Snake = new snake(p, 5, direction.RIGHT);
            Snake.Draw();

            foodcreator foodcreator = new foodcreator(80, 25, '$');
            Point food = foodcreator.createfood();
            food.Draw();

            while (true)
              {
              if (walls.IsHit(Snake) || Snake.IsHitTail())
                    {
                        break;
                    }

               if (Snake.eat( food ))
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
                    
                }

           }
      }
}