using System;
using System.Collections.Generic;
using System.Text;

namespace KlasUitwerking
{
    interface ICard
    {
        public void PrintMe();
        public string MakeAsString();

        public bool SatisfiesSuit(Suit suit);
    }
}
