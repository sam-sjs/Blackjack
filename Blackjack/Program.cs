
namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Dealer dealer = new Dealer();
            Deck deck = new Deck();
            Game game = new Game(player, dealer, deck);
            game.Play();
        }
    }
}