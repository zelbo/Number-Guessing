using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NumberGuessing
{
    // todo:
    // tell how close (way off, not quite, close, very close, correct)
    // give 3 tries
    // need to get used to using {get; set;}
    // move enums and constants to Common.cs?
    // maybe create a player object that contains number of guesses, win state, current guess...
    // break it up so we're not using 'partial class Program' everywhere, decouple a little bit.
    // starting to get some magic numbers. need constants maybe.

    partial class Program
    {
        public static GameState gameState = GameState.Initialize;
        static bool exitProgram = false;
        public static int theNumber;
        public static Result myResult;
        public static int guessesRemaining { get; set; } // need to figure out this get/set stuff
        public static string errorMessage;
            
        static void Main(string[] args)
        {
            while (!exitProgram)
            {
                Input();
                Update();
                Render();
            }
            // maybe have a "thanks for playing!" message followed by a short pause?
            // if so, probably put it in the game exit cleanup section instead of here...
        }
    }
}
