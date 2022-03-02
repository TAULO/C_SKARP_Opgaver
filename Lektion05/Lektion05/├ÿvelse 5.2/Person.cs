using System;
using System.Collections.Generic;
using System.IO;

namespace Lektion05
{
    public class Person
    {
        public Person(string data)
        {
            var L = data.Split(";");

            Name = L[0];
            Age = int.Parse(L[1]);
            Weigth = int.Parse(L[2]);
            Score = int.Parse(L[3]);
            Accepted = false;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Weigth { get; set; }
        public int Score { get; set; }
        public bool Accepted { get; set; }

        public static List<Person> ReadCSVFile(string filename)
        {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var p = new Person(line);
                    list.Add(p);
                }
            }
            return list;
        }

        //public static void SetAcceptedP(this List<Person> list, Predicate<Person> pred)
        //{
                 
        //}

        public override string ToString()
        {
            return "Name: " + Name + Environment.NewLine +
                   "Age: " + Age + Environment.NewLine +
                   "Weigth: " + Weigth + Environment.NewLine +
                   "Score: " + Score + Environment.NewLine +
                   "Accepted: " + Accepted + Environment.NewLine;
        }
    }
}
