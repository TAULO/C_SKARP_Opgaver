using System;

namespace Lektion02
{
    class Program
    {
        static void Main(string[] args)
        {

            // øvelse 3
            //while (true)
            //{
            //    Console.WriteLine("Indtast fib værdi:");
            //    var input = Console.ReadLine();
            //    if (!Double.IsNaN(Double.Parse(input)))
            //    {
            //        CalcFibonnaci(int.Parse(input));
            //        Console.WriteLine("-----------------------");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Must be a number!");
            //    }


            // øvelse 4
            //var d1 = new DateTime(2012, 02, 17);
            //int age;
            //CalculateAge(d1, out age);
            //Console.WriteLine("Du er: " + age + " år gammel");


            // øvelse 5
            MyNormalMethod();

            }
        // øvelse 3
        private static void CalcFibonnaci(int n)
        {
            int a = 0, b = 1, c = 0;
            while (n > 2)
            {
                c = a + b;
                Console.WriteLine(" {0}", c);
                a = b;
                b = c;

                n--;
            }
        }

        private static void CalculateAge(DateTime birthDateInput, out int age)
        {
            DateTime currentTime = DateTime.Now;
            if (birthDateInput.Month <= currentTime.Month && birthDateInput.Day <= currentTime.Day)
            {   
                age = currentTime.Year - birthDateInput.Year;
            } else
            {
                age = currentTime.Year - birthDateInput.Year - 1;
            }
        }

        private static void MyMethodWithError(int sum = 0)
        {
            if (sum != 0) throw new Exception("Dis is eine error");
        }

        static public void MyNormalMethod(int sum = 0)
        {
            try
            {
                MyMethodWithError(1);
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
