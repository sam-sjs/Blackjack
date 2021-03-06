using Blackjack;
using Blackjack.Card;
using Blackjack.Deck;
using Blackjack.Participant;
using Xunit;

namespace BlackjackTests.ParticipantTests
{
    public class ParticipantTests
    {
        [Fact]
        public void GivenHit_WhenInputIsDeck_ThenScoreIsIncreased()
        {
            Participant player = new Participant(Role.Player);
            Deck deck = new Deck();
        
            player.Hit(deck);
            int actual = player.GetScore();

            Assert.True(actual > 0);
        }

        [Fact]
        public void GivenGetScore_ThenReturnValueOfHand()
        {
            Participant player = new(Role.Player);
            player.Hand.Add(new Card(Value.Eight, Suit.Clubs));
            player.Hand.Add(new Card(Value.Queen, Suit.Clubs));
            int expected = 18;

            int actual = player.GetScore();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenGetScore_WhenAcePresent_ThenScoreReducesOver21()
        {
            Participant player = new(Role.Player);
            player.Hand.Add(new Card(Value.Queen, Suit.Clubs));
            player.Hand.Add(new Card(Value.Queen, Suit.Clubs));
            player.Hand.Add(new Card(Value.Ace, Suit.Clubs));
            int expected = 21;

            int actual = player.GetScore();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenCheckBust_WhenHandExceeds21_ThenReturnsTrue()
        {
            Participant player = new(Role.Player);
            player.Hand.Add(new Card(Value.King, Suit.Clubs));
            player.Hand.Add(new Card(Value.King, Suit.Clubs));
            player.Hand.Add(new Card(Value.King, Suit.Clubs));
            bool expected = true;

            bool actual = player.CheckBust();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenCheckBust_WhenHandExceeds21_ThenSetsIsBustToTrue()
        {
            Participant player = new(Role.Player);
            player.Hand.Add(new Card(Value.King, Suit.Clubs));
            player.Hand.Add(new Card(Value.King, Suit.Clubs));
            player.Hand.Add(new Card(Value.King, Suit.Clubs));

            player.CheckBust();
            bool actual = player.IsBust;

            Assert.True(actual);
        }
    }
}