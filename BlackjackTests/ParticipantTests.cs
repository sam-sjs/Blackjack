using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class ParticipantTests
    {
        [Fact]
        public void GivenHit_WhenInputIsNull_ThenIncreaseScore()
        {
            Participant participant = new Participant();
            Card card = new Card(Value.Two, Suit.Clubs);
            int expected = 2;
        
            participant.Hit(card);
            int actual = participant.Score;

            Assert.Equal(expected, actual);
        }
    }
}