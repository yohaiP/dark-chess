using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public class Bishop : GamePiece
    {
        public Bishop(Player player, BoardSquare square):base(player, square)
        {
            strategy = new MoveStrategy(this, true,
                Tuple.Create(1, 1),
                Tuple.Create(1, -1),
                Tuple.Create(-1, -1),
                Tuple.Create(-1, 1)
    );
        }
    }
}
