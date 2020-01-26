using System;
using System.Drawing;
using System.Media; // для воспроизведения трека
using System.Windows.Forms;

namespace oop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void LetItSnow_Click(object sender, EventArgs e)
        {
            pB_withPicture.BackgroundImage = Image.FromFile("snow2.jpg"); // пикча в bin\Debug, можно и по-другому
            progressBar.PerformStep();
        }

        private int clickCounter = 0;
        private void PushMe_Click(object sender, EventArgs e)
        {
            textBox1.Text = "You pushed the button, ok";
            clickCounter += 1;
            if (clickCounter > 1) 
            {
                textBox1.Text = "";
                textBox2.Text = "Oops, you did it again";
            }
            progressBar.PerformStep();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("It's just % operation");
            linkLabel1.LinkVisited = true;
            progressBar.PerformStep();
        }

        private int whistlerCounter = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value % 3 == 0)
            {
                SoundPlayer simpleSound = new SoundPlayer("whistle.wav");
                simpleSound.Play();
                labelForWhistler2.Visible = true;
                whistlerCounter += 1;
            }
            if (whistlerCounter > 1)
            {
                linkLabel1.Visible = true;
            }
            progressBar.PerformStep();
        }

        private void labelForProgBar_VisibleChanged(object sender, EventArgs e)
        {
            // какого хрена не работает
            if (progressBar.Value == 5)
            {
                labelForProgBar.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pB_withShapes.Refresh();
        }

        private Pen GetPen()
        {
            if (rB_red.Checked)
            {
                if (checkBox1.Checked)
                {
                    return new Pen(Color.Red, 5);
                }
                return new Pen(Color.Red, 2);
            }
            if (rB_green.Checked)
            {
                if (checkBox1.Checked)
                {
                    return new Pen(Color.Green, 5);
                }
                return new Pen(Color.Green, 2);
            }
            if (rB_blue.Checked)
            {
                if (checkBox1.Checked)
                {
                    return new Pen(Color.Blue, 5);
                }
                return new Pen(Color.Blue, 2);
            }
            return new Pen(Color.Black);
        }

        private void pB_withShapes_Paint(object sender, PaintEventArgs e)
        {
            Graphics paint = e.Graphics;
            if (cB_withShapes.SelectedIndex == 0)
            {
                paint.DrawEllipse(GetPen(), pB_withShapes.Width / 2 - 50 , pB_withShapes.Height / 2 - 50, 100, 100);
            }
            if (cB_withShapes.SelectedIndex == 1)
            {
                paint.DrawRectangle(GetPen(), pB_withShapes.Width / 2 - 50, pB_withShapes.Height / 2 - 50, 100, 100);
            }
        }

        private void rB_red_CheckedChanged(object sender, EventArgs e)
        {
            pB_withShapes.Refresh();
        }

        private void rB_blue_CheckedChanged(object sender, EventArgs e)
        {
            pB_withShapes.Refresh();
        }

        private void rB_green_CheckedChanged(object sender, EventArgs e)
        {
            pB_withShapes.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pB_withShapes.Refresh();
        }
    }
}
