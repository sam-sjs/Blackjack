using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class ParticipantTests
    {
        [Fact]
        public void GivenHit_WhenInputIsNull_ThenIncreaseScoreByValueOfCard()
        {
            Participant participant = new Participant();
        
            participant.Hit();
            int actual = participant.Score;
        
            Assert.True(actual > 0);
        }
    }
}