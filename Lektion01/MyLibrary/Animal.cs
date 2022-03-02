using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class Animal : IAnimal
    {
        private string species;

        public Animal(string species)
        {
            this.species = species;
        }

        public bool IsDog()
        {
            if (this.species.Equals("dog")) return true;
            return false;
        }

        public override string ToString()
        {   
            return species; 
        }
    }
}
