using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class alligator:crocodile
    {
        private bool umori;
        private Color dopColor;
        public alligator(bool umori, int maxSpeed, Color color, Color dopColor) : base (maxSpeed, color) 
        {
            this.umori = umori;
            this.dopColor = dopColor;           
        }

        protected override void draw_sencroc(Graphics g) {
            if (umori) {

                Brush br = new SolidBrush(dopColor);
                g.FillEllipse(br, startPosx - 32, startPosy - 27, 8, 22);
                g.FillEllipse(br, startPosx - 52, startPosy - 27, 8, 22);
                g.FillEllipse(br, startPosx - 52, startPosy + 5, 8, 22);
                g.FillEllipse(br, startPosx - 32, startPosy + 5, 8, 22);
            }
            base.draw_sencroc(g);

        }
    }
}
