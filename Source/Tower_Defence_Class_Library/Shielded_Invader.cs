using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Shielded_Invader : Invader
    {
        public Shielded_Invader(Path path) : base(path) { }
        private int _Shield = 10;
        public override void DecreaseHealth(int factor)
        {
            Console.WriteLine((_Shield > 0) ? "Shot at shielded invader but bullet was blocked" : "Shot at shielded invader");
            _Shield -= 5;
            if(_Shield <= 0)
            {
                base.DecreaseHealth(factor);
                Console.WriteLine("Shot at and injured a shielded invader");
            }
        }
    }
}
