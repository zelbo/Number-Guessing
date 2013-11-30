using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessing
{
    partial class Program
    {
        static void Update()
        {
            // --------------------
            // Non-State-Specific Processes (quit, help)
            //if(KeyState[(int)MyKeys.Escape]) Environment.Exit(0);
            if (KeyState[(int)MyKeys.Escape]) exitProgram = true;

            // --------------------
            // State Specific Processes
            switch (gameState)
            {
                case GameState.Initialize:
                    Initialize();
                    gameState = GameState.Guess;
                    break;

                // breaking the input/update/render theme here
                // need to implement a custom readline method?
                // maybe input/update/render is a little much for a console app.
                case GameState.Guess:

                    string inputString = Console.ReadLine();
                    int inputNumber;
                    if (int.TryParse(inputString, out inputNumber))
                    {
                        myResult = Guess(inputNumber);
                        if (myResult.isCorrect) gameState = GameState.Win;
                        else
                        { 
                            // three chances
                            guessesRemaining--;
                            if (guessesRemaining <= 0) gameState = GameState.Lose;
                        }

                    }
                    else { if (inputString.ToLower() == "q") exitProgram = true; }
                    break;

                case GameState.Win:
                    // player score++
                    // play again?
                    if (GameOver(true)) gameState = GameState.Initialize;
                    else gameState = GameState.Exit;
                    break;

                case GameState.Lose:
                    // play again?
                    if (GameOver(false)) gameState = GameState.Initialize;
                    else gameState = GameState.Exit;
                    break;

                case GameState.Exit:
                    // do cleanup stuff here?
                    // save high score...
                    // display thank you screen
                    Console.WriteLine(errorMessage);
                    Console.WriteLine("");
                    Console.WriteLine("brought to you by:");
                    Console.WriteLine("sleep deprived games");
                    Console.WriteLine("and");
                    Console.WriteLine("egalitarian but gansta productions");
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine("Press the any key to continue...");
                    Console.ReadKey();
                    exitProgram = true;
                    break;

                default:
                    errorMessage = "Invalid game state during update.";
                    break;
            }
        }
    }
}
