using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSpeed;
        int mass;

        private Ianimal animal;


        public Form1()
        {
            InitializeComponent();
            color = Color.LightGreen;
            dopColor = Color.Brown;
            maxSpeed = 150;
            mass = 200;
            textBox1.Text = "" + maxSpeed;
            textBox2.Text = "" + mass;
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBox1.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out mass))
            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkFields())
            {
                animal = new crocodile(150, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                animal.draw_croc(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                animal = new alligator(true, 150, color, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                animal.draw_croc(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (animal != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                animal.move_croc(gr);
                pictureBox1.Image = bmp;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button4.BackColor = color;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button5.BackColor = dopColor;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
