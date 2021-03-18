
using System;
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
        private const int DealerHitDelay = 1000;
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
            DisplayResult();
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
                Choice choice = Input.ReceiveChoice();
                if (choice == Choice.Hit)
                {
                    Player.Hit(Deck);
                }
                if (choice == Choice.Stay) break;
                Output.DisplayDraw(Player);
                CheckBust(Player);
                Output.DisplayHand(Player);
            }
        }

        private void DealerTurn()
        {
            Output.DisplayHand(Dealer);
            while (Dealer.GetScore() < DealerHitMinimum || (Dealer.GetScore() < Player.GetScore() && Dealer.GetScore() < HighestScore))
            {
                Thread.Sleep(DealerHitDelay);
                Dealer.Hit(Deck);
                CheckBust(Dealer);
                Output.DisplayDraw(Dealer);
                Output.DisplayHand(Dealer);
            }
        }

        private void CheckBust(Participant participant)
        {
            
        }

        private void DisplayResult()
        {
            if (Player.GetScore() > Dealer.GetScore()) Output.GameOutcome(Result.Win, Dealer.Hand);
            if (Player.GetScore() < Dealer.GetScore()) Output.GameOutcome(Result.Lose, Dealer.Hand);
            if (Player.GetScore() == Dealer.GetScore()) Output.GameOutcome(Result.Tie, Dealer.Hand);
        }
    }
}