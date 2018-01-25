using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class RiverAlreadyHaveException : Exception
    {
        public RiverAlreadyHaveException() : base("На уровне уже есть такой крокодил!") { }
    }
}
