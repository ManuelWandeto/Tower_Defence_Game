using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Loaded_Tower : Tower
    {
        private int ammunition = 3;
        public Loaded_Tower(MapLocation location, Path path) : base(location, path) { }

        public override void FireOnInvaders(IInvader[] invaders)
        {
            int remainingAmmunition = ammunition;
            for(int i = 1; i <= ammunition; i++)
            {
                base.FireOnInvaders(invaders);
                remainingAmmunition -= 1;
                Console.WriteLine("Loaded tower shot {0} rounds, remaining rounds {1}", i , remainingAmmunition);
            }
            ammunition = 0;
        }


    }
}
