using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Board
    {
        private char _player1Token;
        private char _player2Token;
        private char _currentToken;
        private char[,] _board;
        private int _currentTurn;

        /// <summary>
        /// Initializes what needs to be set before the game begins.
        /// </summary>
        public void Start()
        {
            _player1Token = 'x';
            _player2Token = 'o';
            _currentToken = _player1Token;
            _board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            _currentTurn = 0;
        }

        /// <summary>
        /// Changes the information through multiple loops of the main game.
        /// </summary>
        public void Update()
        {
            if (_currentTurn == 9)
            {
                Console.WriteLine("It's a tie!");

                int tieChoice = Game.GetInput("Would you like to play again?", "Yes", "No");
                switch (tieChoice)
                {
                    case 0:
                        ClearBoard();
                        _currentTurn = 0;
                        return;
                    case 1:
                        Game.GameOver = true;
                        return;
                }
            }

            int choice = Game.GetInput() - 1;

            if(choice <= -1 || choice >= 9 || !SetToken(_currentToken, choice / 3, choice % 3))
            {
                Console.WriteLine("You cannot place your token there.");
                Console.ReadKey(true);
                return;    
            }

            if (CheckWinner(_currentToken))
            {
                choice = Game.GetInput("Would you like to play again?", "Yes", "No");
                switch (choice)
                {
                    case 0:
                        ClearBoard();
                        _currentTurn = 0;
                        return;
                    case 1:
                        Game.GameOver = true;
                        return;
                }
            }

            if (_currentToken == _player1Token)
            {
                _currentToken = _player2Token;
            }
            else
            {
                _currentToken = _player1Token;
            }

            _currentTurn++;
        }

        /// <summary>
        /// Prints out necessary information to the screen.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine(_board[0, 0] + " | " + _board[0, 1] + " | " + _board[0, 2] + "\n" +
                                 "_________ \n" +
                              _board[1, 0] + " | " + _board[1, 1] + " | " + _board[1, 2] + "\n" +
                                "_________ \n" +
                              _board[2, 0] + " | " + _board[2, 1] + " | " + _board[2, 2]);
        }

        /// <summary>
        /// Is called when the game ends.
        /// </summary>
        public void End()
        {
            Console.WriteLine("Goodbye!");
        }

        /// <summary>
        /// Assigns the spot at the given indices in the board array to the given token.
        /// </summary>
        /// <param name="token"> The token being placed at the indices. </param>
        /// <param name="posX"> The x position of the token's placement. </param>
        /// <param name="posY"> The y position of the token's placement. </param>
        /// <returns> Return false if the indices is out of range. </returns>
        private bool SetToken(char token, int posX, int posY)
        {
            
            if(_board[posX, posY] == 'x' || _board[posX, posY] == 'o')
            {
                return false;
            }

            _board[posX, posY] = token;

            return true;
        }

        /// <summary>
        /// Checks to see if there are three tokens of the same type in a line. Assigns the winner based on which 
        /// token won.
        /// </summary>
        /// <param name="token"> The current token being used by a player. </param>
        /// <returns> Returns if there is a winner or not. </returns>
        private bool CheckWinner(char token)
        {
            Console.Clear();
            Draw();
            if (_board[0, 0] == token && _board[1, 0] == token && _board[2, 0] == token)
            {
                Console.WriteLine("Winner is " + token + " player!");
                Console.ReadKey(true);
                return true;
            }
            else if(_board[0, 1] == token && _board[1, 1] == token && _board[2, 1] == token)
            {
                Console.WriteLine("Winner is " + token + " player!");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[0, 2] == token && _board[1, 2] == token && _board[2, 2] == token)
            {
                Console.WriteLine("Winner is " + token + " player!");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[0, 0] == token && _board[0, 1] == token && _board[0, 2] == token)
            {
                Console.WriteLine("Winner is " + token + " player!");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[1, 0] == token && _board[1, 1] == token && _board[1, 2] == token)
            {
                Console.WriteLine("Winner is " + token + " player!");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 0] == token && _board[2, 1] == token && _board[2, 2] == token)
            {
                Console.WriteLine("Winner is " + token + " player!");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[0, 0] == token && _board[1, 1] == token && _board[2, 2] == token)
            {
                Console.WriteLine("Winner is " + token + " player!");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 0] == token && _board[1, 1] == token && _board[0, 2] == token)
            {
                Console.WriteLine("Winner is " + token + " player!");
                Console.ReadKey(true);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Resets the board to its default state.
        /// </summary>
        private void ClearBoard()
        {
            int positionNumber = 49;

            for(int i = 0; i < _board.GetLength(0); i++)
            {
                for(int j = 0; j < _board.GetLength(1); j++)
                {
                    _board[i, j] = Convert.ToChar(positionNumber);
                    positionNumber++;
                }
            }
        }
    }
}