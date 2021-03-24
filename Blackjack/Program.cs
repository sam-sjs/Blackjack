
using Blackjack.Input;
using Blackjack.Output;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant.Participant player = new Participant.Participant(Role.Player);
            Participant.Participant dealer = new Participant.Participant(Role.Dealer);
            Deck.Deck deck = new Deck.Deck();
            ConsoleInput input = new ConsoleInput();
            ConsoleOutput output = new ConsoleOutput();
            Message.Message message = new Message.Message(output);
            Game.Game game = new Game.Game(player, dealer, deck, input, message);
            game.PlayGame();
        }
    }
}