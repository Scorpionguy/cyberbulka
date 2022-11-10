using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace bulka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comeback(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(ClientSize.Width);
            int h = Convert.ToInt32(ClientSize.Height);
            int ww = w / 2;
            int hh = h / 2;
            if (button1.Location.X > w)
            {
                button1.Location = new Point(button1.Location.X - ww, button1.Location.Y);
            }
            if (button1.Location.X < 0)
            {
                button1.Location = new Point(button1.Location.X + ww, button1.Location.Y);
            }
            if (button1.Location.Y > h)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - hh);
            }
            if (button1.Location.Y < 0)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + hh);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void button1_MouseEnter(object sender, EventArgs e)
        {  
            Random rnd = new Random();
            int x = 1;
            int y = -1;
            int z = x * y;
            for (int i = -1; i < 1; i++)
            {
                int value = rnd.Next(200, 350);
                int value2 = rnd.Next(200, 350);
                if (z >= 0)
                {
                    button1.Location = new Point(button1.Location.X + value, button1.Location.Y - value2);
                }
                else
                {
                    button1.Location = new Point(button1.Location.X - value, button1.Location.Y + value2);
                }
                z++;
                int w = Convert.ToInt32(ClientSize.Width);
                int h = Convert.ToInt32(ClientSize.Height);
                int ww = w / 2;
                int hh = h / 2;
                if (button1.Location.X > w)
                {
                    button1.Location = new Point(button1.Location.X - ww, button1.Location.Y);
                }
                if (button1.Location.Y > h || button1.Location.Y < 0)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - hh);
                }
                SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\lapin\source\repos\bulka\bulka\Properties\sound.wav");
                soundPlayer.Play();
                soundPlayer.PlayLooping();
            }

        }
        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int x = 1;
            int y = -1;
            int z = x * y;
            for (int i = -1; i < 1; i++)
            {
                int value = rnd.Next(200, 350);
                int value2 = rnd.Next(200, 350);
                if (z >= 0)
                {
                    button1.Location = new Point(button1.Location.X + value, button1.Location.Y - value2);
                }
                else
                {
                    button1.Location = new Point(button1.Location.X - value, button1.Location.Y + value2);
                }
                z++;
                int w = Convert.ToInt32(ClientSize.Width);
                int h = Convert.ToInt32(ClientSize.Height);
                int ww = w / 2;
                int hh = h / 2;
                if (button1.Location.X > w)
                {
                    button1.Location = new Point(button1.Location.X - ww, button1.Location.Y);
                }
                if (button1.Location.Y > h || button1.Location.Y < 0)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - hh);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
