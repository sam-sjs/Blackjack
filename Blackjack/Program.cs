
namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant player = new Participant(Role.Player);
            Participant dealer = new Participant(Role.Dealer);
            Deck deck = new Deck();
            ConsoleInput input = new ConsoleInput();
            ConsoleOutput output = new ConsoleOutput();
            Message message = new Message(output);
            Game game = new Game(player, dealer, deck, input, message);
            game.PlayGame();
        }
    }
}