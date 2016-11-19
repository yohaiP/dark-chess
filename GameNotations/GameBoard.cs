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
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Board[i, j] = new BoardSquare(i, j, this);
                }
            }
        }

        public void Flip()
        {
            BoardSquare temp;
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    temp = Board[i, j];
                    Board[i, j] = Board[7 - i, j];
                    Board[7 - i, j] = temp;
                }
            }
        }
    }
}
