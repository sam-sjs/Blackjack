using Blackjack;
using Blackjack.Card;
using Blackjack.Deck;
using Xunit;

namespace BlackjackTests.DeckTests
{
    public class DeckTests
    {
        [Fact]
        public void GivenDeck_WhenInputIsNull_ThenShouldGenerate52CardDeck()
        {
            int expected = 52;
            
            Deck deck = new Deck();
            int actual = deck.StandardDeck.Length;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenShuffle_ThenShouldRandomiseArrayOrder()
        {
            Deck unshuffled = new Deck();
            Deck shuffled = new Deck();
            
            shuffled.Shuffle();

            Assert.NotEqual(unshuffled, shuffled);

        }

        [Fact]
        public void WhenDraw_ThenShouldReturnFirstCardInDeck()
        {
            Deck newDeck = new Deck();
            Value expectedValue = Value.Two;
            Suit expectedSuit = Suit.Hearts;

            Card firstDraw = newDeck.Draw();
            Value actualValue = firstDraw.Value;
            Suit actualSuit = firstDraw.Suit;

            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSuit, actualSuit);
        }
    }
}