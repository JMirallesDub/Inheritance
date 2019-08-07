namespace Inheritance
{
    public class Triangle : Shape
    {
        public int baseTriangle { get; private set; }
        public int highTriangle { get; private set; }

        public Triangle( int baseTriangle, int highTriangle)
        {
            CounterCorners = 3;
        }
               

        public override double Area()
        {
            return (baseTriangle * highTriangle) / 2;
        }
    }
}
