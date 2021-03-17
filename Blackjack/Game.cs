
using System.Threading;

namespace Blackjack
{
    public class Game
    {
        public Game(Participant player, Participant dealer, Deck deck, Input input, Output output)
        {
            Player = player;
            Dealer = dealer;
            Deck = deck;
            Input = input;
            Output = output;
        }

        private const int StartingHandSize = 2;
        private const int HighestScore = 21;
        private const int DealerHitMinimum = 17;
        private const int AceHighLowDifference = 10;
        private const int DealerHitDelay = 750;
        public Participant Player { get; }
        public Participant Dealer { get; }
        public Deck Deck { get; }
        public Input Input { get; }
        public Output Output { get; }

        public void PlayGame()
        {
            SetupGame();
            PlayerTurn();
            DealerTurn();
            DetermineResult();
        }

        private void SetupGame()
        {
            Deck.Shuffle();
            Player.Hit(Deck, StartingHandSize);
            Dealer.Hit(Deck, StartingHandSize);
        }

        private void PlayerTurn()
        {
            while (Player.Score < HighestScore)
            {
                CheckBust(Player);
                Output.DisplayHand(Player.Score, Player.Hand);
                Choice choice = Input.ReceiveChoice();
                if (choice == Choice.Hit)
                {
                    Player.Hit(Deck);
                }
                if (choice == Choice.Stay) break;
            }
        }

        private void DealerTurn()
        {
            while (Dealer.Score < DealerHitMinimum || (Dealer.Score < Player.Score && Dealer.Score < HighestScore))
            {
                CheckBust(Dealer);
                Output.DisplayDealer(Dealer.Score, Dealer.Hand);
                Thread.Sleep(DealerHitDelay); // Check this works
                Dealer.Hit(Deck);
            }
        }

        private void CheckBust(Participant participant)
        {
            if (participant.Score <= HighestScore) return;
            if (participant.AceCount > 0)
            {
                participant.Score -= AceHighLowDifference;
                participant.AceCount -= 1;
                return;
            }
            if (participant == Dealer)
            {
                Output.GameOutcome(Result.Win, participant.Hand);
            }
            else
            {
                Output.GameOutcome(Result.Bust, participant.Hand);
            }
        }

        private void DetermineResult()
        {
            if (Player.Score > Dealer.Score) Output.GameOutcome(Result.Win, Dealer.Hand);
            if (Player.Score < Dealer.Score) Output.GameOutcome(Result.Lose, Dealer.Hand);
            if (Player.Score == Dealer.Score) Output.GameOutcome(Result.Tie, Dealer.Hand);
        }
    }
}