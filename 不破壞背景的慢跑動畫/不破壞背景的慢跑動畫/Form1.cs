using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 不破壞背景的慢跑動畫
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, speed;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible= false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Location = new Point(this.Width, 130);
            speed = 10;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            speed = hScrollBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (a % 4)
            {
                case 0:
                    pictureBox5.Image = pictureBox1.Image;
                    a = a + 1;
                    break;
                case 1:
                    pictureBox5.Image = pictureBox2.Image;
                    a = a + 1;
                    break;
                case 2:
                    pictureBox5.Image = pictureBox3.Image;
                    a = a + 1;
                    break;
                case 3:
                    pictureBox5.Image = pictureBox4.Image;
                    a = 0;
                    break;
            }
            if (pictureBox5.Location.X >= (pictureBox5.Width))
            {
                pictureBox5.Location = new Point(pictureBox5.Location.X - speed, 130);
            }
            else
            {
                pictureBox5.Location = new Point(this.Width, 130);
            }
        }
        
    }
}
