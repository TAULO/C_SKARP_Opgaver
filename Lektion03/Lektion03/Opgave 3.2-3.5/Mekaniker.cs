using System;
namespace Lektion03.Opgave3
{
    abstract public class Mekaniker: Medarbejde2r
    {
        private DateTime svendeprøve;
        private double timeløn;

        public Mekaniker(CprNr cpr, string navn, string adresse, DateTime svendeprøve, double timeløn) : base(cpr, navn, adresse)
        {
            this.svendeprøve = svendeprøve;
            this.timeløn = timeløn;
        }

        public DateTime GetSvendeprøve()
        {
            return this.svendeprøve;
        }

        public double GetTimeLøn()
        {
            return this.timeløn;
        }

        override abstract public double BeregnUgeLøn();

        public override string ToString()
        {
            return base.ToString() + "\nSvendeprøve: " + this.svendeprøve + "\nTime løn: " + this.timeløn + "\nUgelige løn: " + this.BeregnUgeLøn();
        }
    }
}
