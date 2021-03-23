using Blackjack;

namespace BlackjackTests
{
    public class TestInput : IInput
    {
        private string _choice;
        public TestInput(string choice)
        {
            _choice = choice;
        }
        public string ReadLine()
        {
            return _choice;
        }
    }
}