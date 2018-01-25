using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;
            panel7.MouseDown += panelColor_MouseDown;
            panel8.MouseDown += panelColor_MouseDown;
            panel9.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        Ianimal croc = null;
        public Ianimal getCroc { get { return croc; } }

        private void DrawCroc()
        {
            if (croc != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                croc.setPosition(100, 50);
                croc.draw_croc(gr);
                pictureBox1.Image = bmp;
            }
        }

        private event myDel eventAddCroc;

        private void labelCroc_MouseDown(object sender, MouseEventArgs e)
        {
            labelCroc.DoDragDrop(labelCroc.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {//случайным образом выбираем какая машина встанет
                case "Crocodile":
                    croc = new crocodile(150, Color.Green);
                    break;
                case "Alligator":
                    croc = new alligator(true, 150, Color.Green, Color.DarkGreen);
                    break;
            }
            DrawCroc();
        }

        // Проверяем, что мы принимаем
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelAll_MouseDown(object sender, MouseEventArgs e)
        {
            labelAll.DoDragDrop(labelAll.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBase_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBase_DragDrop(object sender, DragEventArgs e)
        {
            if (croc != null)
            {
                croc.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCroc();
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
              DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDop_DragDrop(object sender, DragEventArgs e)
        {
            if (croc != null)
            {
                if (croc is alligator)
                {
                    (croc as alligator).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCroc();
                }
            }
        }

        public void AddEvent(myDel ev)
        {
            if (eventAddCroc == null)
            {
                eventAddCroc = new myDel(ev);
            }
            else
            {
                eventAddCroc += ev;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (eventAddCroc != null)
            {
                eventAddCroc(croc);
            }
            Close();
        }

        private void labelBase_MouseDown(object sender, MouseEventArgs e)
        {
            labelBase.DoDragDrop(labelCroc.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDop_MouseDown(object sender, MouseEventArgs e)
        {
            labelDop.DoDragDrop(labelCroc.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBase_Click(object sender, EventArgs e)
        {
        }

        private void labelDop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
