using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            rightLine.Draw();


            // Отрисовка змейки

            Point p = new Point(4, 3, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
           
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);                
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
       
    }
}
