using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Powerful_Tower : Tower
    {
        public Powerful_Tower(MapLocation location, Path path) : base(location, path) { }
        protected override int power { get; } = 2;
    }
}
