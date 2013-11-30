using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessing
{
    partial class Program
    {
        public static bool doDebug = false;
        static void MyDebug()
        {
            if (doDebug)
            {
                Console.WriteLine("Debug information:");

                Console.Write("The number = ");
                Console.WriteLine(theNumber.ToString());

                Console.WriteLine("Off by: {0}", myResult.offBy);

                Console.WriteLine("Guesses remaining {0}", guessesRemaining.ToString());

                Console.Write("Current game state = ");
                Console.WriteLine(gameState.ToString());
            }
        }
    }
}
