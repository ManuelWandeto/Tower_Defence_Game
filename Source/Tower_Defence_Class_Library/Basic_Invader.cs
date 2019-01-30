using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Basic_Invader : Invader
    {
        public Basic_Invader(Path path) : base(path) { }
        public override int Health { get; protected set; } = 2;
    }
}
