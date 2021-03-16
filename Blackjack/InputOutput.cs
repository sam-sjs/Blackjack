
using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class InputOutput
    {
        public void DisplayHand(Card newCard, int score, List<Card> hand)
        {
            if (hand.Count == 2)
            {
                Console.WriteLine("Welcome to Blackjack!");
            }
            else
            {
                Console.WriteLine($"You draw {newCard.Value} of {newCard.Suit}");
            }
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
                Console.WriteLine("Incorrect input please select again"); // Mixing input/output? Should I separate this somehow?
            }

            if (input == "1") return Choice.Hit;
            return Choice.Stay;
        }
    }
}