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
        public int Length => _path.Length;
        public MapLocation GetLocationAt(int pathStep)
        {
            if (pathStep < _path.Length)
            {
                return _path[pathStep];
            }
            else if (pathStep < 0)
            {
                throw new Tower_Defence_Exception();
            }
            else
            {
                return null;
            }
        }

        public bool IsOnPath(MapLocation location)
        {
            foreach(var PathLocation in _path)
            {
                if (location.Equals(PathLocation))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
