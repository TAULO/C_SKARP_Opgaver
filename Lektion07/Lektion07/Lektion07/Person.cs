using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion07_1
{
    internal class Person
    {
        private string name; 
        private double weight;
        private int age;
        private int score;
        private bool accepted;

        public Person(string name, double weight, int age, int score, bool accepted)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.score = score;
            this.accepted = accepted;
        }

        public string Name { set; get; }
        public double Weight { get; set; }
        public int Age { get; set; }    
        public bool Score { get; set; } 
        public bool Accept { get; set; }

        public override string ToString()
        {
            return this.name + " " +
                   this.weight + " " +
                   this.age + " " +
                   this.score + " " +
                   this.accepted;
        }

    }
}
