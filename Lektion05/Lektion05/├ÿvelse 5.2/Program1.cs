using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lektion05
{
    public class Program1
    {
        static List<Person> people1;

        static void Main(string[] args)
        {
            Exercise1();

            // øvelse 5.3
            // alle personer med score under 2
            var result1 = people1.FindAll(p => p.Score < 2);
            foreach(var p in result1)
            {
                //Console.WriteLine(p);
            }

            // alle personer med en lige score
            var result2 = people1.FindAll(p => p.Score % 2 == 0);
            foreach (var p in result2)
            {
                //Console.WriteLine(p);
            }

            // alle personer med en lige score og weight større end 60
            var result3 = people1.FindAll(p => p.Score % 2 == 0 && p.Weigth > 60);
            foreach (var p in result3)
            {
                //Console.WriteLine(p);
            }

            // alle personer med en vægt deligt med 3
            var result4 = people1.FindAll(p => p.Weigth % 3 == 0);
            foreach (var p in result4)
            {
                //Console.WriteLine(p);
            }

            // øvelse 5.4
            // find første person med en score på 3
            var result5 = people1.FindIndex(p => p.Score == 3);
            //Console.WriteLine(result5);

            // find første person under 10 år, som har en score på 3
            var result6 = people1.FindIndex(p => p.Age > 10 && p.Score == 3);
            //Console.WriteLine(result6);

            var result7 = people1.FindAll(p => p.Age > 10 && p.Score == 3);
            //Console.WriteLine(result7.Count);

            var result8 = people1.FindIndex(p => p.Age < 8 && p.Score == 3);
            //Console.WriteLine(result8);

            // øvelse 5.5

            // øvelse 5.6

            // øvelse 5.7
            var sort1 = from i in people1
                        orderby i.Score
                        select i.Score;
            foreach (var p in sort1)
            {
                //Console.WriteLine(p);
            }

            var sort2 = from i in people1
                        orderby i.Score descending
                        select i.Score;
            foreach (var p in sort2)
            {
                //Console.WriteLine(p);
            }

            var sort3 = people1.OrderBy(p => p.Score).Select(p => p.Score);
            foreach (var p in sort3)
            {
                //Console.WriteLine(p);
            }

            var sort4 = people1.OrderBy(p => p.Score).Select(p => p.Score);
            foreach (var p in sort4)
            {
                //Console.WriteLine(p);
            }

            var sort5 = people1.OrderByDescending(p => p.Score).Select(p => p.Score);
            foreach (var p in sort5)
            {
                //Console.WriteLine(p);
            }
            var sort6 = people1.OrderByDescending(p => p.Score).ThenBy(p => p.Age).Select(p => p.Score);
            foreach (var p in sort6)
            {
                //Console.WriteLine(p);
            }

            var sort7 = from p in people1
                        orderby p.Score, p.Age
                        select p;
            foreach (var p in sort7)
            {
                //Console.WriteLine(p);
            }

            // øvelse 5.9
            int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

            var twoDigitAsc = numbers.Where(n => n.ToString().Length == 2).OrderBy(p => p);
            foreach (var n in twoDigitAsc)
            {
                //Console.WriteLine(n);
            }

            var twoDigitDesc = numbers.Where(n => n.ToString().Length == 2).OrderByDescending(p => p);
            foreach (var n in twoDigitDesc)
            {
                //Console.WriteLine(n);
            }

            var intToString = numbers.Select(n => n.ToString());
            foreach (var n in intToString)
            {
                //Console.WriteLine(n);
            }

            var stringEvenUneven = numbers.Select(n => n % 2 == 0 ? n.ToString() + " even" : n.ToString() + " uneven");
            foreach(var str in stringEvenUneven)
            {
                Console.WriteLine(str);
            }
        }

        public static void Exercise1()
        {
            try
            {
                people1 = Person.ReadCSVFile("/Users/taulo/Downloads/data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl: " + ex.Message);
            }
        }
    }
}
