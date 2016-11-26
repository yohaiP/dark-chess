using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GameNotations;
using System.Threading;

namespace DarkChessClient
{
    static class BoardGraphicsManager
    {
        static System.Windows.Forms.PictureBox board;

        static Graphics graphics;
        static Bitmap graphicsBmp;
        static Bitmap pieces;
        static Bitmap unseen;
        static Bitmap blocked;
        static Size boardSquareSize;
        static Size boardSquareCenter;

        // Class initialization method
        public static void CreateGraphics(object sender)
        {
            DarkChessClient client = (DarkChessClient)sender;

            //Defining the size of a single square from the board
            board = client.board;
            Size size = board.Size;
            boardSquareSize = new Size(size.Width / 8, size.Height / 8);
            boardSquareCenter = new Size(boardSquareSize.Width / 2, boardSquareSize.Height / 2);

            graphicsBmp = new Bitmap(size.Width, size.Height);
            graphics = Graphics.FromImage(graphicsBmp);

            pieces = (Bitmap)Image.FromFile(@"chess graphics/pieces.png");
            unseen = (Bitmap)Image.FromFile(@"chess graphics/unseen.png");
            blocked = (Bitmap)Image.FromFile(@"chess graphics/blocked.png");
            pieces.MakeTransparent(Color.Green);
            unseen.MakeTransparent(Color.Green);
            blocked.MakeTransparent(Color.Green);
        }

        public static Tuple<int, int> SquareOfClick(Point click)
        {
            int temp;
            int minDist = int.MaxValue;
            Point[,] boardG = new Point[8, 8];
            int[,] boardIndex = new int[8, 8];
            #region defining centers
            for (int i = 0; i < boardG.GetLength(0); i++)
            {
                for (int j = 0; j < boardG.GetLength(1); j++)
                {
                    boardG[i, j] = new Point(i * boardSquareSize.Width + boardSquareCenter.Width, j * boardSquareSize.Height + boardSquareCenter.Height);
                }
            }
            #endregion

            #region finding the nearest square center
            for (int i = 0; i < boardG.GetLength(0); i++)
            {
                for (int j = 0; j < boardG.GetLength(1); j++)
                {
                    boardG[i, j] = new Point(boardG[i, j].X - click.X, boardG[i, j].Y - click.Y);
                    temp = boardG[i, j].X * boardG[i, j].X + boardG[i, j].Y * boardG[i, j].Y;

                    // temp is containing the result for the calculation of the distance of centers to the click.
                    // since theres no way to store the distance with the respective square position i putted it in
                    // the point's X because i dont need the point for calculations anymore.
                    boardG[i, j].X = temp;

                    minDist = Math.Min(minDist, temp);
                }
            }
            #endregion

            #region finding the index of the nearest center
            for (int i = 0; i < boardG.GetLength(0); i++)
            {
                for (int j = 0; j < boardG.GetLength(0); j++)
                {
                    if (boardG[i, j].X == minDist)
                        return Tuple.Create(i, j);
                }
            }
            return Tuple.Create(-1, -1);
            #endregion

        }

        // piece image for drawing pieces on the board
        static Tuple<int, int> pieceImagePosition(GamePiece piece)
        {
            #region White pieces
            if (piece.PlayerRelevance.PlayersColor == Player.color.White)
            {
                if (piece is King)
                {
                    return Tuple.Create<int, int>(0, 0);
                }
                if (piece is Queen)
                {
                    return Tuple.Create<int, int>(1, 0);
                }
                if (piece is Bishop)
                {
                    return Tuple.Create<int, int>(2, 0);
                }
                if (piece is Knight)
                {
                    return Tuple.Create<int, int>(3, 0);
                }
                if (piece is Rook)
                {
                    return Tuple.Create<int, int>(4, 0);
                }
                if (piece is Pawn)
                {
                    return Tuple.Create<int, int>(5, 0);
                }
            }
            #endregion
            #region Black pieces
            else
            {
                if (piece is King)
                {
                    return Tuple.Create<int, int>(0, 1);
                }
                if (piece is Queen)
                {
                    return Tuple.Create<int, int>(1, 1);
                }
                if (piece is Bishop)
                {
                    return Tuple.Create<int, int>(2, 1);
                }
                if (piece is Knight)
                {
                    return Tuple.Create<int, int>(3, 1);
                }
                if (piece is Rook)
                {
                    return Tuple.Create<int, int>(4, 1);
                }
                if (piece is Pawn)
                {
                    return Tuple.Create<int, int>(5, 1);
                }
            }
            #endregion
            return Tuple.Create<int, int>(-1, -1);
        }

