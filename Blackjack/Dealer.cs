namespace Blackjack
{
    public class Dealer : IParticipant
    {
        public int Score { get; set; }
        
        public int PlayTurn()
        {
            InputOutput io = new InputOutput();
            // io.DisplayHand();
            Choice choice = io.ReceiveChoice();
            // Can I simulate receiving a choice?  Either way need an "if" here for hit/stay
            return 0;
        }
        
        public void Hit(Card newCard)
        {
            Score += newCard.GetCardValue();
        }
    }
}