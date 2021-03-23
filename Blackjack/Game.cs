
using System.Threading;

namespace Blackjack
{
    public class Game
    {
        public Game(Participant player, Participant dealer, Deck deck, Menu input, Output output)
        {
            Player = player;
            Dealer = dealer;
            Deck = deck;
            Menu = input;
            Output = output;
        }

        private const int StartingHandSize = 2;
        private const int HighestScore = 21;
        private const int DealerHitMinimum = 17;
        private const int DealerHitDelay = 1500;
        public Participant Player { get; }
        public Participant Dealer { get; }
        public Deck Deck { get; }
        public Menu Menu { get; }
        public Output Output { get; }

        public void PlayGame()
        {
            SetupGame();
            PlayerTurn();
            if (!Player.IsBust) DealerTurn();
            Result result = DetermineResult();
            Output.DisplayResult(result);
        }

        private void SetupGame()
        {
            Deck.Shuffle();
            Player.Hit(Deck, StartingHandSize);
            Dealer.Hit(Deck, StartingHandSize);
        }

        private void PlayerTurn()
        {
            Output.DisplayHand(Player);
            while (Player.GetScore() < HighestScore)
            {
                Output.PresentChoice();
                Choice choice = Menu.ReceiveChoice();
                if (choice == Choice.Hit)
                {
                    Player.Hit(Deck);
                }
                if (choice == Choice.Stay) break;
                Output.DisplayDraw(Player);
                if (Player.CheckBust()) return;
                Output.DisplayHand(Player);
            }
        }

        private void DealerTurn()
        {
            Output.DisplayHand(Dealer);
            while (DealerShouldHit())
            {
                Thread.Sleep(DealerHitDelay);
                Dealer.Hit(Deck);
                Output.DisplayDraw(Dealer);
                if (Dealer.CheckBust()) return;
                Output.DisplayHand(Dealer);
            }
        }

        public Result DetermineResult()
        {
            if (Player.IsBust) return Result.Bust;
            if (Dealer.IsBust || Dealer.GetScore() < Player.GetScore()) return Result.Win;
            return Player.GetScore() < Dealer.GetScore() ? Result.Lose : Result.Tie;
        }

        public bool DealerShouldHit()
        {
            return (Dealer.GetScore() < Player.GetScore() && Dealer.GetScore() < HighestScore) ||
                   Dealer.GetScore() < DealerHitMinimum;
        }
    }
}