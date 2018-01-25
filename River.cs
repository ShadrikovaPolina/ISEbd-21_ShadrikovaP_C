using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
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
            int i = 0;
            foreach (var croc in riverStages[currentLevel])
            {        
                croc.setPosition(5 + i / 5 * placeSizeWidth + 90, i % 5 * placeSizeHeight + 40);
                croc.draw_croc(g);
                i++;
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    // Записываем количество уровней
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" + riverStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in riverStages)
                    {
                        // Начинаем уровень
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var croc = level[i];
                            if (croc != null)
                            { // Если место не пустое
                                // записываем тип машины
                                if (croc.GetType().Name == "crocodile")
                                {
                                    info = new UTF8Encoding(true).GetBytes("crocodile:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (croc.GetType().Name == "alligator")
                                {
                                    info = new UTF8Encoding(true).GetBytes("alligator:");
                                    fs.Write(info, 0, info.Length);
                                }
                                // Записываем параметры
                                info = new UTF8Encoding(true).GetBytes(croc.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {//считываем кол-во уровней
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (riverStages != null)
                    {
                        riverStages.Clear();
                    }
                    riverStages = new List<ClassArray<Ianimal>>(count);
                }
                else
                { /// если нет такой записи, то это не те данные
					return false;
                }
                int counter = -1;
                for (int i = 1; i < strs.Length; ++i)
                {//идем по считанным записям
                    if (strs[i] == "Level")
                    {//Начинаем новый уровень
                        counter++;
                        riverStages.Add(new ClassArray<Ianimal>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0] == "crocodile")
                    {
                        Ianimal croc = new crocodile(strs[i].Split(':')[1]);
                        int number = riverStages[counter] + croc;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "alligator")
                    {
                        Ianimal croc = new alligator(strs[i].Split(':')[1]);
                        int number = riverStages[counter] + croc;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void Sort()
        {
            riverStages.Sort();
        }
    }
}
