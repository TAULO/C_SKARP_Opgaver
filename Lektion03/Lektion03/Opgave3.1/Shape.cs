using System;
namespace Lektion03
{
    abstract public class Shape
    {

        private double x, y;

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Shape(): this(1,1)
        {
    
        }

        public double GetX()
        {
            return this.x;
        }

        public double getY()
        {
            return this.y;
        }

        public void setX(double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }
        public abstract double Area();

        override public string ToString()
        {
            return "X: " + this.x + ". Y: " + this.y + ". Area: " + this.Area();  
        }
    }
}
