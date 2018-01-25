using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        River river;

        public Form1()
        {
            InitializeComponent();
            river = new laba3.River();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            river.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var croc = new crocodile(150, dialog.Color);
                int place = river.PutCrocInRiver(croc);
                Draw();
                MessageBox.Show("Ваше место: " +(1+ place));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var croc = new alligator(true, 150, dialog.Color, dialogDop.Color);
                    int place = river.PutCrocInRiver(croc);
                    Draw();
                    MessageBox.Show("Ваше место: " +(1+ place));
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var croc = river.GetCrocInRiver(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                croc.setPosition(100, 50);
                croc.draw_croc(gr);
                pictureBox2.Image = bmp;
                Draw();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
