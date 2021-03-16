
namespace Blackjack
{
    public class Game
    {
        public Game(Player player, Dealer dealer, Deck deck)
        {
            Player = player;
            Dealer = dealer;
            Deck = deck;
            Deck.Shuffle();
        }
        public Player Player { get; }
        public Dealer Dealer { get; }
        public Deck Deck { get; }

        public int Play()
        {
            return 0;
        }
    }
}