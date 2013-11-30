using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NumberGuessing
{
    partial class Program
    {
        static int myNumberMin = 0;
        static int myNumberMax = 0;
        const int myNumberOffset = 1;
        static Random random = new Random();

        static int GetRandomNumber(int setting)
        {
            Debug.Assert(setting > 0);
            Debug.Assert(setting < 4);

            int myNumber = 0;

            switch (setting)
            {
                case 1:
                    myNumberMax = 10;
                    break;

                case 2:
                    myNumberMax = 100;
                    break;

                case 3:
                    myNumberMax = 1000;
                    break;

                default:
                    myNumberMax = 0;
                    // error = very yes
                    break;
            }

            myNumber = random.Next(myNumberMin, myNumberMax) + myNumberOffset;

            return myNumber;
        }
    }
}
