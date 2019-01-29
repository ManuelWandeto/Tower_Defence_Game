using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Invader
    {
        private int pathStep = 0; //fields are initialised first before the constructor is called
        private readonly Path _path;
        public int health { get; private set; } = 2;
        public MapLocation Location => _path.GetLocationAt(pathStep);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => pathStep++;
        public void DecreaseHealth(int factor) => health -= factor;
        public bool IsNeutralised => health <= 0; //a computed property that returns a value based on the logic defined
        public bool HasScored => pathStep >= (_path.Length);
        public bool IsActive => !(HasScored && IsNeutralised);
    }
}
