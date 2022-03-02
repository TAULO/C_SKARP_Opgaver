using System;
using Lektion03.Opgave3;

namespace Lektion03
{
    public class Værkfører: Mekaniker 
    {
        private DateTime udnævelse;
        private double tillæg;

        public Værkfører(CprNr cpr, string navn, string adresse, DateTime svendeprøve, double timeløn, DateTime udnævelse, double tillæg): base(cpr, navn, adresse, svendeprøve, timeløn)
        {
            this.udnævelse = udnævelse;
            this.tillæg = tillæg;
        }

        public override double BeregnUgeLøn()
        {
            return this.GetTimeLøn() + tillæg * this.GetTimerPrUge();
        }

        public override string ToString()
        {
            return base.ToString() + "\nUdnævelse: " + this.udnævelse + "\nTillæg: " + this.tillæg;
        }
    }
}
