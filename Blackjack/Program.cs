
namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant player = new Participant(Role.Player);
            Participant dealer = new Participant(Role.Dealer);
            Deck deck = new Deck();
            Input input = new Input();
            Output output = new Output();
            Game game = new Game(player, dealer, deck, input, output);
            game.PlayGame();
        }
    }
}