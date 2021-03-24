
namespace Blackjack.Card
{
    public class Card
    {
        public Card(Value value, Suit suit)
        {
            Value = value;
            Suit = suit;
        }

        public Value Value { get; }
        public Suit Suit { get; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Card p = (Card) obj;
            return (Value == p.Value) && (Suit == p.Suit);
        }
        
        public int GetCardValue()
        {
            switch (Value)
            {
                case Value.Jack:
                case Value.Queen:
                case Value.King:
                    return 10;
                case Value.Ace:
                    return 11;
                default:
                    return (int)Value;
            }
        }
    }
}