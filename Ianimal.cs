﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public interface Ianimal
    {
        void move_croc(Graphics g);
        void draw_croc(Graphics g);
        void setPosition(int x, int y);
        void setSpeed(int speed);
        void setMass(int mass);
    }
}
