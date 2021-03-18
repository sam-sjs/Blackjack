using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class ParticipantTests
    {
        [Fact]
        public void GivenHit_WhenInputIsDeck_ThenScoreIsIncreased()
        {
            Participant player = new Participant(Role.Player);
            Deck deck = new Deck();
        
            player.Hit(deck);
            int actual = player.Score;

            Assert.True(actual > 0);
        }
    }
}