        // piece image for pawn promoting dialog
        static Tuple<int, int> pieceImagePosition(Type pieceType, Player.color color)
        {
            #region White pieces
            if (color == Player.color.White)
            {
                if (pieceType.Name.Equals("Queen"))
                {
                    return Tuple.Create<int, int>(1, 0);
                }
                if (pieceType.Name.Equals("Rook"))
                {
                    return Tuple.Create<int, int>(2, 0);
                }
                if (pieceType.Name.Equals("Bishop"))
                {
                    return Tuple.Create<int, int>(3, 0);
                }
                if (pieceType.Name.Equals("Knight"))
                {
                    return Tuple.Create<int, int>(4, 0);
                }
            }
            #endregion
            #region Black pieces
            else
            {
                if (pieceType.Name.Equals("Queen"))
                {
                    return Tuple.Create<int, int>(1, 1);
                }
                if (pieceType.Name.Equals("Rook"))
                {
                    return Tuple.Create<int, int>(2, 1);
                }
                if (pieceType.Name.Equals("Bishop"))
                {
                    return Tuple.Create<int, int>(3, 1);
                }
                if (pieceType.Name.Equals("Knight"))
                {
                    return Tuple.Create<int, int>(4, 1);
                }
            }
            #endregion
            return Tuple.Create<int, int>(-1, -1);
        }

        static void drawPieceOnBoard(GamePiece piece)
        {
            Tuple<int, int> square = piece.ContainingSquare.LocationOnBoard;
            Tuple<int, int> t = pieceImagePosition(piece);
            Size size = pieces.Size;
            graphics.DrawImage(pieces, square.Item1 * boardSquareSize.Width, square.Item2 * boardSquareSize.Height, new Rectangle(t.Item1 * (size.Width / 6), t.Item2 * (size.Height / 2), size.Width / 6, size.Height / 2), GraphicsUnit.Pixel);
        }

        static void drawUnseenOnBoard(Tuple<int, int> square)
        {
            graphics.DrawImage(unseen, square.Item1 * boardSquareSize.Width, square.Item2 * boardSquareSize.Height);
        }

        static void drawBlockedOnBoard(Tuple<int, int> square)
        {
            graphics.DrawImage(blocked, square.Item1 * boardSquareSize.Width, square.Item2 * boardSquareSize.Height);
        }

        static void DrawCurrentStateOnBmp(GameBoard gameBoard)
        {
            foreach (BoardSquare square in gameBoard.Board)
            {
                if (!square.IsVisible)
                {
                    drawUnseenOnBoard(square.LocationOnBoard);
                    continue;
                }
                if (square.IsBlocked)
                {
                    drawBlockedOnBoard(square.LocationOnBoard);
                    continue;
                }
                if (square.ContainedPiece != null)
                {
                    drawPieceOnBoard(square.ContainedPiece);
                }
            }
        }

        public static void DrawBmpOnGameBoard()
        {
            board.Invalidate();
            board.Image = graphicsBmp;
        }

        public static void test(Point click)
        {
            Tuple<int, int> t = SquareOfClick(click);
            GameBoard board = new GameBoard();
            BoardSquare square = board.Board[t.Item1, t.Item2];
            square.ContainedPiece = new Pawn(new Player(Player.color.Black), square);
            List<BoardSquare> l = square.ContainedPiece.strategy.LegalMoves;
            DrawCurrentStateOnBmp(board);
            DrawBmpOnGameBoard();
        }
    }
}
