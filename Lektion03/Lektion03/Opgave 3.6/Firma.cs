using System;
namespace Lektion03
{
    public class Firma: IHarAdresse
    {
        private string adresse;

        public Firma(string adresse)
        {
            this.adresse = adresse;
        }

        public string GetAdresse()
        {
            return this.adresse;
        }

        public void SetAdresse(string adresse) => this.adresse = adresse;
    }
}
