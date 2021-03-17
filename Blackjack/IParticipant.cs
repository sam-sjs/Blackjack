
using System.Collections.Generic;

namespace Blackjack
{
    public interface IParticipant
    {
        public int Score { get; set; }
        public List<Card> Hand { get; set; }
        public void Hit(Deck deck, int cards = 1);
    }
}