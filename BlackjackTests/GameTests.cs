using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class GameTests
    {
        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesNew52CardDeck()
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            Input defaultInput = new();
            Output defaultOutput = new();
            int expected = 52;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultOutput);
            int actual = newGame.Deck.StandardDeck.Length;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenDetermineResult_ThenReturnResultEnum()
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            Input defaultInput = new();
            Output defaultOutput = new();
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultOutput);
            Card[] winning = new[] {new Card(Value.Jack, Suit.Clubs), new Card(Value.King, Suit.Clubs)};
            Card[] losing = new[] {new Card(Value.Nine, Suit.Clubs), new Card(Value.Five, Suit.Clubs)};
            defaultPlayer.Hand.AddRange(winning);
            defaultDealer.Hand.AddRange(losing);
            Result expected = Result.Win;

            Result actual = newGame.DetermineResult();

            Assert.Equal(expected, actual);
        }
    }
}