using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    public class MoveStrategy
    {
        public GamePiece belongsToPiece;
        protected bool Ranged { get; set; }
        protected List<Tuple<int, int>> MovementDirections { get; set; }

        public MoveStrategy(GamePiece piece, bool ranged, params Tuple<int, int>[] directions)
        {
            belongsToPiece = piece;
            Ranged = ranged;
            MovementDirections = new List<Tuple<int, int>>(directions);
        }

        public virtual List<BoardSquare> LegalMoves
        {
            get
            {
                this.belongsToPiece.ContainingSquare.IsVisible = true;
                List<BoardSquare> legalMoves = new List<BoardSquare>();
                BoardSquare square = belongsToPiece.ContainingSquare;
                BoardSquare nextSquare;
                foreach (Tuple<int, int> direction in MovementDirections)
                {
                    try
                    {
                        nextSquare = square + direction;
                        while (true)
                        {
                            legalMoves.Add(nextSquare);
                            if (!Ranged)
                            {
                                break;
                            }
                            nextSquare += direction;
                            if (nextSquare.ContainedPiece != null)
                            {
                                if (nextSquare.ContainedPiece.PlayerRelevance.PlayersColor == this.belongsToPiece.PlayerRelevance.PlayersColor)
                                {
                                    throw new IndexOutOfRangeException();
                                }
                                if (nextSquare.ContainedPiece.PlayerRelevance.PlayersColor != this.belongsToPiece.PlayerRelevance.PlayersColor)
                                {
                                    legalMoves.Add(nextSquare);
                                    throw new IndexOutOfRangeException();
                                }
                            }
                        }

                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }
                }
                foreach (BoardSquare boardSquare in legalMoves)
                {
                    boardSquare.IsVisible = true;
                }
                return legalMoves;
            }
        }
    }
}
