using System.Collections.Generic;

namespace Complex_Pair_Program
{
    internal class Player
    {
        public string name { get; private set; }
        public object inventory { get; set; }

        public Player(string name = "")
        {
            this.name = name;
            this.inventory = new List<object>();
        }
    }
}