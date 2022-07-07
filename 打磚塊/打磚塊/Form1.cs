using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打磚塊
{
    public partial class Form1 : Form
    {
        PictureBox[,] bricks; //磚塊物件參考變數(二維)
        PictureBox racket; //球拍變數
        private int brick_height = 30; //磚塊高度
        private int brick_space = 5; //磚塊間的空間大小
        private int brick_width; //磚塊寬度，等視窗放到最大後，再計算，12塊磚塊，填滿整個視窗寬邊

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //將視窗的邊框設成"無"，使視窗的邊框(連同標題列)消失
            this.TopMost = true; //將視窗設為最上層
            this.Bounds = Screen.PrimaryScreen.Bounds; //將視窗設為全螢幕

            bricks = new PictureBox[6, 12]; //建立二維的磚塊物件參考，用以指向PictureBox，注意，是指向PictureBox物件的參考，不是PictureBox物件本身
            racket = new PictureBox(); //指向一個新建立的PictureBox物件
            racket.Width = 200; racket.Height = 30; racket.BackColor = Color.DarkGreen; //球拍寬度、高度、顏色
            racket.Left = (this.Bounds.Width - racket.Width) / 2; //球拍水平位置，置中於視窗
            racket.Top = this.Bounds.Height - racket.Height - 10; //球拍垂直位置，置於視窗底部
            this.Controls.Add(racket); //將球拍物件加入Form1的控制項集合

            brick_width = (this.Bounds.Width - 13 * brick_space) / 12; //計算每一排，12個磚塊，每1個磚塊的寬度
            for (int i = 0; i <= 5; i++) //6列，12行的磚塊
            {
                for (int j = 0; j <= 11; j++)
                {
                    bricks[i, j] = new PictureBox(); //產生每一個磚塊PictureBox物件
                    switch (i)
                    {
                        case 0:
                        case 1: bricks[i, j].BackColor = Color.Red; break; //設定每一列磚塊物件的顏色
                        case 2:
                        case 3: bricks[i, j].BackColor = Color.Yellow; break;
                        case 4:
                        case 5: bricks[i, j].BackColor = Color.DarkBlue; break;
                    }
                    bricks[i, j].Height = brick_height; //磚塊的高度
                    bricks[i, j].Width = brick_width; //磚塊的寬度
                    this.Controls.Add(bricks[i, j]); //將磚塊PictureBox物件加入Form1控制項集合
                }
            }

            place_bricsk(); //喚用place_bricsk方法，排列所有的磚塊       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
