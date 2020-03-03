using System;

namespace CSharp8Features
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Math.Sqrt(X * X + Y * Y);

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Point left, Point right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator !=(Point left, Point right)
        {
            return left.X != right.X || left.Y != right.Y;
        }

        public void SwapCoords()
        {
            var tmp = X;
            X = Y;
            Y = tmp;
        }

        public override string ToString()
        {
            return $"({X}, {Y}) is {Distance} from the origin";
        }

        public void Deconstruct(out double x, out double y)
        {
            x = X;
            y = Y;
        }
    }
}
