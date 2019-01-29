using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Tower
    {
        /* Private Fields Of The Tower Class */
        private readonly MapLocation _Location;
        private static Random _Random = new Random();

        /* Public Properties Of The Tower Class */
        public int range { get; } = 1;
        public int power { get; } = 1;
        public double Accuracy { get; } = .75;
        public bool IsSuccessfulShot => _Random.NextDouble() <= Accuracy;

        /*Public Methods Of The Tower Class */

        public Tower(MapLocation location, Path path)
        {
            //logic that prohibits creating towers on the path

            for(int i = 0; i < path.Length; i++)
            {
                if(location.Y == path.GetLocationAt(i).Y)
                {
                    throw new Tower_On_Path_Exception(string.Format("The tower ({0},{1}) is on the path, towers are not allowed on the path", location.X, location.Y));
                }
            }
            _Location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _Location.InRangeOf(invader.Location, range))
                {
                    if(IsSuccessfulShot)
                    {
                        invader.DecreaseHealth(power);
                        Console.WriteLine(invader.IsNeutralised ? "Shot at and killed the invader" : "Shot at and bruised the invader");
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed the invader");
                    }
                    break;
                }
            }
        }
    }
}
