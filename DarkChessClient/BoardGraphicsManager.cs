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
        static Size boardSquareSize;

        // Class initialization method
        public static void CreateGraphics(object sender)
        {
            DarkChessClient client = (DarkChessClient)sender;

            //Defining the size of a single square from the board
            Size size = client.board.BackgroundImage.Size;
            boardSquareSize = new Size(size.Width / 8, size.Height / 8);

            graphics = client.board.CreateGraphics();

            pieces = (Bitmap)Image.FromFile(@"pieces.png", true);
            pieces.MakeTransparent();
        }

        static Rectangle ImagePartOfPiece(GamePiece piece)
        {
            #region White pieces
            if (piece.PlayerRelevance.PlayersColor == Player.color.White)
            {
                if (piece is King)
                {
                    return new Rectangle();
                }
                if (piece is Queen)
                {
                    return new Rectangle();
                }
                if (piece is Bishop)
                {
                    return new Rectangle();
                }
                if (piece is Knight)
                {
                    return new Rectangle();
                }
                if (piece is Rook)
                {
                    return new Rectangle();
                }
                if (piece is Pawn)
                {
                    return new Rectangle();
                }
            }
            #endregion
            #region Black pieces
            if (piece.PlayerRelevance.PlayersColor == Player.color.Black)
            {
                if (piece is King)
                {
                    return new Rectangle();
                }
                if (piece is Queen)
                {
                    return new Rectangle();
                }
                if (piece is Bishop)
                {
                    return new Rectangle();
                }
                if (piece is Knight)
                {
                    return new Rectangle();
                }
                if (piece is Rook)
                {
                    return new Rectangle();
                }
                if (piece is Pawn)
                {
                    return new Rectangle();
                }
            }
            #endregion
            return new Rectangle();
        }

        public static void test(int x, int y)
        {
            Size size = pieces.Size;
            graphics.DrawImage(pieces, x, y, new Rectangle(0, 0, size.Width / 6, size.Height / 2), GraphicsUnit.Pixel);
        }
    }
}
