using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            var calculation = new Calculation();
            shapeList.Add(new Square(5));
            shapeList.Add(new Rectangle(4, 5));
            shapeList.Add(new Circle(10));


            Console.WriteLine(calculation.SumAreas(shapeList));
            Console.WriteLine(calculation.SumCorners(shapeList));
            Console.ReadKey();
        }
    }
}
