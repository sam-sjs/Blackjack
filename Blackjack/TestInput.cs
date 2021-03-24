
using System.Collections.Generic;

namespace Blackjack
{
    public class TestInput : IInput
    {
        private int _timesCalled = 0;
        private readonly IList<string> _inputs;
        public TestInput(IList<string> inputs)
        {
            _inputs = inputs;
        }
        public string ReadLine()
        {
            return _inputs[_timesCalled++];
        }
    }
}