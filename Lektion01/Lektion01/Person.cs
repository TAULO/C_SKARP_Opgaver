using System;
namespace Lektion01
{
    public class Person
    {
        private string navn; 

        public Person(string navn)
        {
            this.navn = navn;
        }

        public string GetNavn()
        {
            return navn;    
        }

        public void setNavn(string navn)
        {
            this.navn = navn;
        } 

        public override string ToString()
        {
            return navn + " hedder " + navn;
        }
    }
}
