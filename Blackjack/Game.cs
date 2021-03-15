using System;

namespace Blackjack
{
    public class Game
    {
        public Game()
        {
            Player = new Participant();
            Dealer = new Participant();
            Deck = new Deck();
            Deck.Shuffle();
        }
        public Participant Player { get; }
        public Participant Dealer { get; }
        public Deck Deck { get; }

        public int PlayTurn()
        {
            return 0;
        }

        // This will break because enums
        public int GetCardValue(string value)
        {
            if (value == "J" || value == "Q" || value == "K") return 10;
            if (value == "A") return 11;
            return Int32.Parse(value);
        }
    }
}