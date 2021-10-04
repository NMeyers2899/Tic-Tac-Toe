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

        /// <summary>
        /// Initializes what needs to be set before the game begins.
        /// </summary>
        public void Start()
        {
            _player1Token = 'x';
            _player2Token = 'o';
            _currentToken = _player1Token;
            _board = new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        }

        /// <summary>
        /// Changes the information through multiple loops of the main game.
        /// </summary>
        public void Update()
        {
            if(Game.GetInput() == 1)
            {
                _board[0, 0] = _currentToken;
            }

            if(_currentToken == _player1Token)
            {
                _currentToken = _player2Token;
            }
            else
            {
                _currentToken = _player1Token;
            }
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

        }

        /// <summary>
        /// Resets the board to its default state.
        /// </summary>
        private void ClearBoard()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for(int j = 0; j < _board.GetLength(1); j++)
                {
                    _board[i, j] = '-';
                }
            }
        }
    }
}