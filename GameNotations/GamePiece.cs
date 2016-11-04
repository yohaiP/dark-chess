using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    class GamePiece
    {
        readonly public Player PlayerRelevance;
        public List<Tuple<int, int>> MovementDirections { get; private set; }
        readonly public bool Ranged;
    }
}
