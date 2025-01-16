﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeConsole.Models;

namespace TicTacToeConsole.Strategies
{
    public interface IBotPlayingStrategy
    {
        Move DecideMove(Player player, Board board);
    }
}
