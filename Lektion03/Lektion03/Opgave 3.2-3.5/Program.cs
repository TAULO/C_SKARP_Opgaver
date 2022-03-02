using System;
namespace Lektion03.Opgave3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var d1 = new DateTime(2010, 05, 10);
            var cpr1 = new CprNr("109401", "1095");
            var cpr2 = new CprNr("139402", "1297");
            var synsmand1 = new Synsmand(cpr1, "Jesper", "Svandegade 2", d1, 210.0, 5);
            var værkfører1 = new Værkfører(cpr2, "Casper", "Møllegade 3", d1, 250.0, d1, 100);

            Console.WriteLine(synsmand1);
            Console.WriteLine(værkfører1);

            MedarbejderListe<CprNr> list = new MedarbejderListe<CprNr>();
            list.AddElement(synsmand1.GetCprNr(), synsmand1);
            list.AddElement(værkfører1.GetCprNr(), værkfører1);


            Console.WriteLine("Size: " + list.Size());
            Console.WriteLine(list.GetElement(cpr2));
        }
    }
}
