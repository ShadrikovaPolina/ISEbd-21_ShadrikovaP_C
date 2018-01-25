using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Knife
    {
        public void Clean_potato(Potato p)
        {
            if (p.Have_skin)
            {
                p.Have_skin = false;
            }
        }
        public void Clean_beet(Beet b)
        {
            if (b.Have_skin)
            {
                b.Have_skin = false;
            }
        }
        public void Clean_carrot(Carrot c)
        {
            if (c.Have_skin)
            {
                c.Have_skin = false;
            }
        }
        public void Clean_onion(Onion o)
        {
            if (o.Have_skin)
            {
                o.Have_skin = false;
            }
        }
        public void Cut_potato(Potato p)
        {
            p.Has_cut = true;
        }
        public void Cut_beet(Beet b)
        {
            b.Has_cut = true;
        }
        public void Cut_onion(Onion o)
        {
            o.Has_cut = true;
        }
        public void Cut_cabbage(Cabbage c)
        {
            c.Has_cut = true;
        }
    }
}
