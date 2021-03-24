using System;

namespace Blackjack.Input
{
    public class ConsoleInput : IInput
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}