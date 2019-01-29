using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public abstract class Invader
    {
        protected int pathStep = 0; //fields are initialised first before the constructor is called, private member variables should be fields
        private readonly Path _path;
        protected virtual int StepSize { get; } = 1;
        public virtual int Health { get; protected set; } = 2; // public member variables should be properties
        public MapLocation Location => _path.GetLocationAt(pathStep);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => pathStep += StepSize;
        public virtual void DecreaseHealth(int factor) => Health -= factor;
        public bool IsNeutralised => Health <= 0; //a computed property that returns a value based on the logic defined
        public bool HasScored => pathStep >= (_path.Length);
        public bool IsActive => !(HasScored || IsNeutralised);
    }
}
