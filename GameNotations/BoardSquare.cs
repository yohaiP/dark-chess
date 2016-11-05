﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    public class BoardSquare
    {
        readonly public Tuple<byte, byte> LocationOnBoard;
        GamePiece ContainedPiece;
        bool isSeen;
    }
}
