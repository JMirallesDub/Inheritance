using System;

namespace Inheritance
{
    public class Square : Shape
    {
        public double Side { get; }


        public Square(double side)
        {
            CounterCorners = 4;
            Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }
    }
}
