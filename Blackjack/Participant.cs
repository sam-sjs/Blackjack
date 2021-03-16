
namespace Blackjack
{
    public interface IParticipant
    {
        public int Score { get; set; }
        public int PlayTurn();
        public void Hit(Card newCard);
    }
}