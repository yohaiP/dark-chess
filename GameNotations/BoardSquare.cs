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
        public GamePiece ContainedPiece;
        public bool IsVisible;
        public bool IsBlocked;

        public BoardSquare(int i, int j)
        {
            LocationOnBoard = Tuple.Create<int, int>(i, j);
        }
    }
}
