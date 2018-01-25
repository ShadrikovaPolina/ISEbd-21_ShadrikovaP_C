using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public class River
    {

        // Список с уровнями парковки
        List<ClassArray<Ianimal>> riverStages;
        // Сколько мест на каждом уровне
        int countPlaces = 20;
        // Ширина парковочного места
        int placeSizeWidth = 210;
        // Длина парковочного места
        int placeSizeHeight = 80;
        // Текущий уровень
        int currentLevel;
        
        // Получить текущий уровень
        public int getCurrentLevel { get { return currentLevel; } }

        public River(int countStages)
        {
            riverStages = new List<ClassArray<Ianimal>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                riverStages.Add(new ClassArray<Ianimal>(countPlaces, null));
            }
        }

        // Перейти на уровень выше
        public void LevelUp()
        {
            if (currentLevel + 1 < riverStages.Count)
            {
                currentLevel++;
            }
        }

        // Перейти на уровень ниже
        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }

        public int PutCrocInRiver(Ianimal croc)
        {
            return riverStages[currentLevel] + croc;
        }
        public Ianimal GetCrocInRiver(int ticket)
        {
            return riverStages[currentLevel] - ticket;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var croc = riverStages[currentLevel][i];
                if (croc != null)
                {//если место не пустое
                    croc.setPosition(5 + i / 5 * placeSizeWidth + 90, i % 5 * placeSizeHeight + 40);
                    croc.draw_croc(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.DarkBlue, 3);
            //границы парковки
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
    }
}
