using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NumberGuessing
{
    partial class Program
    {
        // takes an argument that tells whether player won or lost
        // returns whether the player wants to play again
        public static bool GameOver(bool isWinner)
        {
            //while (Console.KeyAvailable) Console.ReadKey();

            string message;
            bool playAgain = false;

            if (isWinner) message = "You won!";
            else message = "Someone has to loose. This time that someone is you.";

            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("Press the spacebar to play again, any other key to quit.");

            while (!Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar) playAgain = true;
                else playAgain = false;
                break;
            }
            return playAgain;
        }
    }
}
