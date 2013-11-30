using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NumberGuessing
{

    partial class Program
    {
        static void Initialize()
        {
            myResult.rankMessage = "";
            guessesRemaining = 3;

            // need to adjust how we receive input so this can be split up properly
            difficultySetting = GetDifficulty();

            // adjust ratings (way off, not quite, close, very close, correct)

            // get a random number in selected range
            theNumber = GetRandomNumber(difficultySetting);

             //Console.Read();

        }
    }
}
