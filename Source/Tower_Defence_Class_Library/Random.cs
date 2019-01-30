using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public static class Random
    {
        private static System.Random _Random = new System.Random();

        public static double NextDouble() => _Random.NextDouble();
    }
}
