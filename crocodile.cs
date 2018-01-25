using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class crocodile : Chordata
    {
        public override int maxSpeed
        {
            get
            {
                return base.maxSpeed;
            }
            protected set
            {
                if (value > 100 && value < 300)
                {
                    base.maxSpeed = value;
                }
                else
                {
                    base.maxSpeed = 150;
                }
            }

        }

        public crocodile(int maxSpeed, Color color )
        {
            this.maxSpeed = maxSpeed;
            this.ColorBody = color;
            Random rand = new Random();
            startPosx = rand.Next(100, 200);
            startPosy = rand.Next(100, 200);
        }

        public override void move_croc(Graphics g)
        {
            startPosx += maxSpeed;
            draw_croc(g);
        }
        public override void draw_croc(Graphics g)
        {
            draw_sencroc(g);
        }
        protected virtual void draw_sencroc(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            PointF[] points = new PointF[10];
            points[0] = new PointF(startPosx, startPosy);
            points[1] = new PointF(startPosx, startPosy - 2);
            points[2] = new PointF(startPosx - 18, startPosy - 8);
            points[3] = new PointF(startPosx - 27, startPosy - 6);
            points[4] = new PointF(startPosx - 58, startPosy - 7);
            points[5] = new PointF(startPosx - 90, startPosy);
            points[6] = new PointF(startPosx - 58, startPosy + 7);
            points[7] = new PointF(startPosx - 27, startPosy + 6);
            points[8] = new PointF(startPosx - 18, startPosy + 8);
            points[9] = new PointF(startPosx, startPosy + 2);
            Brush br = new SolidBrush(ColorBody);
            g.FillPolygon(br, points);
            g.FillEllipse(br, startPosx - 60, startPosy - 11, 40, 22);

            g.FillEllipse(br, startPosx - 32, startPosy - 20, 5, 15);
            g.FillEllipse(br, startPosx - 52, startPosy - 20, 5, 15);
            g.FillEllipse(br, startPosx - 52, startPosy + 5, 5, 15);
            g.FillEllipse(br, startPosx - 32, startPosy + 5, 5, 15);

            Brush br1 = new SolidBrush(Color.Yellow);
            g.FillEllipse(br1, startPosx - 10, startPosy - 7, 5, 5);
            g.FillEllipse(br1, startPosx - 10, startPosy + 2, 5, 5);
        }

    }
}
