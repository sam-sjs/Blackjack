namespace Blackjack
{
    public class Deck
    {
        public Card[] StandardDeck { get; set; } = 
        {
            new("2", "HEARTS"), new("3", "HEARTS"), new("4", "HEARTS"),
            new("5", "HEARTS"), new("6", "HEARTS"), new("7", "HEARTS"),
            new("8", "HEARTS"), new("9", "HEARTS"), new("10", "HEARTS"),
            new("J", "HEARTS"), new("Q", "HEARTS"), new("K", "HEARTS"),
            new("A", "HEARTS"), new("2", "SPADES"), new("3", "SPADES"),
            new("4", "SPADES"), new("5", "SPADES"), new("6", "SPADES"),
            new("7", "SPADES"), new("8", "SPADES"), new("9", "SPADES"),
            new("10", "SPADES"), new("J", "SPADES"), new("Q", "SPADES"),
            new("K", "SPADES"), new("A", "SPADES"), new("2", "DIAMONDS"),
            new("3", "DIAMONDS"), new("4", "DIAMONDS"), new("5", "DIAMONDS"),
            new("6", "DIAMONDS"), new("7", "DIAMONDS"), new("8", "DIAMONDS"),
            new("9", "DIAMONDS"), new("10", "DIAMONDS"), new("J", "DIAMONDS"),
            new("Q", "DIAMONDS"), new("K", "DIAMONDS"), new("A", "DIAMONDS"),
            new("2", "CLUBS"), new("3", "CLUBS"), new("4", "CLUBS"),
            new("5", "CLUBS"), new("6", "CLUBS"), new("7", "CLUBS"),
            new("8", "CLUBS"), new("9", "CLUBS"), new("10", "CLUBS"),
            new("J", "CLUBS"), new("Q", "CLUBS"), new("K", "CLUBS"),
            new("A", "CLUBS")
        };
        // Card[] deck =
        // {
        //     new("2", "HEARTS"), new("3", "HEARTS"), new("4", "HEARTS"),
        //     new("5", "HEARTS"), new("6", "HEARTS"), new("7", "HEARTS"),
        //     new("8", "HEARTS"), new("9", "HEARTS"), new("10", "HEARTS"),
        //     new("J", "HEARTS"), new("Q", "HEARTS"), new("K", "HEARTS"),
        //     new("A", "HEARTS"), new("2", "SPADES"), new("3", "SPADES"),
        //     new("4", "SPADES"), new("5", "SPADES"), new("6", "SPADES"),
        //     new("7", "SPADES"), new("8", "SPADES"), new("9", "SPADES"),
        //     new("10", "SPADES"), new("J", "SPADES"), new("Q", "SPADES"),
        //     new("K", "SPADES"), new("A", "SPADES"), new("2", "DIAMONDS"),
        //     new("3", "DIAMONDS"), new("4", "DIAMONDS"), new("5", "DIAMONDS"),
        //     new("6", "DIAMONDS"), new("7", "DIAMONDS"), new("8", "DIAMONDS"),
        //     new("9", "DIAMONDS"), new("10", "DIAMONDS"), new("J", "DIAMONDS"),
        //     new("Q", "DIAMONDS"), new("K", "DIAMONDS"), new("A", "DIAMONDS"),
        //     new("2", "CLUBS"), new("3", "CLUBS"), new("4", "CLUBS"),
        //     new("5", "CLUBS"), new("6", "CLUBS"), new("7", "CLUBS"),
        //     new("8", "CLUBS"), new("9", "CLUBS"), new("10", "CLUBS"),
        //     new("J", "CLUBS"), new("Q", "CLUBS"), new("K", "CLUBS"),
        //     new("A", "CLUBS")
        // };
    }
}