using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NumberGuessing
{
    partial class Program
    {
        // adjust ratings (way off, not quite, close, very close, correct)
        //public enum Rating { Correct = 0, Close = 2, Off = 4, WayOff = 5 }

        static Result Guess(int guess)
        {
            Result result;
            //result.isCorrect = false;
            //result.rankMessage = "";

            int offBy = Math.Abs(theNumber - guess);

            if (offBy == (int)Rating.Correct)
            {
                result.isCorrect = true;
                result.rankMessage = "You are correct!";
                result.offBy = offBy;
            }

            else if (offBy > (int)Rating.Correct && offBy <= (int)Rating.Close)
            {
                result.isCorrect = false;
                result.rankMessage = "You are very close.";
                result.offBy = offBy;
            }
            else if (offBy > (int)Rating.Close && offBy <= (int)Rating.Off)
            {
                result.isCorrect = false;
                result.rankMessage = "You are off by a little bit.";
                result.offBy = offBy;
            }
            else if (offBy > (int)Rating.Off && offBy <= (int)Rating.WayOff)
            {
                result.isCorrect = false;
                result.rankMessage = "You are way off.";
                result.offBy = offBy;
            }
            else if (offBy > (int)Rating.WayOff)
            {
                result.isCorrect = false;
                result.rankMessage = "So very wrong.";
                result.offBy = offBy;
            }
            else //err
            {
                result.isCorrect = false;
                result.rankMessage = "Error. You broke it.";
                result.offBy = offBy;
            }

            return result;
        }
    }
}
