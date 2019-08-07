using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            CounterCorners = 0;
            Radius = radius;
        }
        
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
