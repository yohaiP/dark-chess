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
            Ranged = false;

            MovementDirections = new List<Tuple<int, int>>();
            MovementDirections.Add(new Tuple<int, int>(1, 0));
            MovementDirections.Add(new Tuple<int, int>(2, 0));
            MovementDirections.Add(new Tuple<int, int>(1, 1));
            MovementDirections.Add(new Tuple<int, int>(1, -1));
        }
    }
}
