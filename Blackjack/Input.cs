
using System;

namespace Blackjack
{
    public class Input
    {
        public Choice ReceiveChoice()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "0" || input == "1") break;
                Console.WriteLine("Incorrect input please select again");
            }
            return input == "1" ? Choice.Hit : Choice.Stay;
        }
    }
}