using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Shape
    {
        public int CounterCorners { get; set; }
        public abstract double Area();

    }

    public class Rectangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }        
        public override double Area()
        {
            return SideA * SideB;
        }
    }
}
