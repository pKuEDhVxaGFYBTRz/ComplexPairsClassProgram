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

        public static object cardClass = new Dictionary<object, object>()
        {
            { EnumerableCards.gold1, typeof(GoldCard)},
            { EnumerableCards.gold2, typeof(GoldCard)}
        };

    }
}
