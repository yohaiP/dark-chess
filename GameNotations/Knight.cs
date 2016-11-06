using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    public class Knight : GamePiece
    {
        public Knight(Player player, BoardSquare square) : base(player, square)
        {
            Ranged = false;

            MovementDirections = new List<Tuple<int, int>>(8);
            MovementDirections.Add(new Tuple<int, int>(1, 2));
            MovementDirections.Add(new Tuple<int, int>(1, -2));
            MovementDirections.Add(new Tuple<int, int>(-1, 2));
            MovementDirections.Add(new Tuple<int, int>(-1, -2));
            MovementDirections.Add(new Tuple<int, int>(2, 1));
            MovementDirections.Add(new Tuple<int, int>(2, -1));
            MovementDirections.Add(new Tuple<int, int>(-2, 1));
            MovementDirections.Add(new Tuple<int, int>(-2, -1));
        }
    }
}
