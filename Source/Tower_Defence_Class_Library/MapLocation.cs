using System;
using System.Collections.Generic;
using System.Text;
using Tower_Defence_Class_Library;

namespace Tower_Defence_Class_Library
{
    public class MapLocation : Point // Inherits all non private members of the base class
    {
        public MapLocation(int x, int y, Map map) : base(x,y)
        {
            if(!map.OnMap(this))
            {
                throw new Out_Of_Bounds_Exception("(" + x + ", " + y +")" + " is outside the boundaries of the map");
            }
        }

        public bool InRangeOf(MapLocation location, int range) => DistanceTo(location) <= range;
    }
}
