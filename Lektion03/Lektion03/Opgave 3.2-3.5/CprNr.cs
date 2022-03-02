using System;
namespace Lektion03.Opgave3
{
    public class CprNr
    {
        private string bDate;
        private string sNumber;

        public CprNr(string bDate, string sNumber)
        {
            this.bDate = bDate;
            this.sNumber = sNumber;
        }

        public override string ToString()
        {
            return "Birtday: " + this.bDate + " Sequence number: " + this.sNumber;
        }
    }
}
