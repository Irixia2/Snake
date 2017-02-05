using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yBottom, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

    }

}