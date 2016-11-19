using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public class Knight : GamePiece
    {
        public Knight(Player player, BoardSquare square) : base(player, square)
        {
            strategy = new MoveStrategy(this, false,
                Tuple.Create(2, 1),
                Tuple.Create(2, -1),
                Tuple.Create(-2, 1),
                Tuple.Create(-2, -1),
                Tuple.Create(1, 2),
                Tuple.Create(-1, 2),
                Tuple.Create(1, -2),
                Tuple.Create(-1, -2)
                );
        }
    }
}
