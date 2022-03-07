using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion08
{
    internal class Car
    {
        private string brand { get; set; }
        private int horsepower { get; set; }

        public Car() { }
        public Car(string brand, int horsepower)
        {
            this.brand = brand;
            this.horsepower = horsepower;
        }

        public override string ToString()
        {
            return "Brand: " + this.brand + ". Horsepowers: " + this.horsepower;
        }
    }
}
