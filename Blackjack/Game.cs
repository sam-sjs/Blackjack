using System;

namespace Blackjack
{
    public class Game
    {
        public Game()
        {
            Player = new Player();
            Dealer = new Dealer();
        }
        public Player Player { get; }
        public Dealer Dealer { get; }

        public int PlayTurn()
        {
            return 0;
        }

        public int Hit()
        {
            return 0;
        }

        public int GetCardValue(string value)
        {
            if (value == "J" || value == "Q" || value == "K") return 10;
            if (value == "A") return 11;
            return Int32.Parse(value);
        }
    }
}