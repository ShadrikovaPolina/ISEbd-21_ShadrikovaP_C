using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Pan
    {
        private Water[] water = new Water[3];
        private Potato[] potato;
        private Passivation passivation;
        public Passivation Passivat { set { passivation = value; } get { return passivation; } }
        private StewBeet stewBeet;
        public StewBeet SB { set { stewBeet = value; } get { return stewBeet; } }
        private Meat[] meat;
        private Cabbage[] cabbage;
        private Salt salt;
        public bool IsReady = false;
        public void Init(int countPotatos, int countCabbage, int countMeat)
        {
            potato = new Potato[countPotatos];
            passivation = new Passivation();
            passivation.isReady = false;
            stewBeet = new StewBeet();
            stewBeet.isReady = false;
            meat = new Meat[countMeat];
            cabbage = new Cabbage[countCabbage];
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
        public void AddPotato(Potato p)
        {
            for (int i = 0; i < potato.Length; i++)
            {
                potato[i] = p;
            }
        }
        public void AddMeat(Meat m)
        {
            for (int i = 0; i < meat.Length; i++)
            {
                meat[i] = m;
            }
        }
        public void AddCabbage(Cabbage c)
        {
            for (int i = 0; i < cabbage.Length; i++)
            {
                cabbage[i] = c;
            }
        }
        public void AddSalt(Salt s)
        {
            salt = s;
        }
        private bool firstCheck()
        {
            for (int i = 0; i < water.Length; i++)
            {
                if (water[i] == null)
                {
                    return false;
                }
            }
            if (meat.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < meat.Length; i++)
            {
                if (meat[i] == null)
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
                while (!MeatIsReady())
                {
                    if (water[0].Temperature < 100)
                    {
                        for (int i = 0; i < water.Length; i++)
                        {
                            water[i].GetHeat();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < meat.Length; i++)
                        {
                            meat[i].GetHeat();
                        }
                    }
                }
            }
            else if (firstCheck() && secondCheck())
            {
                IsReady = true;
            }
        }
        public bool MeatIsReady()
        {
            for (int i = 0; i < water.Length; i++)
            {
                if (water[i].Temperature < 100)
                {
                    return false;
                }
            }
            for (int i = 0; i < meat.Length; i++)
            {
                if (meat[i].Has_ready < 4)
                {
                    return false;
                }
            }
            return true;
        }
        private bool secondCheck()
        {
            if (potato.Length == 0)
            {
                return false;
            }
            if (cabbage.Length == 0)
            {
                return false;
            }
            if (!passivation.isReady)
            {
                return false;
            }
            if (!stewBeet.isReady)
            {
                return false;
            }
            for (int i = 0; i < potato.Length; i++)
            {
                if (potato[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < cabbage.Length; i++)
            {
                if (cabbage[i] == null)
                {
                    return false;
                }
            }
            return true;
        }
        public bool SecondReadyToGo { get { return secondCheck(); } }
    }
}
