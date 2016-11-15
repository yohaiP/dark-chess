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
        GamePiece ContainedPiece;
        bool IsVisible;
        bool IsBlocked;
    }
}
