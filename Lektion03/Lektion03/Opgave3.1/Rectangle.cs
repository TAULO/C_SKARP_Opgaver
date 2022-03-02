using System;
namespace Lektion03
{
    public class Rectangle: Shape
    {
        private double length;
        private double width;

        public Rectangle(double x, double y, double length, double width): base(x, y)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return width * length;
        }
    }
}
