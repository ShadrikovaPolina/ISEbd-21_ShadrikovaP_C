﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class RiverOverflowException : Exception
    {
        public RiverOverflowException() : base("В реке нет свободных мест!") { }
    }
}
