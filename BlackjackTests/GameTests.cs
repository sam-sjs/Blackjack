using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class GameTests
    {
        // Feel like I skipped over some testing - this test required me to create Game, Participant & Player but
        // couldn't figure out how to break up the testing more.
        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesPlayerWithScore0()
        {
            int expected = 0;
            
            int actual = Game.Player.Score;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesDealerWithScore0()
        {
            int expected = 0;

            int actual = Game.Dealer.Score;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesNew52CardDeck()
        {
            int expected = 52;

            int actual = Game.Deck.StandardDeck.Length;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayTurn_WhenInputIsNull_ThenReturn0()
        {
            int expected = 0;

            int actual = Game.PlayTurn();

            Assert.Equal(expected, actual);
        }
    }
}