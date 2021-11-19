using System;

namespace Complex_Pair_Program
{
    class Card
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }

        protected int cost;
        public int Cost
        {
            get
            {
                return cost;
            }
            protected set
            {
                cost = value;
            }
        }

        public Card(string n, int c)
        {
            Name = n;
            Cost = c;
        }
    }
}