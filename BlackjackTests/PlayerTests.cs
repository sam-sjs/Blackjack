using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class ParticipantTests
    {
        [Fact]
        public void GivenHit_WhenInputIsCard_ThenIncreaseScoreByCardValue()
        {
            Player participant = new Player();
            Card card = new Card(Value.Two, Suit.Clubs);
            int expected = 2;
        
            participant.Hit(card);
            int actual = participant.Score;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenPlayTurn_WhenInputIsNull_ThenReturn0()
        {
            Player participant = new Player();
            int expected = 0;

            int actual = participant.PlayTurn();

            Assert.Equal(expected, actual);
        }
    }
}