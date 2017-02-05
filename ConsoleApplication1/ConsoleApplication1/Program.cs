﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            // Отрисовка рамки

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            leftLine.Draw();
            VerticalLine rigthLine = new VerticalLine(0, 24, 78, '+');
            leftLine.Draw();


            // Отрисовка змейки

            Point p = new Point(4, 3, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            Console.ReadLine();
        }
       
    }
}
