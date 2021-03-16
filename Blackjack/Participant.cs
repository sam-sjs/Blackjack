
namespace Blackjack
{
    public class Participant
    {
        public int Score { get; set; } = 0;
        
        public void Hit()
        {
            Card newCard = Game.Deck.Draw();
            Score += newCard.GetCardValue();
        }
    }
}