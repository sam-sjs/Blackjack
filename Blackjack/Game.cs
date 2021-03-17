
namespace Blackjack
{
    public class Game
    {
        public Game(Participant player, Participant dealer, Deck deck, InputOutput io)
        {
            Player = player;
            Dealer = dealer;
            Deck = deck;
            Io = io;
            Deck.Shuffle();
        }

        private const int StartingHandSize = 2;
        private const int HighestScore = 21;
        private const int DealerHitMinimum = 17;
        private const int AceHighLowDifference = 10;
        public Participant Player { get; }
        public Participant Dealer { get; }
        public Deck Deck { get; }
        public InputOutput Io { get; }

        public void PlayGame()
        {
            Player.Hit(Deck, StartingHandSize);
            Dealer.Hit(Deck, StartingHandSize);
            while (Player.Score < HighestScore)
            {
                CheckBust(Player);
                
                Io.DisplayHand(Player.Score, Player.Hand);
                Choice choice = Io.ReceiveChoice();

                if (choice == Choice.Hit)
                {
                    Player.Hit(Deck);
                }
                if (choice == Choice.Stay) break;
            }

            while (Dealer.Score < DealerHitMinimum || (Dealer.Score < Player.Score && Dealer.Score < HighestScore))
            {
                Dealer.Hit(Deck);
            }

            if (Player.Score > Dealer.Score) Io.GameOutcome(Result.Win, Dealer.Hand);
            if (Player.Score < Dealer.Score) Io.GameOutcome(Result.Lose, Dealer.Hand);
            if (Player.Score == Dealer.Score) Io.GameOutcome(Result.Tie, Dealer.Hand);
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
            Io.Bust(Player.Hand);
        }
    }
}