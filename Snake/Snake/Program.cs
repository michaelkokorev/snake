﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            foreach (Point point in pList) point.Draw();

            Console.ReadLine();
        }
    }
}
