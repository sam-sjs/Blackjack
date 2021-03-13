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

        // This test will fail sometimes when card ends up in same location in deck.  How do I test randomness?
        [Theory]
        [InlineData(0)]
        [InlineData(51)]
        [InlineData(20)]
        
        public void GivenShuffle_WhenInputIsNull_ThenShouldReturnArrayWithDifferentOrder(int index)
        {
            Deck newDeck = new Deck();
            string expected = newDeck.StandardDeck[index].Value + newDeck.StandardDeck[index].Suit;
            
            newDeck.Shuffle();
            string actual = newDeck.StandardDeck[index].Value + newDeck.StandardDeck[index].Suit;

            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void GivenDraw_WhenInputIsNull_ThenShouldReturnFirstCardInDeck()
        {
            Deck newDeck = new Deck();
            string expectedValue = "2";
            string expectedSuit = "HEARTS";

            Card firstDraw = newDeck.Draw();
            string actualValue = firstDraw.Value;
            string actualSuit = firstDraw.Suit;

            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSuit, actualSuit);
        }
    }
}