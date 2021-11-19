using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Pair_Program
{
    class PointCard:Card
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

        public PointCard(string n, int c, int v) : base(n, c)
        {
            CardValue = v;
        }
    }
}
