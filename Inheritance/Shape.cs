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
}
