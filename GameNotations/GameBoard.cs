using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public sealed class GameBoard
    {
        public BoardSquare[,] Board;
        private static readonly GameBoard instance = new GameBoard();
        public static GameBoard Instance
        {
            get
            {
                return instance;
            }
        }
        private GameBoard()
        {
            Board = new BoardSquare[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Board[i, j] = new BoardSquare(i, j, this);
                }
            }
        }

        public static BoardSquare[,] Flip(BoardSquare[,] board)
        {
            if(board.GetLength(0) != 8 || board.GetLength(1) != 8)
            {
                throw new Exception("board is not in the right size");
            }

            BoardSquare[,] outBoard = new BoardSquare[8, 8];
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    outBoard[i, j] = board[i, 7 - j];
                    outBoard[i, j].LocationOnBoard = board[i, 7 - j].LocationOnBoard;
                }
            }
            return outBoard;
        }
    }
}
