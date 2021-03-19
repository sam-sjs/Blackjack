using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Output
    {
        public void DisplayHand(Participant participant)
        {
            int score = participant.GetScore();
            List<Card> hand = participant.Hand;
            string prefix = participant.Role == Role.Player ? "You are" : "The Dealer is";
            
            Console.WriteLine();
            Console.WriteLine($"{prefix} currently at {score}");
            Console.Write("with the hand ");
            foreach (Card card in hand)
            {
                Console.Write($"[{card.Value} of {card.Suit}] ");
            }
            Console.WriteLine();
        }

        public void DisplayDraw(Participant participant)
        {
            Card newCard = participant.Hand[^1];
            Console.WriteLine("=============================");
            Console.WriteLine(participant.Role == Role.Player
                ? $"You draw [{newCard.Value} of {newCard.Suit}]"
                : $"The dealer draws [{newCard.Value} of {newCard.Suit}]");
        }

        public void PresentChoice()
        {
            Console.Write("Hit or stay? (Hit = 1, Stay = 0)");
        }
        
        public void DisplayResult(Result result)
        {
            Console.WriteLine();
            switch (result)
            {
                case Result.Win:
                    Console.WriteLine("You beat the dealer!");
                    break;
                case Result.Lose:
                    Console.WriteLine("Dealer Wins!");
                    break;
                case Result.Tie:
                    Console.WriteLine("The game is a tie!");
                    break;
                case Result.Bust:
                    Console.WriteLine("You've gone bust!");
                    break;
            }
        }
    }
}