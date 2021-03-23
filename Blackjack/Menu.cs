
using System;

namespace Blackjack
{
    public class Menu
    {
        private IInput _input;

        public Menu(IInput consoleInput)
        {
            _input = consoleInput;
        }
        public Choice ReceiveChoice()
        {
            string input;
            while (true)
            {
                input = _input.ReadLine();
                if (input == "0" || input == "1") break;
                Console.WriteLine("Incorrect input please select again");
            }
            return input == "1" ? Choice.Hit : Choice.Stay;
        }
    }
}