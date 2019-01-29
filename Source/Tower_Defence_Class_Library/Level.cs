using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public class Level
    {
        private Invader[] _invaders;
        public Tower[] towers { get; set; }
        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool play()
        {
            //run untill all invaders are neutralised or invader reaches the end of the path (scores)
            
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders > 0)
            {
                foreach (Tower tower in towers)
                {
                    //every tower is given a chance to fire at invaders
                    tower.FireOnInvaders(_invaders);
                }
                //count and move invaders that are still active down the path
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if(invader.IsActive)
                    {
                        invader.Move();
                        remainingInvaders++;

                    } else if (invader.HasScored)
                    {
                        //return false if any invader scores
                        return false;
                    }

                }
            }
            //return true if all invaders are neutralised
            return true;
        }
    }
}
