
namespace Blackjack
{
    public class Card
    {
        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
        }

        public string Value { get; }
        public string Suit { get; }
    }
}