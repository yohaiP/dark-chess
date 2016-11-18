using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public class GameBoard
    {
        public BoardSquare[,] Board;
        public GameBoard()
        {
            Board = new BoardSquare[8, 8];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Board[i, j] = new BoardSquare(i, j);
                }
            }
        }
    }
}
