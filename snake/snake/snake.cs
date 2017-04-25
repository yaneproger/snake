using snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake : figure
    {
                
        direction direction;

        public snake(Point tail, int lenght, direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();

            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                pList.Add(p);
            }

        }

        internal void move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = getnextpoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point getnextpoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.move(1, direction);
            return nextPoint;
        }
       
        public void handlekey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = direction.UP;
            else if (key == ConsoleKey.UpArrow)
                direction = direction.DOWN;

        }

        internal bool eat(Point food)
        {
            Point head = getnextpoint();
            if ( head.IsHit(food) )
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
