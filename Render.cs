using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessing
{
    partial class Program
    {
        static void Render()
        {
            // blank slate
            Console.Clear();

            switch (gameState)
            { 
                case GameState.Initialize:
                    // debug
                    //Console.WriteLine(gameState.ToString());
                    // debugging only
                    MyDebug();
                    break;
                
                case GameState.Guess:
                    Console.WriteLine("Guess a number from {0} to {1}, Q to quit", myNumberMin, myNumberMax);
                    Console.WriteLine(myResult.rankMessage);
                    MyDebug();
                    break;

                case GameState.Win:
                    Console.WriteLine("You win!");
                    break;

                case GameState.Exit:
                    // debug
                    MyDebug();
                    break;

                default:
                    errorMessage = "Invalid game state during render.";
                    break;
            }
        }
    }
}
