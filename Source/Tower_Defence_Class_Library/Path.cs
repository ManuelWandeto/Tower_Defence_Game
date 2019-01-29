using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Path
    {
        private readonly MapLocation[] _path; //underscore naming convention for private fields
        public Path(MapLocation[] path)
        {
            _path = path;
        }
    }
}
