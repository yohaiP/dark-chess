using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public abstract class GamePiece
    {
        MoveStrategy Strategy;
        readonly public Player PlayerRelevance;
        public List<Tuple<int, int>> MovementDirections { get; protected set; }
        public BoardSquare ContainingSquare;

        public GamePiece(Player player, BoardSquare boardSquare)
        {
            this.PlayerRelevance = player;
            this.ContainingSquare = boardSquare;
        }

        public virtual List<BoardSquare> CalculateMoves()
        {
            return new List<BoardSquare>();
        }
    }
}
