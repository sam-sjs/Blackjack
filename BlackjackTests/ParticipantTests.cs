using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class ParticipantTests
    {
        [Fact]
        public void GivenHit_WhenInputIsDeck_ThenScoreIsIncreased()
        {
            Participant player = new Participant();
            Deck deck = new Deck();
        
            player.Hit(deck);
            int actual = player.Score;

            Assert.True(actual > 0);
        }

        // [Fact]
        // public void GivenPlayTurn_WhenInputIsNull_ThenReturn0()
        // {
        //     Player participant = new Player();
        //     Deck deck = new Deck();
        //     int expected = 0;
        //
        //     int actual = participant.PlayTurn(deck);
        //
        //     Assert.Equal(expected, actual);
        // }
    }
}