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
    }
}
