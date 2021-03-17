
namespace Blackjack
{
    public class Game
    {
        public Game(Player player, Dealer dealer, Deck deck, InputOutput io)
        {
            Player = player;
            Dealer = dealer;
            Deck = deck;
            Io = io;
            Deck.Shuffle();
        }

        private const int StartingHandSize = 2;
        private const int WinningScore = 21;
        private const int DealerHitMinimum = 17;
        public Player Player { get; }
        public Dealer Dealer { get; }
        public Deck Deck { get; }
        public InputOutput Io { get; }

        public int PlayGame()
        {
            Player.Hit(Deck, StartingHandSize);
            Dealer.Hit(Deck, StartingHandSize);
            while (Player.Score < WinningScore)
            {
                Io.DisplayHand(Player.Score, Player.Hand);
                Choice choice = Io.ReceiveChoice();

                if (choice == Choice.Hit)
                {
                    Player.Hit(Deck);
                }
                if (choice == Choice.Stay) break;
            }

            while (Dealer.Score < DealerHitMinimum || (Dealer.Score < Player.Score && Dealer.Score < WinningScore))
            {
                Dealer.Hit(Deck);
            }

            return 0;
        }
    }
}