using System;
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
        public override bool Equals(object obj)
        {
            if(obj is Point)
            {
                Point that = (Point)obj;
                if(X == that.X && Y == that.Y)
                {
                    return true;
                }
            }
            return false;
            
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("{0}{1},{2}{3}", "(", X, Y , ")");
        }
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
