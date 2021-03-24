using Blackjack.Message;
using BlackjackTests.Output;
using Xunit;

namespace BlackjackTests.MessageTests
{
    public class MessageTests
    {
        [Fact]
        public void PresentChoice_ShouldHaveCorrectMessage()
        {
            TestOutput output = new TestOutput();
            Message message = new Message(output);
            string expected = "Hit or stay? (Hit = 1, Stay = 0)";
            
            message.PresentChoice();
            
            Assert.Equal(expected, output.Message);
        }
    }
}