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
        public snake(Point tail, int lenght, direction direction)
        {
            pList = new List<Point>();

            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                pList.Add(p);
            }

        }

    }
}
