using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Resurrecting_Invader : IInvader
    {
        public MapLocation Location => (reincarnation_1.IsNeutralised) ? reincarnation_2.Location : reincarnation_1.Location;

        public bool IsNeutralised => reincarnation_1.IsNeutralised && reincarnation_2.IsNeutralised; 

        public bool HasScored => reincarnation_1.HasScored || reincarnation_2.HasScored;

        public bool IsActive => !(IsNeutralised || HasScored);

        private Basic_Invader reincarnation_1;

        private Strong_Invader reincarnation_2;

        public int Health => (reincarnation_1.IsNeutralised) ? reincarnation_2.Health : reincarnation_1.Health;


        public Resurrecting_Invader(Path path)
        {
            reincarnation_1 = new Basic_Invader(path);
            reincarnation_2 = new Strong_Invader(path);
        }
        
        
        public void DecreaseHealth(int factor)
        {
            if (reincarnation_1.IsNeutralised)
            {
                Console.WriteLine("Shot at the second reicarnation of a resurrecting invader");
                reincarnation_2.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at the first reicarnation of a resurrecting invader");
                reincarnation_1.DecreaseHealth(factor);
            }
            
        }
        public void Move()
        {
            reincarnation_1.Move();
            reincarnation_2.Move();
        }

    }
}
