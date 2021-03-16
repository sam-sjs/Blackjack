
namespace Blackjack
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
            else {
                Card p = (Card) obj;
                return (Value == p.Value) && (Suit == p.Suit);
            }
        }
        
        public int GetCardValue()
        {
            if (Value == Value.Jack || Value == Value.Queen || Value == Value.King) return 10;
            if (Value == Value.Ace) return 11;
            return (int)Value;
        }
    }
}