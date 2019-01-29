using System;

namespace oop_jan_2019
{
    // Deprecated in favor of interface for the purposes of these examples
    public abstract class BaseShape
    {
        public double Area { get; }

        public virtual void Draw()
        {
            Console.WriteLine("I'm drawing the shape!");
        }
    }
}