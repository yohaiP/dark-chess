﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotations
{
    [Serializable]
    public class Player
    {
        public enum color
        {
            Black,
            White
        }

        readonly public color PlayersColor;
        public List<GamePiece> PiecesBelongsToPlayer = new List<GamePiece>();

        public Player(color color)
        {
            PlayersColor = color;
        }
    }
}
