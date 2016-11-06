using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    public class Bishop : GamePiece
    {
        public Bishop(Player player, BoardSquare square):base(player, square)
        {
            Ranged = true;

            MovementDirections = new List<Tuple<int, int>>();
            MovementDirections.Add(new Tuple<int, int>(1, 1));
            MovementDirections.Add(new Tuple<int, int>(-1, 1));
            MovementDirections.Add(new Tuple<int, int>(1, -1));
            MovementDirections.Add(new Tuple<int, int>(-1, -1));
        }
    }
}
