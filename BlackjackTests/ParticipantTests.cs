using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class ParticipantTests
    {
        [Fact]
        public void GivenHit_WhenInputIsNull_ThenReturnCardObject()
        {
            Participant participant = new Participant();
            
            Card card = participant.Hit();
        
            Assert.NotNull(card);
        }
    }
}