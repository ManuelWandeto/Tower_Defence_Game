using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Map
    {
        public readonly int Height;
        public readonly int Width;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point) //returns true if a given point is on the map
        {
            return (point.X >= 0 && point.X < Width) && (point.Y >= 0 && point.Y < Height);
        }
    }
}
