using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    public abstract class GamePiece
    {
        readonly public Player PlayerRelevance;
        public List<Tuple<int, int>> MovementDirections { get; protected set; }
        public BoardSquare ContainingSquare;
        public bool Ranged { get; protected set; }

        public GamePiece(Player player, BoardSquare boardSquare)
        {
            this.PlayerRelevance = player;
            this.ContainingSquare = boardSquare;
        }
    }
}
