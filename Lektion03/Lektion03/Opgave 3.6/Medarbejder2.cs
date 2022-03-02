using System;
using Lektion03.Opgave3;

namespace Lektion03
{
    public class Medarbejder2: IHarAdresse
    {

        private string adresse;
        

        public Medarbejder2(string adresse) 
        {
            this.adresse = adresse;
        }

        public string GetAdresse()
        {
            return this.adresse;
        }

        public void SetAdresse(string adresse)
        {
            this.adresse = adresse;
        }
    }
}
