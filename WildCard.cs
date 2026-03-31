using System;
using System.Collections.Generic;
using System.Text;

namespace KlasUitwerking
{
    internal class WildCard : ICard
    {
        public string MakeAsString()
        {
            // WildCard has no fixed suit, present it clearly
            return "Wild";
        }

        public void PrintMe()
        {
            Console.WriteLine(this.MakeAsString());
        }

        public bool SatisfiesSuit(Suit suit)
        {
            return true;
        }
    }
}
