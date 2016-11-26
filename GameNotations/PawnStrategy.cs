using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    class PawnStrategy : MoveStrategy
    {
        bool initialMove = true;

        public PawnStrategy(Pawn pawn):base(pawn, false, Tuple.Create(1, -1), Tuple.Create(-1, -1)) { }

        public override List<BoardSquare> LegalMoves
        {
            get
            {
                List<BoardSquare> legalmoves = base.LegalMoves;
                BoardSquare square = base.belongsToPiece.ContainingSquare;
                square += Tuple.Create(0, -1);
                if (square.ContainedPiece != null && square.ContainedPiece.PlayerRelevance.PlayersColor != this.belongsToPiece.PlayerRelevance.PlayersColor)
                {
                    square.IsBlocked = true;
                }
                else
                {
                    legalmoves.Add(square);
                    square += Tuple.Create(0, -1);
                    if(initialMove && square.ContainedPiece == null)
                    {
                        legalmoves.Add(square);
                    }
                    else
                    {
                        square.IsBlocked = true;
                    }
                }
                foreach (BoardSquare boardSquare in legalmoves)
                {
                    boardSquare.IsVisible = true;
                }
                return legalmoves;
            }
        }
    }
}
