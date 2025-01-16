﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole.Exceptions
{
    public class InvalidGameConstructorParameterException : Exception
    {
        public InvalidGameConstructorParameterException() { }

        public InvalidGameConstructorParameterException(string message) : base(message) { }
    }
}
