using System;
using System.Collections.Generic;
namespace MyLibrary
{
    public class MyList
    {
        List<int> list = new List<int>();
        
        public MyList()
        {
        }

        public void AddNumber(int number)
        {
            list.Add(number);
        }

        public void AddRandomNumbers()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(1, 10));
            }
        }

        public void PrintNumbers()
        {
           foreach(int numbers in list)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
