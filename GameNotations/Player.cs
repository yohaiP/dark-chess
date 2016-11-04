﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    class Player
    {
        public enum color
        {
            Black,
            White
        }

        readonly public color PlayersColor;
        List<GamePiece> PiecesBelongsToPlayer;
    }
}
