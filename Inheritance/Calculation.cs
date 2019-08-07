using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Calculation
    {
        public double SumAreas(List<Shape> shapeList)
        {
            double sumShapes = 0;
            foreach (var shape in shapeList)
            {
                sumShapes += shape.Area();
            }

            return sumShapes;
        }

        public int SumCorners(List<Shape> shapeList)
        {
            return shapeList.Sum(x => x.CounterCorners);
        }
    }
}
