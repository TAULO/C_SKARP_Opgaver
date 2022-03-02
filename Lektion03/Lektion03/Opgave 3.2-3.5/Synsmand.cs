using System;
namespace Lektion03.Opgave3
{
    public class Synsmand: Mekaniker
    {
        private int antalSyn;

        public Synsmand(CprNr cpr, string navn, string adresse, DateTime svendeprøve, double timeløn, int antalSyn): base(cpr, navn, adresse, svendeprøve, timeløn)
        {
            this.antalSyn = antalSyn;
        }

        public override double BeregnUgeLøn()
        {
            return 290.0 * antalSyn * this.GetTimerPrUge();
        }

        public int GetAntalSyn()
        {
            return this.antalSyn;
        }

        public override string ToString()
        {
            return base.ToString() + "\nAntal syn: " + this.antalSyn;
        }
    }
}
