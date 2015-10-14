using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine dowmLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            upLine.Draw();
            dowmLine.Draw();
            leftLine.Draw();
            rightLine.Draw();



            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            foreach (Point point in pList) point.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Draw();

            Console.ReadLine();
        }
    }
}
