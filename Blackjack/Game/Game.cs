using System.Threading;
using Blackjack.Input;

namespace Blackjack.Game
{
    public class Game
    {
        public Game(Participant.Participant player, Participant.Participant dealer, Deck.Deck deck, IInput input, Message.Message message)
        {
            Player = player;
            Dealer = dealer;
            Deck = deck;
            Input = input;
            Message = message;
        }

        private const int StartingHandSize = 2;
        private const int HighestScore = 21;
        private const int DealerHitMinimum = 17;
        private const int DealerHitDelay = 1500;
        public Participant.Participant Player { get; }
        public Participant.Participant Dealer { get; }
        public Deck.Deck Deck { get; }
        public IInput Input { get; }
        public Message.Message Message { get; }

        public void PlayGame()
        {
            SetupGame();
            PlayerTurn();
            if (!Player.IsBust) DealerTurn();
            Result result = DetermineResult();
            Message.DisplayResult(result);
        }

        private void SetupGame()
        {
            Deck.Shuffle();
            Player.Hit(Deck, StartingHandSize);
            Dealer.Hit(Deck, StartingHandSize);
        }

        private void PlayerTurn()
        {
            Message.DisplayHand(Player);
            while (Player.GetScore() < HighestScore)
            {
                Message.PresentChoice();
                Choice choice = ReceiveChoice();
                if (choice == Choice.Hit)
                {
                    Player.Hit(Deck);
                }
                if (choice == Choice.Stay) break;
                Message.DisplayDraw(Player);
                if (Player.CheckBust()) return;
                Message.DisplayHand(Player);
            }
        }

        private void DealerTurn()
        {
            Message.DisplayHand(Dealer);
            while (DealerShouldHit())
            {
                Thread.Sleep(DealerHitDelay);
                Dealer.Hit(Deck);
                Message.DisplayDraw(Dealer);
                if (Dealer.CheckBust()) return;
                Message.DisplayHand(Dealer);
            }
        }
        
        public Choice ReceiveChoice()
        {
            string input;
            while (true)
            {
                input = Input.ReadLine();
                if (input == "0" || input == "1") break;
                Message.IncorrectInput();
            }
            return input == "1" ? Choice.Hit : Choice.Stay;
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