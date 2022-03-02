using System;
using Lektion03.Opgave3;

namespace Lektion03
{
    public class Medarbejde2r
    {
        private string navn;
        private string adresse;
        private const double timerPrUge = 37;
        private CprNr cpr;

        public Medarbejde2r(CprNr cpr, string navn, string adresse) 
        {
            this.cpr = cpr;
            this.navn = navn;
            this.adresse = adresse;
        }

        public string GetNavn()
        {
            return this.navn;
        }

        public string GetAdresse()
        {
            return this.adresse;
        }

        public virtual double BeregnUgeLøn()
        {
            return 0.0;
        }

        public double GetTimerPrUge()
        {
            return timerPrUge;
        }

        public CprNr GetCprNr()
        {
            return this.cpr;
        }

        public override string ToString()
        {
            return "CPR-Nummber: " + this.cpr + "\nNavn: " + this.navn + "\nAdresse: " + this.adresse;
        }
    }
}
