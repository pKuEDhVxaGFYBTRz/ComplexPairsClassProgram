using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Pair_Program
{
    class CellarCard:Card
    {
        public CellarCard(string n, int c) : base(n, c)
        {

        }

        public static List<Card> Perform(List<Card> hand)
        {
            //Displays cards to the user
            Console.WriteLine("Hand:");
            foreach(Card card in hand)
            {
                Console.WriteLine(card.Name);
            }

            //Allows user to remove cards
            Console.WriteLine("\nPlease type the name of any cards that you wish to remove. Once you are done, type 'Done'.");

            while (true)
            {
                //Exits the loop if the hand is empty.
                if(hand.Count <= 0)
                {
                    Console.WriteLine("Hand empty.");
                    break;
                }

                string cardToRemove = Console.ReadLine();

                //Exits the loop if the user entered 'Done'.
                if(cardToRemove.ToLower() == "done")
                {
                    break;
                }

                //Removes a card with the same name as the entered one.

                bool hasRemoved = false;

                foreach(Card card in hand)
                {
                    if(card.Name.ToLower() == cardToRemove.ToLower())
                    {
                        hand.Remove(card);
                        hasRemoved = true;
                        break;
                    }
                }

                if (!hasRemoved)
                {
                    Console.WriteLine("The card you entered is not in your hand.");
                }
            }

            //Returns remaining cards
            return hand;
        }
    }
}
