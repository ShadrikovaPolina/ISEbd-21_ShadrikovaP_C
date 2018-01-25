using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class FryingPan
    {
        private Beet[] beet;
        private Oil oil;
        private Carrot[] carrot;
        private Onion[] onion;
        private Water[] water;
        public bool PassivationIsReady { set; get; }
        public bool StewBeetIsReady { set; get; }
        public void Init(int countBeet, int countCarrot, int countOnion)
        {
            PassivationIsReady = false;
            StewBeetIsReady = false;
            beet = new Beet[countBeet];
            carrot = new Carrot[countCarrot];
            onion = new Onion[countOnion];
            water = new Water[1];
        }
        public void AddBeet(Beet b)
        {
            for (int i = 0; i < beet.Length; i++)
            {
                if (beet[i] == null)
                {
                    beet[i] = b;
                }
            }
        }
        public void AddOil(Oil o)
        {
            oil = o;
        }
        public void AddCarrot(Carrot c)
        {
            for (int i = 0; i < carrot.Length; i++)
            {
                if (carrot[i] == null)
                {
                    carrot[i] = c;
                }
            }
        }
        public void AddOnion(Onion O)
        {
            for (int i = 0; i < onion.Length; i++)
            {
                if (onion[i] == null)
                {
                    onion[i] = O;
                }
            }
        }
        public void AddWater(Water w)
        {
            for (int i = 0; i < water.Length; i++)
            {
                if (water[i] == null)
                {
                    water[i] = w;
                }
            }
        }
        private bool firstCheck()
        {
            if (carrot.Length == 0)
            {
                return false;
            }
            if (onion.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < carrot.Length; i++)
            {
                if (carrot[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < onion.Length; i++)
            {
                if (onion[i] == null)
                {
                    return false;
                }
            }
            return true;
        }
        public bool FirstReadyToGo { get { return firstCheck(); } }
        public void Cook()
        {
            if (firstCheck() && !secondCheck())
            {
                PassivationIsReady = true;
            }
            else if (firstCheck() && secondCheck())
            {
                StewBeetIsReady = true;
            }
        }
        private bool secondCheck()
        {
            if (beet.Length == 0)
            {
                return false;
            }
            if (water.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < water.Length; i++)
            {
                if (water[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < beet.Length; i++)
            {
                if (beet[i] == null)
                {
                    return false;
                }
            }
            return true;
        }
        public bool SecondReadyToGo { get { return secondCheck(); } }
    }
}
