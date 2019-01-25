using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Tower_Defence_Exception : Exception
    {
        public Tower_Defence_Exception() { }
        public Tower_Defence_Exception(string ErrorMessage): base(ErrorMessage) { }
    }

    public class Out_Of_Bounds_Exception : Tower_Defence_Exception
    {
        public Out_Of_Bounds_Exception() { } //automatically calls the base() default constructor
        public Out_Of_Bounds_Exception(string ErrorMessage) : base(ErrorMessage) { }
    }
}
