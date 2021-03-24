using System.Collections.Generic;

namespace Blackjack
{
    public class Message
    {
        private IOutput _output;
        public Message(IOutput output)
        {
            _output = output;
        }
        public void DisplayHand(Participant participant)
        {
            int score = participant.GetScore();
            List<Card> hand = participant.Hand;
            string prefix = participant.Role == Role.Player ? "You are" : "The Dealer is";
            
            _output.WriteLine();
            _output.WriteLine($"{prefix} currently at {score}");
            _output.Write("with the hand ");
            foreach (Card card in hand)
            {
                _output.Write($"[{card.Value} of {card.Suit}] ");
            }
            _output.WriteLine();
        }

        public void DisplayDraw(Participant participant)
        {
            Card newCard = participant.Hand[^1];
            _output.WriteLine("=============================");
            _output.WriteLine(participant.Role == Role.Player
                ? $"You draw [{newCard.Value} of {newCard.Suit}]"
                : $"The dealer draws [{newCard.Value} of {newCard.Suit}]");
        }

        public void PresentChoice()
        {
            _output.Write("Hit or stay? (Hit = 1, Stay = 0)");
        }

        public void IncorrectInput()
        {
            _output.WriteLine("Incorrect input please select again");
        }
        
        public void DisplayResult(Result result)
        {
            _output.WriteLine();
            switch (result)
            {
                case Result.Win:
                    _output.WriteLine("You beat the dealer!");
                    break;
                case Result.Lose:
                    _output.WriteLine("Dealer Wins!");
                    break;
                case Result.Tie:
                    _output.WriteLine("The game is a tie!");
                    break;
                case Result.Bust:
                    _output.WriteLine("You've gone bust!");
                    break;
            }
        }
    }
}