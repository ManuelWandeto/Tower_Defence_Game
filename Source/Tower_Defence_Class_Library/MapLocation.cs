using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x,y)
        {
            if(!map.OnMap(this))
            {
                throw new Exception("This point is not on the map");
            }
        }
    }
}
