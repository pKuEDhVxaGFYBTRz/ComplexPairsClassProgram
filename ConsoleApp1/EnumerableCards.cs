using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Pair_Program
{
    class CardPointers
    {
        public enum EnumerableCards
        {
            gold1,
            gold2,
            gold3,
            points1,
            points2,
            points3,
        }

        private object cardClass = new Dictionary<object, Card>()
        {
            { EnumerableCards.gold1, },
            { EnumerableCards.gold2, }
        };

        public object CardClass { get => cardClass; set => cardClass = value; }
    }
}
