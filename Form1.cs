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
    public partial class Form1 : Form
    {
        // река
        River river;

        Form2 form;
        
        public Form1()
        {
            InitializeComponent();
            river = new River(5);
            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Уровень " + i);
            }
            listBox1.SelectedIndex = river.getCurrentLevel;
            Draw();
        }

        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                river.Draw(gr);
                pictureBox1.Image = bmp;
            }
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
                MessageBox.Show("Ваше место: " + (place));
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
                    MessageBox.Show("Ваше место: " + (place));
                }
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    Ianimal croc = river.GetCrocInRiver(Convert.ToInt32(maskedTextBox1.Text));
                    if (croc != null)
                    {//если удалось забрать, то отрисовываем
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        croc.setPosition(90, 50);
                        croc.draw_croc(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {//иначе сообщаем об этом
                        MessageBox.Show("Извините, на этом месте нет крокодила");
                    }
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            river.LevelDown();
            listBox1.SelectedIndex = river.getCurrentLevel;
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            river.LevelUp();
            listBox1.SelectedIndex = river.getCurrentLevel;
            Draw();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            form = new Form2();
            form.AddEvent(AddCroc);
            form.Show();
        }

        private void AddCroc(Ianimal croc)
        {
            if (croc != null)
            {
                int place = river.PutCrocInRiver(croc);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Крокодила не удалось запустить");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (river.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (river.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Не загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
