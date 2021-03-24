using System;
using System.Linq;

namespace Blackjack.Deck
{
    public class Deck
    {
        private int _nextDraw;
        public Card.Card[] StandardDeck { get; private set; } = 
        {
            new(Value.Two, Suit.Hearts), new(Value.Three, Suit.Hearts), new(Value.Four, Suit.Hearts),
            new(Value.Five, Suit.Hearts), new(Value.Six, Suit.Hearts), new(Value.Seven, Suit.Hearts),
            new(Value.Eight, Suit.Hearts), new(Value.Nine, Suit.Hearts), new(Value.Ten, Suit.Hearts),
            new(Value.Jack, Suit.Hearts), new(Value.Queen, Suit.Hearts), new(Value.King, Suit.Hearts),
            new(Value.Ace, Suit.Hearts), new(Value.Two, Suit.Spades), new(Value.Three, Suit.Spades),
            new(Value.Four, Suit.Spades), new(Value.Five, Suit.Spades), new(Value.Six, Suit.Spades),
            new(Value.Seven, Suit.Spades), new(Value.Eight, Suit.Spades), new(Value.Nine, Suit.Spades),
            new(Value.Ten, Suit.Spades), new(Value.Jack, Suit.Spades), new(Value.Queen, Suit.Spades),
            new(Value.King, Suit.Spades), new(Value.Ace, Suit.Spades), new(Value.Two, Suit.Diamonds),
            new(Value.Three, Suit.Diamonds), new(Value.Four, Suit.Diamonds), new(Value.Five, Suit.Diamonds),
            new(Value.Six, Suit.Diamonds), new(Value.Seven, Suit.Diamonds), new(Value.Eight, Suit.Diamonds),
            new(Value.Nine, Suit.Diamonds), new(Value.Ten, Suit.Diamonds), new(Value.Jack, Suit.Diamonds),
            new(Value.Queen, Suit.Diamonds), new(Value.King, Suit.Diamonds), new(Value.Ace, Suit.Diamonds),
            new(Value.Two, Suit.Clubs), new(Value.Three, Suit.Clubs), new(Value.Four, Suit.Clubs),
            new(Value.Five, Suit.Clubs), new(Value.Six, Suit.Clubs), new(Value.Seven, Suit.Clubs),
            new(Value.Eight, Suit.Clubs), new(Value.Nine, Suit.Clubs), new(Value.Ten, Suit.Clubs),
            new(Value.Jack, Suit.Clubs), new(Value.Queen, Suit.Clubs), new(Value.King, Suit.Clubs),
            new(Value.Ace, Suit.Clubs)
        };

        public void Shuffle()
        {
            Random randomiser = new Random();
            
            StandardDeck = StandardDeck.OrderBy(_ => randomiser.Next()).ToArray();
        }

        public Card.Card Draw()
        {
            _nextDraw++;
            return StandardDeck[_nextDraw - 1];
        }
    }
}