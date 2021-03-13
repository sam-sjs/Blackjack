using Blackjack;
using Xunit;

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
    }
}