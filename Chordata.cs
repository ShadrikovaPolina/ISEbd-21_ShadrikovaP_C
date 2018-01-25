using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    abstract class Chordata : Ianimal
    {
        protected float startPosx;
        protected float startPosy;
        protected int mass;
        public virtual int maxSpeed{ protected set; get; }
        public Color ColorBody { protected set; get; }
        public abstract void move_croc(Graphics g);
        public abstract void draw_croc(Graphics g);

        public void setPosition(int x,int y) {
            startPosx = x;
            startPosy = y;
        }

        public void setMass(int mass){
            this.mass = mass;
        }
        public void setSpeed(int speed) {

        }

        
    }
}
