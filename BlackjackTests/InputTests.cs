using Blackjack;
using Xunit;

namespace BlackjackTests
{
    public class InputTests
    {
        [Fact]
        public void WhenInputIs1_ThenChoiceShouldBeHit()
        {
            Menu menu = new Menu(new TestInput("1"));

            var actual = menu.ReceiveChoice();

            Assert.Equal(Choice.Hit, actual);
        }

        [Fact]
        public void WhenInputIs0_ThenChoiceShouldBeStay()
        {
            Menu menu = new Menu(new TestInput("0"));
            
            var actual = menu.ReceiveChoice();

            Assert.Equal(Choice.Stay, actual);
        }
    }
}