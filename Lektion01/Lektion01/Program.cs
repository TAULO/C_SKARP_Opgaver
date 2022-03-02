using System;
using MyLibrary;

namespace Lektion01
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 1:

            //Person p1 = new Person("Jesper");
            //Console.WriteLine(p1.GetNavn());
            //Console.WriteLine(p1);
            //p1.setNavn("Tobias");
            //Console.WriteLine(p1);


            //opgave 2:

            //Console.WriteLine("Skriv en dyrerase:");

            //string input = Console.ReadLine();
            //var rase = new Animal(input);

            //while (true)

            //    if (rase.IsDog())
            //    {
            //        Console.WriteLine("Du skrev: " + rase);
            //        Console.WriteLine("Det er en hund!");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Du skrev: " + rase);
            //        Console.WriteLine("Det ikke en hund:( Prøv Igen!");
            //        input = Console.ReadLine();
            //        rase = new Animal(input);
            //    }


            //opgave 3:

            //var myList = new MyList();
            //myList.AddNumber(2);
            //myList.AddNumber(10);
            //myList.AddNumber(19);
            //myList.AddNumber(11);

            //myList.PrintNumbers();


            //opgave 4:

            var myList = new MyList();
            myList.AddRandomNumbers();
            myList.PrintNumbers();
        }
    }
}
    