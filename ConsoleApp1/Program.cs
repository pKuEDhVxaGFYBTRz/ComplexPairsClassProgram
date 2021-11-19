using System;
using System.Collections.Generic;

namespace Complex_Pair_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // main program

            // init 
            Player player = new Player(Input.Input.InputStr(prompt: Strings.getName));
            Random rand = new Random();

            // init player inventory with random cards.
            for (int i = 0; i < 10; i++)
            {
                player.inventory.add();
            }
        }
    }
}
