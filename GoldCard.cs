using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Pair_Program
{
    class GoldCard:Card
    {
        private int cardValue;
        public int CardValue
        {
            get
            {
                return cardValue;
            }
            private set
            {
                cardValue = value;
            }
        }

        public GoldCard(string n, int c, int v):base(n,c)
        {
            CardValue = v;
        }
    }
}
