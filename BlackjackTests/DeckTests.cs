using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class DeckTests
    {
        [Fact]
        public void GivenDeck_WhenInputIsNull_ThenShouldGenerate52CardDeck()
        {
            int expected = 52;
            
            Deck actual = new Deck();

            Assert.Equal(expected, actual.StandardDeck.Length);
        }
    }
}