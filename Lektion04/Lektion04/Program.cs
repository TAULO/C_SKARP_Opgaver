using System;
namespace Lektion04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PowerPlant pp = new PowerPlant();

            pp.SetWarning(WarningToConsole);
           
        }

        public static void WarningToConsole()
        {
            Console.WriteLine("Advarsel!");
        }
    }
}
