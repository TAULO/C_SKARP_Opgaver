using System;
using System.Collections.Generic;
using System.Linq;

namespace Lektion05
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<int> list = new List<int>();
        //    OpretList(list, 101);

        //    // øvelse 5.1
        //    list.ForEach(i =>
        //    {
        //        //if (i > 15)
        //            //if (i % 2 == 0) Console.WriteLine(i);
        //    });

        //    // øvelse 5.2
        //    // retunerer alle lige ints
        //    // her bliver brugt query method metoden
        //    var resultAllInts = list.Where(i => i % 2 == 0);
        //    foreach (var i in resultAllInts)
        //    {
        //        //Console.WriteLine(i);
        //    }

        //    // retunerer alle 
        //    var resultInts = list.Where(i => i.ToString().Length == 2);
        //    foreach (var i in resultInts)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    // her bliver brugt query expression
        //    var result1 = from i in list
        //                  where i % 2 == 0
        //                  select i;
        //    foreach (var i in result1)
        //    {
        //        //Console.WriteLine(i);
        //    }

        //    var result2 = from i in list
        //                  where i.ToString().Length == 2
        //                  select i;
        //    foreach (var i in result2)
        //    {
        //        //Console.WriteLine(i);
        //    }
        //}



        private static void OpretList(List<int> list, int antal)
        {
            for (int i = 0; i < antal; i++)
            {
                list.Add(i);
            }
        }
    }
}
