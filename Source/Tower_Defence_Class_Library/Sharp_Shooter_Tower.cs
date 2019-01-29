using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Sharp_Shooter_Tower : Tower
    {
        public Sharp_Shooter_Tower(MapLocation location, Path path) : base(location, path) { }

        protected override double Accuracy { get; } = .90;
    }
}
