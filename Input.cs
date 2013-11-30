using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessing
{
    // while the ConsoleKey enum is great,
    // i'm doing this here to avoid having to check both regular numbers and keypad all the time.
    // and then of course i still check both. i'm such a spaghetti programmer.

    partial class Program
    {
        static int numberOfKeys = Enum.GetNames(typeof(MyKeys)).Length;
        public static bool[] KeyState = new bool[numberOfKeys];
                
        static void Input()
        {
            // --------------------
            // clear the input buffer
            for (int i = 0; i < KeyState.Length - 1; i++) // magic numbers
            {
                KeyState[i] = false;
            }

            // need to redo everything if we use this...
            //while (!Console.KeyAvailable)
            //{
                // screen bugs out when i keep drawing it
                // but i want to stick with the input/update/render set-up
                // so we idle here for a bit.
            //}

            // --------------------
            // Read Input
            // f1 or ? for help page
            // esc to quit
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed;
                keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.Escape) KeyState[(int)MyKeys.Escape] = true;
                else if (keyPressed.Key == ConsoleKey.D1) KeyState[(int)MyKeys.NumberKey_1] = true;
                else if (keyPressed.Key == ConsoleKey.D2) KeyState[(int)MyKeys.NumberKey_2] = true;
                else if (keyPressed.Key == ConsoleKey.D3) KeyState[(int)MyKeys.NumberKey_3] = true;
                else if (keyPressed.Key == ConsoleKey.NumPad1) KeyState[(int)MyKeys.NumberKey_1] = true;
                else if (keyPressed.Key == ConsoleKey.NumPad2) KeyState[(int)MyKeys.NumberKey_2] = true;
                else if (keyPressed.Key == ConsoleKey.NumPad3) KeyState[(int)MyKeys.NumberKey_3] = true;
            }
        }
    }
}
