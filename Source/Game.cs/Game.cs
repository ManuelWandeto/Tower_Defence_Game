using System;
using Tower_Defence_Class_Library;
namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            try
            {
                Path path = new Path(new[] {
                    new MapLocation(0,2, map),
                    new MapLocation(1,2, map),
                    new MapLocation(2,2, map),
                    new MapLocation(3,2, map),
                    new MapLocation(4,2, map),
                    new MapLocation(5,2, map),
                    new MapLocation(6,2, map),
                    new MapLocation(7,2, map)
                });

                IInvader[] invaders =
                {
                    new Resurrecting_Invader(path),
                    new Fast_Invader(path),
                    new Resurrecting_Invader(path),
                    new Shielded_Invader(path)
                };
                
                Level level_1 = new Level(invaders)
                {
                    towers = new ITower[]
                    {
                        new Powerful_Tower(new MapLocation(3,3, map), path),
                        new Long_Range_Tower(new MapLocation(4,3, map), path),
                        new Sharp_Shooter_Tower(new MapLocation(5,3, map), path),
                        new Loaded_Tower(new MapLocation(1,3, map), path)
                    }
                };
                Console.WriteLine(level_1.play() ? "You have won" : "you have lost");
                
            }
            
            catch(Out_Of_Bounds_Exception ex) //The ex variable declared as a method level variable is initialised with the exception object thrown, 
                                              // i.e Exception ex = new Exception("(" + x + ", " + y +")" + " is outside the boundaries of the map");
            {
                Console.WriteLine(ex.Message);
            }
            catch(Tower_On_Path_Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Tower_Defence_Exception ex)
            {
                Console.WriteLine("Unhandled tower defence exception: {0}", ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unhandled exception: {0}", ex);
            }
        }
    }
}
