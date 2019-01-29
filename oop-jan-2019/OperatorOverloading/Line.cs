namespace oop_jan_2019
{
    public class Line
    {
        public double Length { get; }

        public Line(double length)
        {
            Length = length;
        }

        public static Line operator +(Line l1, Line l2)
        {
            return new Line(l1.Length + l2.Length);
        }
    }
}