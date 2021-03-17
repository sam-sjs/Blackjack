
namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant player = new Participant();
            Participant dealer = new Participant();
            Deck deck = new Deck();
            InputOutput io = new InputOutput();
            Game game = new Game(player, dealer, deck, io);
            game.PlayGame();
        }
    }
}