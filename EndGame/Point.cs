using System;

namespace EndGame
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public Point(double x, double y) => (X, Y) = (x, y);

        public static bool operator ==(Point left, Point right) => (left.X, left.Y) == (right.X, right.Y);

        public static bool operator !=(Point left, Point right) => (left.X, left.Y) != (right.X, right.Y);

        public void SwapCoords() => (X, Y) = (Y, X);

        public override readonly string ToString()
        {
            return $"({X}, {Y}) is {Distance} from the origin";
        }

        public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);
    }
}