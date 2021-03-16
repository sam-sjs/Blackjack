
namespace Blackjack
{
    public class Participant
    {
        public int Score { get; private set; }
        
        public void Hit(Card newCard)
        {
            Score += newCard.GetCardValue();
        }
    }
}