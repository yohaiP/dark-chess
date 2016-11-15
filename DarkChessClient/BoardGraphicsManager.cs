using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GameNotations;

namespace DarkChessClient
{
    class BoardGraphicsManager
    {
        static Graphics graphics;
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
            Size size = client.board.Size;
            boardSquareSize = new Size(size.Width / 8, size.Height / 8);
            boardSquareCenter = new Size(boardSquareSize.Width / 2, boardSquareSize.Height / 2);

            graphics = client.board.CreateGraphics();

            pieces = (Bitmap)Image.FromFile(@"chess graphics/pieces.png");
            unseen = (Bitmap)Image.FromFile(@"chess graphics/unseen.png");
            blocked = (Bitmap)Image.FromFile(@"chess graphics/unseen.png")
            pieces.MakeTransparent(Color.Green);
            unseen.MakeTransparent(Color.Green);
            blocked.MakeTransparent(Color.Green);
        }

        static Tuple<int, int> squareOfClick(Point click)
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

        static Tuple<int, int> pieceImagePosition(Type pieceType, Player.color color)
        {
            #region White pieces
            if (color == Player.color.White)
            {
                if (pieceType.Name.Equals("King"))
                {
                    return Tuple.Create<int, int>(0, 0);
                }
                if (pieceType.Name.Equals("Queen"))
                {
                    return Tuple.Create<int, int>(0, 1);
                }
                if (pieceType.Name.Equals("Bishop"))
                {
                    return Tuple.Create<int, int>(0, 2);
                }
                if (pieceType.Name.Equals("Knight"))
                {
                    return Tuple.Create<int, int>(0, 3);
                }
                if (pieceType.Name.Equals("Rook"))
                {
                    return Tuple.Create<int, int>(0, 4);
                }
                if (pieceType.Name.Equals("Pawn"))
                {
                    return Tuple.Create<int, int>(0, 7);
                }
            }
            #endregion
            #region Black pieces
            else
            {
                if (pieceType.Name.Equals("King"))
                {
                    return Tuple.Create<int, int>(1, 0);
                }
                if (pieceType.Name.Equals("Queen"))
                {
                    return Tuple.Create<int, int>(1, 1);
                }
                if (pieceType.Name.Equals("Bishop"))
                {
                    return Tuple.Create<int, int>(1, 2);
                }
                if (pieceType.Name.Equals("Knight"))
                {
                    return Tuple.Create<int, int>(1, 3);
                }
                if (pieceType.Name.Equals("Rook"))
                {
                    return Tuple.Create<int, int>(1, 4);
                }
                if (pieceType.Name.Equals("Pawn"))
                {
                    return Tuple.Create<int, int>(1, 7);
                }
            }
            #endregion
            return Tuple.Create<int, int>(-1, -1);
        }

        static void drawPieceOnBoard(GamePiece piece, Tuple<int, int> square)
        {
            Tuple<int, int> t = pieceImagePosition(piece.GetType(), piece.PlayerRelevance.PlayersColor);
            Size size = pieces.Size;
            graphics.DrawImage(pieces, square.Item1*boardSquareSize.Width, square.Item2*boardSquareSize.Height, new Rectangle(t.Item1* (size.Width / 6), t.Item2*( size.Height / 2), size.Width / 6, size.Height / 2), GraphicsUnit.Pixel);
        }

        static void drawUnseenOnBoard(Tuple<int, int> square)
        {
            graphics.DrawImage(unseen, square.Item1 * boardSquareSize.Width, square.Item2 * boardSquareSize.Height);
        }

        static void drawBlockedOnBoard(Tuple<int, int> square)
        {
            graphics.DrawImage(blocked, square.Item1 * boardSquareSize.Width, square.Item2 * boardSquareSize.Height);
        }

        static void drawCurrentBoard() { }

        public static void test(Point click)
        {
            Tuple<int, int> t = squareOfClick(click);
            Size size = pieces.Size;
            graphics.DrawImage(pieces, t.Item1 * boardSquareSize.Width, t.Item2 * boardSquareSize.Height, new Rectangle(0, 0, size.Width / 6, size.Height / 2), GraphicsUnit.Pixel);
        }
    }
}
