using System;
namespace Lektion03
{
    public class Circle: Shape
    {

        private double radius;

        public Circle(double x, double y, double radius): base(x, y)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return (radius * radius) * Math.PI;
        }

        public double GetRadius()
        {
            return this.radius;
        }
    }
}
