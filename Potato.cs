using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Potato
    {
        private int has_ready = 0;
        private int dirt = 10;
        public int Has_ready { get { return has_ready; } }
        public bool Have_skin;
        public bool Has_cut;
        public int Dirty { set { if (value > -1 && value < 11) dirt = value; } get { return dirt; } }
        public void GetHeat()
        {
            if (has_ready < 3)
            {
                has_ready = 3;
            }
        }
    }
}
