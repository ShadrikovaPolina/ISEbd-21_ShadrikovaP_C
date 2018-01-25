using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class WaterTap
    {
        public bool State;
        public void Wash_potato(Potato p)
        {
            if (State)
            {
                p.Dirty = 0;
            }
        }
        public void Wash_beet(Beet b)
        {
            if (State)
            {
                b.Dirty = 0;
            }
        }
        public void Wash_carrot(Carrot c)
        {
            if (State)
            {
                c.Dirty = 0;
            }
        }
        public void Wash_onion(Onion o)
        {
            if (State)
            {
                o.Dirty = 0;
            }
        }
        public Water GetWater()
        {
            if (State)
            {
                return new Water();
            }
            else
            {
                return null;
            }
        }
    }
}
