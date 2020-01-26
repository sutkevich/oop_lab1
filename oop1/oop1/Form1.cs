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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            switch (cB_withShapes.Text)
            {
                case "ellips":
                    {
                        
                        int centerX = 50;
                        int centerY = 50;
                        int radius = 25;
                        e.Graphics.DrawEllipse(Pens.Blue, centerX, centerY, radius, radius);
                        MessageBox.Show("ok");
                        break;
                    }
                case "rectangle":
                    {

                        break;
                    }
                    //default: break;
            }
            */
        }

        private void labelForWhistler_Click(object sender, EventArgs e)
        {
        }

        private void progressBar_Click(object sender, EventArgs e)
        {            
        }

        private void labelForProgBar_Click(object sender, EventArgs e)
        {
        }

        private void pB_withPicture_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
