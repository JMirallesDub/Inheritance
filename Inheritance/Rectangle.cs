namespace Inheritance
{
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
