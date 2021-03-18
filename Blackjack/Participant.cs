
using System.Collections.Generic;

namespace Blackjack
{
    public class Participant
    {
        public Participant(Role role)
        {
            Role = role;
        }

        private const int HighestScore = 21;
        private const int AceHighLowDifference = 10;
        public Role Role { get; }
        public List<Card> Hand { get; } = new();
        public void Hit(Deck deck, int cards = 1)
        {
            for (int i = 0; i < cards; i++)
            {
                Card newCard = deck.Draw();
                Hand.Add(newCard);
            }
        }

        public int GetScore()
        {
            int score = 0;
            int aceCount = 0;
            foreach (Card card in Hand)
            {
                score += card.GetCardValue();
                if (card.Value == Value.Ace) aceCount++;
            }

            while (score > HighestScore && aceCount > 0)
            {
                score -= AceHighLowDifference;
                aceCount -= 1;
            }

            return score;
        }
    }
}