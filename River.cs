using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class River
    {
        ClassArray<Ianimal> river;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;

        public River()
        {
            river = new ClassArray<Ianimal>(countPlaces, null);
        }

        public int PutCrocInRiver(Ianimal croc)
        {
            return river + croc;
        }
        public Ianimal GetCrocInRiver(int ticket)
        {
            return river - ticket;
        }

        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var croc = river.getObject(i);
                if (croc != null)
                {
                    croc.setPosition(5 + i / 5 * placeSizeWidth + 90, i % 5 * placeSizeHeight + 40);
                    croc.draw_croc(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.DarkBlue, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 100, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
    }
}
