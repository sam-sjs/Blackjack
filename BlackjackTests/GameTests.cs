using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class GameTests
    {
        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesPlayerWithScore0()
        {
            Player defaultPlayer = new();
            Dealer defaultDealer = new();
            Deck defaultDeck = new();
            InputOutput defaultIo = new();
            int expected = 0;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultIo);
            int actual = newGame.Player.Score;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesDealerWithScore0()
        {
            Player defaultPlayer = new();
            Dealer defaultDealer = new();
            Deck defaultDeck = new();
            InputOutput defaultIo = new();
            int expected = 0;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultIo);
            int actual = newGame.Dealer.Score;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesNew52CardDeck()
        {
            Player defaultPlayer = new();
            Dealer defaultDealer = new();
            Deck defaultDeck = new();
            InputOutput defaultIo = new();
            int expected = 52;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultIo);
            int actual = newGame.Deck.StandardDeck.Length;

            Assert.Equal(expected, actual);
        }

        // [Fact]
        // public void GivenPlayGame_WhenInputIsNull_ThenReturn0()
        // {
        //     int expected = 0;
        //     
        //     Game newGame = new Game(_defaultPlayer, _defaultDealer, _defaultDeck);
        //     int actual = newGame.PlayGame();
        //
        //     Assert.Equal(expected, actual);
        // }
    }
}