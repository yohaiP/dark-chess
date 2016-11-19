using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public class Rook : GamePiece
    {
        //[NonSerialized]
        public bool Moved = false;

        public Rook(Player player, BoardSquare square) : base(player, square)
        {
            strategy = new MoveStrategy(this, true,
                Tuple.Create(1, 0),
                Tuple.Create(0, -1),
                Tuple.Create(-1, 0),
                Tuple.Create(0, 1)
                );
        }
    }
}
