using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Fast_Invader : Invader
    {
        public Fast_Invader(Path path) : base(path) { }

        protected override int StepSize { get; } = 2;
    }
}
