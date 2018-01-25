using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class alligator : crocodile, IComparable<alligator>, IEquatable<alligator>
    {
        private bool umori;
        private Color dopColor;

        public alligator(bool umori, int maxSpeed, Color color, Color dopColor) : base (maxSpeed, color) 
        {
            this.umori = umori;
            this.dopColor = dopColor;           
        }

        public alligator(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                maxSpeed = Convert.ToInt32(strs[0]);
                ColorBody = Color.FromName(strs[1]);
                umori = Convert.ToBoolean(strs[2]);
                dopColor = Color.FromName(strs[3]);
            }
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

        public void setDopColor(Color color)
        {
            dopColor = color;
        }

        public override string getInfo()
        {
            return maxSpeed + ";" + ColorBody.Name + ";" + umori + ";" + dopColor;
        }

        public int CompareTo(alligator other)
        {
            var res = (this is crocodile).CompareTo(other is crocodile);
            if (res != 0)
            {
                return res;
            }
            if (umori != other.umori)
            {
                return umori.CompareTo(other.umori);
            }
            if (dopColor != other.dopColor)
            {
                dopColor.Name.CompareTo(other.dopColor.Name);
            }
            return 0;
        }

        public bool Equals(alligator other)
        {
            var res = (this is crocodile).Equals(other is crocodile);
            if (!res)
            {
                return res;
            }
            if (umori != other.umori)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            alligator crocObj = obj as alligator;
            if (crocObj == null)
            {
                return false;
            }
            else
            {
                return Equals(crocObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
