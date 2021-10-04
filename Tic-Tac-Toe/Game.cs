using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Game
    {
        private bool _gameOver = false;
        private Board _gameBoard;

        public void Run()
        {
            Start();

            while (!_gameOver)
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

        /// <summary>
        /// Assigns the spot at the given indices in the board array to the given token.
        /// </summary>
        /// <param name="token"> The token being placed at the indices. </param>
        /// <param name="posX"> The x position of the token's placement. </param>
        /// <param name="posY"> The y position of the token's placement. </param>
        /// <returns> Return false if the indices is out of range. </returns>
        public bool SetToken(char token, int posX, int posY)
        {
            

            return false;
        }

        /// <summary>
        /// Checks to see if there are three tokens of the same type in a line. Assigns the winner based on which 
        /// token won.
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool CheckWinner(char token)
        {
            return false;
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
    }
}
