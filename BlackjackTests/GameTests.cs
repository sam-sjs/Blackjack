using System;
using System.Collections.Generic;
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
            ConsoleOutput defaultOutput = new();
            Message defaultMessage = new(defaultOutput);
            int expected = 52;
            
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultMessage);
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
            ConsoleOutput defalutOutput = new();
            Message defaultMessage = new(defalutOutput);
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultMessage);
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
            ConsoleOutput defalutOutput = new();
            Message defaultMessage = new(defalutOutput);
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, defaultInput, defaultMessage);
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
            List<string> inputs = new List<string> {"1"};
            TestInput testInput = new(inputs);
            ConsoleOutput defalutOutput = new();
            Message defaultMessage = new(defalutOutput);
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, testInput, defaultMessage);

            Choice actual = newGame.ReceiveChoice();

            Assert.Equal(Choice.Hit, actual);
        }

        public static IEnumerable<object[]> GetInputs()
        {
            yield return new object[] {new List<string> {"0"}, Choice.Stay};
            yield return new object[] {new List<string> {"Q", "1"}, Choice.Hit};
            yield return new object[] {new List<string> {"Q", "8", "1"}, Choice.Hit};
        }

        [Theory]
        [MemberData(nameof(GetInputs))]
        public void GivenReceiveChoice_ShouldAwaitValidInput(List<string> inputs, Choice expected)
        {
            Participant defaultPlayer = new(Role.Player);
            Participant defaultDealer = new(Role.Dealer);
            Deck defaultDeck = new();
            TestInput testInput = new(inputs);
            ConsoleOutput defalutOutput = new();
            Message defaultMessage = new(defalutOutput);
            Game newGame = new Game(defaultPlayer, defaultDealer, defaultDeck, testInput, defaultMessage);

            Choice actual = newGame.ReceiveChoice();

            Assert.Equal(expected, actual);
        }
    }
}