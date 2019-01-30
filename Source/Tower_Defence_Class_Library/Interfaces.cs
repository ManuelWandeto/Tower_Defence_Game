using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_Defence_Class_Library
{
    public interface ITower
    {
        void FireOnInvaders(IInvader[] invaders);
    }

    public interface IMappable
    {
        MapLocation Location { get; }
    }
    
    public interface IMovable
    {
        void Move();
    }
    public interface IInvader : IMappable, IMovable //intefaces define what public properties and methods are and what their return types are
    {
        int Health { get; }
        void DecreaseHealth(int factor);
        bool IsNeutralised { get; } //a computed property that returns a value based on the logic defined
        bool HasScored { get; }
        bool IsActive { get; }
    }
}
