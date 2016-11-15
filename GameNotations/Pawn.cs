using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    public class Pawn : GamePiece
    {
        public Pawn(Player player, BoardSquare square) : base(player, square)
        {
        }
    }
}
