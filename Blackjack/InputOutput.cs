
using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class InputOutput
    {
        public void DisplayHand(int score, List<Card> hand)
        {
            Card newCard = hand[^1]; // A little suspicious that this should be hand[^0] but will see when can test.
            Console.WriteLine(hand.Count == 2
                ? "Welcome to Blackjack!"
                : $"You draw {newCard.Value} of {newCard.Suit}");
            Console.WriteLine();
            Console.WriteLine($"You are currently at {score}");
            Console.Write("with the hand ");
            foreach (Card card in hand)
            {
                Console.Write($"{card.Value} of {card.Suit}");
            }
            Console.WriteLine();
            Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
        }
        
        public Choice ReceiveChoice()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "0" || input == "1") break;
                Console.WriteLine("Incorrect input please select again");
            }

            return input == "1" ? Choice.Hit : Choice.Stay;
        }
    }
}