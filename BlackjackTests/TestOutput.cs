using System;
using Blackjack;

namespace BlackjackTests
{
    public class TestOutput : IOutput
    {
        public string Message;
        public void WriteLine()
        {
            
        }

        public void WriteLine(string message)
        {
            Message = message;
        }

        public void Write(string message)
        {
            Message = message;
        }
    }
}