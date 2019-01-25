﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Tower_Defence_Class_Library
{
    public class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow((x - X), 2) + Math.Pow((y - Y), 2)); 

        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
