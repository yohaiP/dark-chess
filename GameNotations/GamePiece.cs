using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    public abstract class GamePiece
    {
        public MoveStrategy strategy;
        readonly public Player PlayerRelevance;
        public BoardSquare ContainingSquare;

        public GamePiece(Player player, BoardSquare boardSquare)
        {
            PlayerRelevance = player;
            PlayerRelevance.PiecesBelongsToPlayer.Add(this);
            ContainingSquare = boardSquare;
            ContainingSquare.ContainedPiece = this;
        }
    }
}
