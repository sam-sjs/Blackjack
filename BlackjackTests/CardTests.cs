using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class CardTests
    {
        [Fact]
        public void GivenCard_WhenInputIsTwoStrings_ThenShouldCreateWithRespectiveProperties()
        {
            string input1 = "KING";
            string input2 = "HEARTS";

            Card actual = new Card(input1, input2);
            
            Assert.Equal(input1, actual.Value);
            Assert.Equal(input2, actual.Suit);
        }
    }
}