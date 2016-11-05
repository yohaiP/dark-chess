using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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

        public static void test(int x, int y)
        {
            graphics.DrawImage(Pieces, x, y, new Rectangle(0,0,50,50), GraphicsUnit.Pixel);
        }
    }
}
