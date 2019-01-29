using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Long_Range_Tower : Tower
    {
        public Long_Range_Tower(MapLocation location, Path path) : base(location, path) { }

        protected override int range { get; } = 3;
    }
}
