using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class GameTests
    {
        private readonly Participant _defaultPlayer = new();
        private readonly Participant _defaultDealer = new();
        private readonly Deck _defaultDeck = new();
        
        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesPlayerWithScore0()
        {
            int expected = 0;
            
            Game newGame = new Game(_defaultPlayer, _defaultDealer, _defaultDeck);
            int actual = newGame.Player.Score;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesDealerWithScore0()
        {
            int expected = 0;
            
            Game newGame = new Game(_defaultPlayer, _defaultDealer, _defaultDeck);
            int actual = newGame.Dealer.Score;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesNew52CardDeck()
        {
            int expected = 52;
            
            Game newGame = new Game(_defaultPlayer, _defaultDealer, _defaultDeck);
            int actual = newGame.Deck.StandardDeck.Length;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayTurn_WhenInputIsNull_ThenReturn0()
        {
            int expected = 0;
            
            Game newGame = new Game(_defaultPlayer, _defaultDealer, _defaultDeck);
            int actual = newGame.PlayTurn();

            Assert.Equal(expected, actual);
        }
    }
}