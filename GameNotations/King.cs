using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    public class King : GamePiece
    {
        King(Player player, BoardSquare square) : base(player, square)
        {
            Ranged = false;

            this.MovementDirections = new List<Tuple<int, int>>(8);
            MovementDirections.Add(new Tuple<int, int>(0, 1));
            MovementDirections.Add(new Tuple<int, int>(1, 1));
            MovementDirections.Add(new Tuple<int, int>(1, 0));
            MovementDirections.Add(new Tuple<int, int>(1, -1));
            MovementDirections.Add(new Tuple<int, int>(0, -1));
            MovementDirections.Add(new Tuple<int, int>(-1, -1));
            MovementDirections.Add(new Tuple<int, int>(-1, 0));
            MovementDirections.Add(new Tuple<int, int>(-1, 1));
        }
    }
}
