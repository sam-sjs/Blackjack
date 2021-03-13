namespace Blackjack
{
    public class Game
    {
        public Game()
        {
            Player = new Player();
            Dealer = new Dealer();
        }
        public Player Player { get; }
        public Dealer Dealer { get; }
    }
}