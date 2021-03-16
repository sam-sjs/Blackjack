
namespace Blackjack
{
    public class Game
    {
        public Game(Participant player, Participant dealer, Deck deck)
        {
            Player = player;
            Dealer = dealer;
            Deck = deck;
            Deck.Shuffle();
        }
        public Participant Player { get; }
        public Participant Dealer { get; }
        public Deck Deck { get; }

        public int PlayTurn()
        {
            return 0;
        }
    }
}