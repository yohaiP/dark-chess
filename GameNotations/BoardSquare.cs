using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public class BoardSquare
    {
        readonly public Tuple<int, int> LocationOnBoard;
        public GameBoard OnBoard;
        public GamePiece ContainedPiece;
        //[NonSerialized]
        public bool IsVisible;
        //[NonSerialized]
        public bool IsBlocked;

        public BoardSquare(int i, int j, GameBoard board)
        {
            LocationOnBoard = Tuple.Create(i, j);
            OnBoard = board;
            IsVisible = false;
            IsBlocked = false;
        }

        public static BoardSquare operator+(BoardSquare square, Tuple<int, int> offset)
        {
            return square.OnBoard.Board[square.LocationOnBoard.Item1 + offset.Item1, square.LocationOnBoard.Item2 + offset.Item2];
        }

        public static Tuple<int, int> operator-(BoardSquare square, BoardSquare subtractor)
        {
            return Tuple.Create(square.LocationOnBoard.Item1 - subtractor.LocationOnBoard.Item1, square.LocationOnBoard.Item2 - subtractor.LocationOnBoard.Item2);
        }
    }
}
