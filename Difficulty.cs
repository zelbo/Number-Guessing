// difficutly setting should probably be done during the INITIALIZE game state.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessing
{
    partial class Program
    {
        public static int difficultySetting;

        static int GetDifficulty()
        {
            int difficultyChoice = 0;
            while (difficultyChoice == 0)
            {
                //Render();
                Console.WriteLine("Number Guessing version 0.01 alpha");
                Console.WriteLine();
                Console.WriteLine("Please Select Difficulty Setting:");
                Console.WriteLine("1) Easy");
                Console.WriteLine("2) Normal");
                Console.WriteLine("3) Hard");
                Console.WriteLine();
                Console.WriteLine("Your Selection (1-3):");
                ConsoleKeyInfo keyPress = Console.ReadKey();

                if (keyPress.Key == ConsoleKey.D1) difficultyChoice = 1;
                else if (keyPress.Key == ConsoleKey.NumPad1) difficultyChoice = 1;
                else if (keyPress.Key == ConsoleKey.D2) difficultyChoice = 2;
                else if (keyPress.Key == ConsoleKey.NumPad2) difficultyChoice = 2;
                else if (keyPress.Key == ConsoleKey.D3) difficultyChoice = 3;
                else if (keyPress.Key == ConsoleKey.NumPad3) difficultyChoice = 3;
                else difficultyChoice = 0;
            }
            return difficultyChoice;
        }
    }
}
