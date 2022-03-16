using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion08
{
    internal class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public int Horsepower { get; set; }

        public Car() { }
        public Car(string brand, int horsepower)
        {
            this.Brand = brand;
            this.Horsepower = horsepower;
        }

        public override string ToString()
        {
            return "Brand: " + this.Brand + ". Horsepowers: " + this.Horsepower;
        }
    }
}
