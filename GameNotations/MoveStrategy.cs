using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    abstract class MoveStrategy
    {
        public bool Ranged { get; protected set; }
        public List<Tuple<int, int>> MovementDirections { get; protected set; }
    }
}
