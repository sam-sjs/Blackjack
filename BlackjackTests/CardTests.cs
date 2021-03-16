using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class CardTests
    {
        [Fact]
        public void GivenCard_WhenInputIsTwoEnums_ThenShouldCreateWithRespectiveProperties()
        {
            Value expectedValue = Value.King;
            Suit expectedSuit = Suit.Hearts;

            Card actual = new Card(expectedValue, expectedSuit);
            
            Assert.Equal(expectedValue, actual.Value);
            Assert.Equal(expectedSuit, actual.Suit);
        }

        [Fact]
        public void GivenTwoCards_WhenSameValueAndSuit_ThenShouldBeEqual()
        {
            Card expected = new Card(Value.Two, Suit.Hearts);

            Card actual = new Card(Value.Two, Suit.Hearts);

            Assert.True(expected.Equals(actual));
        }
        
        [Theory]
        [InlineData(Value.Two, 2)]
        [InlineData(Value.Seven, 7)]
        [InlineData(Value.King, 10)]
        [InlineData(Value.Ace, 11)]
        public void GivenGetCardValue_WhenInputIsStringValue_ThenReturnValueAsInt(Value input, int expected)
        {
            Card card = new Card(input, Suit.Clubs);
            
            int actual = card.GetCardValue();

            Assert.Equal(expected, actual);
        }
    }
}