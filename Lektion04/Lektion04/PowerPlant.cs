using System;
namespace Lektion04
{
    public class PowerPlant
    {
        private readonly Random r = new Random();
        public delegate void _Warning();

        public int HeatUp()
        {
            var randTemp = r.Next(100);
            Console.WriteLine("rand: " + randTemp);
            return randTemp;
        }

        public void SetWarning(_Warning w)
        {
            HeatUp() > 50 ? w
        }
    }
}
