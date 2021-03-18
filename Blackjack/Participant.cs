
using System.Collections.Generic;

namespace Blackjack
{
    public class Participant
    {
        public Participant(Role role)
        {
            Role = role;
        }
        private const int AceValue = 11;
        public Role Role { get; set; }
        public int Score { get; set; }
        public int AceCount { get; set; }
        public List<Card> Hand { get; set; } = new();
        public void Hit(Deck deck, int cards = 1)
        {
            for (int i = 0; i < cards; i++)
            {
                Card newCard = deck.Draw();
                int cardValue = newCard.GetCardValue();
                Score += cardValue;
                if (cardValue == AceValue) AceCount++;
                Hand.Add(newCard);
            }
        }
    }
}