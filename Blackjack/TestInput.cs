
namespace Blackjack
{
    public class TestInput : IInput
    {
        private string _choice;
        private string _choice2;
        private int _timesCalled;
        public TestInput(string choice, string choice2 = "")
        {
            _choice = choice;
            _choice2 = choice2;
        }
        public string ReadLine()
        {
            if (_timesCalled == 0)
            {
                _timesCalled++;
                return _choice;
            }
            return _choice2;
        }
    }
}