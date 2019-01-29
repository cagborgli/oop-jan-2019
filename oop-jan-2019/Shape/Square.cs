using System;

namespace oop_jan_2019
{
    public sealed class Square : IShape
    {
        
        public double Length { get; }

        public Square(double length)
        {
            Length = length;
        }

        public double Area => Length * Length;

        public void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}