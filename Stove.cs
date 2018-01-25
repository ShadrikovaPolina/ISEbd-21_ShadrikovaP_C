using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Stove
    {
        private Pan pan;
        private FryingPan fryingPan;
        public bool State;
        public Pan Pan { set { pan = value; } get { return pan; } }
        public FryingPan FryingPan { set { fryingPan = value; } get { return fryingPan; } }
        public void CookPan()
        {
            pan.Cook();
        }
        public void CookFryingPan()
        {
            fryingPan.Cook();
        }
    }
}
