using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public class King : GamePiece
    {
        //[NonSerialized]
        public bool Moved = false;

        public King(Player player, BoardSquare square) : base(player, square)
        {
            strategy = new MoveStrategy(this, false,
                Tuple.Create(1, 1),
                Tuple.Create(1, 0),
                Tuple.Create(1, -1),
                Tuple.Create(0, -1),
                Tuple.Create(-1, -1),
                Tuple.Create(-1, 0),
                Tuple.Create(-1, 1),
                Tuple.Create(0, 1)
                );
        }
    }
}
