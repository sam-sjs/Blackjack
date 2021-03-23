using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class GameTests
    {
        [Fact]
        public void GivenGame_WhenInputIsNull_ThenCreatesNew52CardDeck()
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            ConsoleInput defaultInput = new();
            Output defaultOutput = new();
            int expected = 52;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultOutput);
            int actual = newGame.Deck.StandardDeck.Length;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenDetermineResult_ThenReturnGameOutcomeEnum()
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            ConsoleInput defaultInput = new();
            Output defaultOutput = new();
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultOutput);
            Card[] winning = { new (Value.Jack, Suit.Clubs), new (Value.King, Suit.Clubs) };
            Card[] losing = { new (Value.Nine, Suit.Clubs), new (Value.Five, Suit.Clubs) };
            defaultPlayer.Hand.AddRange(winning);
            defaultDealer.Hand.AddRange(losing);
            Result expected = Result.Win;

            Result actual = newGame.DetermineResult();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenDealerShouldHit_WhenScoreIsLessThan17_ThenReturnTrue()
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            ConsoleInput defaultInput = new();
            Output defaultOutput = new();
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultOutput);
            Card[] scoreEquals15 = {new (Value.Jack, Suit.Clubs), new (Value.Five, Suit.Clubs)};
            defaultDealer.Hand.AddRange(scoreEquals15);

            bool actual = newGame.DealerShouldHit();

            Assert.True(actual);
        }
        
        [Fact]
        public void WhenInputIs1_ThenChoiceShouldBeHit()
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            TestInput testInput = new("1");
            Output defaultOutput = new();
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, testInput, defaultOutput);

            Choice actual = newGame.ReceiveChoice();

            Assert.Equal(Choice.Hit, actual);
        }

        [Fact]
        public void WhenInputIs0_ThenChoiceShouldBeStay()
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            TestInput testInput = new("0");
            Output defaultOutput = new();
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, testInput, defaultOutput);

            Choice actual = newGame.ReceiveChoice();

            Assert.Equal(Choice.Stay, actual);
        }

        [Fact]
        public void WhenInputIsInvalid_ThenShouldAskForNewInput()
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            TestInput testInput = new("Q", "1");
            Output defaultOutput = new();
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, testInput, defaultOutput);
            
            Choice actual = newGame.ReceiveChoice();

            Assert.Equal(Choice.Hit, actual);
        }
    }
}