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
        static Bitmap Pieces;

        public static void CreateGraphics(object sender)
        {
            DarkChessClient client = (DarkChessClient)sender;
            graphics = client.board.CreateGraphics();
            Pieces = (Bitmap)Image.FromFile(@"pieces.png", true);
            Pieces.MakeTransparent();
        }

        static Rectangle ImagePartOfPiece(GamePiece piece)
        {
            if (piece is King && piece.PlayerRelevance.PlayersColor == Player.color.White)
            {
                return new Rectangle(0, 0, 100, 100);
            }
            return new Rectangle();
        }

        public static void test(int x, int y)
        {
            graphics.DrawImage(Pieces, x, y, new Rectangle(0,0,50,50), GraphicsUnit.Pixel);
        }
    }
}
