using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class GameTests
    {
        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesPlayerWithScore0()
        {
            Participant defaultPlayer = new();
            Participant defaultDealer = new();
            Deck defaultDeck = new();
            Input defaultInput = new();
            Output defaultOutput = new();
            int expected = 0;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultOutput);
            int actual = newGame.Player.Score;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesDealerWithScore0()
        {
            Participant defaultPlayer = new();
            Participant defaultDealer = new();
            Deck defaultDeck = new();
            Input defaultInput = new();
            Output defaultOutput = new();
            int expected = 0;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultOutput);
            int actual = newGame.Dealer.Score;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesNew52CardDeck()
        {
            Participant defaultPlayer = new();
            Participant defaultDealer = new();
            Deck defaultDeck = new();
            Input defaultInput = new();
            Output defaultOutput = new();
            int expected = 52;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultOutput);
            int actual = newGame.Deck.StandardDeck.Length;

            Assert.Equal(expected, actual);
        }
    }
}