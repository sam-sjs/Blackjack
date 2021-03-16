
namespace Blackjack
{
    public static class Game
    {
        static Game()
        {
            Player = new Participant();
            Dealer = new Participant();
            Deck = new Deck();
            Deck.Shuffle();
        }
        public static Participant Player { get; }
        public static Participant Dealer { get; }
        public static Deck Deck { get; }

        public static int PlayTurn()
        {
            return 0;
        }
    }
}