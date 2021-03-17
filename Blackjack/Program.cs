
namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Dealer dealer = new Dealer();
            Deck deck = new Deck();
            InputOutput io = new InputOutput();
            Game game = new Game(player, dealer, deck, io);
            game.PlayGame();
        }
    }
}