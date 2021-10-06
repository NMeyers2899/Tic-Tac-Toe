using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Game
    {
        public static bool GameOver = false;
        private Board _gameBoard;

        public void Run()
        {
            Start();

            while (!GameOver)
            {
                Draw();
                Update();
            }

            End();
        }

        /// <summary>
        /// Initializes what needs to be set before the game begins.
        /// </summary>
        public void Start()
        {
            _gameBoard = new Board();
            _gameBoard.Start();
        }

        /// <summary>
        /// Changes the information through multiple loops of the main game.
        /// </summary>
        public void Update()
        {
            _gameBoard.Update();
        }

        /// <summary>
        /// Prints out necessary information to the screen.
        /// </summary>
        private void Draw()
        {
            Console.Clear();
            _gameBoard.Draw();
        }

        /// <summary>
        /// Is called when the game ends.
        /// </summary>
        public void End()
        {
            _gameBoard.End();
        }

        public static int GetInput()
        {
            int choice = -1;

            if(!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

            return choice;
        }

        /// <summary>
        /// Gets an input from the player based on some given decision.
        /// </summary>
        /// <param name="description"> The context for the input </param>
        /// <param name="options"> The options given to the player. </param>
        /// <returns> The users input of a given choice. </returns>
        public static int GetInput(string description, params string[] options)
        {
            string input = "";
            int inputRecieved = -1;

            while (inputRecieved == -1)
            {
                // Print out all options.
                Console.WriteLine(description);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + options[i]);
                }
                Console.Write("> ");

                input = Console.ReadLine();

                // If a player typed an int...
                if (int.TryParse(input, out inputRecieved))
                {
                    // ...decrement the input and check if it's within bounds of the array.
                    inputRecieved--;
                    if (inputRecieved < 0 || inputRecieved >= options.Length)
                    {
                        // Sets inputRecieved to the default value.
                        inputRecieved = -1;
                        //Display error message.
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey(true);
                    }
                }
                // If the user didn't type an int.
                else
                {
                    // Sets inputRecieved to the default value.
                    inputRecieved = -1;
                    //Display error message.
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey(true);
                }

                Console.Clear();
            }

            return inputRecieved;
        }
    }
}
