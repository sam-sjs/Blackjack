using System.Runtime.InteropServices;
using Blackjack;
using Xunit;
using Xunit.Sdk;

namespace BlackjackTests
{
    public class GameTests
    {
        // Feel like I skipped over some testing - this test required me to create Game, Participant & Player but
        // couldn't figure out how to break up the testing more.
        [Fact]
        public void GivenNewGame_WhenInputIsNull_ThenCreatesGameWithPlayerScore0()
        {
            int expected = 0;
            
            Game game = new Game();
            int actual = game.Player.Score;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenNewGame_WhenInputIsNull_ThenCreatesDealerWithScore0()
        {
            int expected = 0;

            Game game = new Game();
            int actual = game.Dealer.Score;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayTurn_WhenInputIsNull_ThenReturn0()
        {
            int expected = 0;

            Game game = new Game();
            int actual = game.PlayTurn();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenHit_WhenInputIsNull_ThenReturn0()
        {
            int expected = 0;

            Game game = new Game();
            int actual = game.Hit();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2", 2)]
        [InlineData("K", 10)]
        [InlineData("A", 11)]
        public void GivenGetCardValue_WhenInputIsStringValue_ThenReturnValueAsInt(string input, int expected)
        {
            Game game = new Game();
            int actual = game.GetCardValue(input);

            Assert.Equal(expected, actual);
        }
    }
}