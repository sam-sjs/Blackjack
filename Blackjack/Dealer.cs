using System.Collections.Generic;

namespace Blackjack
{
    public class Dealer : IParticipant
    {
        public int Score { get; set; }
        public List<Card> Hand { get; set; } = new();
        public void Hit(Deck deck, int cards = 1)
        {
            for (int i = 0; i < cards; i++)
            {
                Card newCard = deck.Draw();
                Score += newCard.GetCardValue();
                Hand.Add(newCard);
            }
        }
    }
}