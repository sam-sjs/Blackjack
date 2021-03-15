namespace Blackjack
{
    public class Participant
    {
        public int Score { get; set; } = 0;
        
        public Card Hit()
        {
            Card newCard = Game.Deck.Draw();
            return newCard;
        }
    }
}