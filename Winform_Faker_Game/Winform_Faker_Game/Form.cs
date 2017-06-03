using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;


namespace Winform_Faker_Game
{
    public partial class Form : System.Windows.Forms.Form
    {

        private int MoveR;
        private int MoveL;
        private int MoveD;
        private int MoveU;
        private int count;
        private int count2;
        private int index;
        private int b;
        private int px = 10;
        ImageList.ImageCollection images
        {
            get
            {
                return imageList.Images;
            }
        }

        Point E1 = new Point(35, 244);
        private void showchar()
        {
            if (count > 6) //6초마다
            {
                if (index < 1)
                {
                    EnemyBox1.Image = imageList.Images[0];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox1.Location.X<=50)
                {
                    EnemyBox1.Location = new Point(488, 212);
                    EnemyBox1.Left += 0;
                    count = 0;
                    EnemyBox1.Image = imageList.Images[1];
                }
                else
                {
                    EnemyBox1.Left -= px;
                }
            } //오른쪽 적 1


            if (count2 > 10) //20초마다
            {
                if (index < 1)
                {
                    EnemyBox2.Image = imageList.Images[0];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox2.Location.X <= 120)
                {
                    EnemyBox2.Location = new Point(439, 382);
                    EnemyBox2.Left += 0;
                    count = 0;
                    EnemyBox2.Image = imageList.Images[1];
                }
                else
                {
                    EnemyBox2.Left -= px;
                    EnemyBox2.Top -= px;
                }
            }//오른쪽 아래의 적


        }

        public Form()
        {
            InitializeComponent();
            bgimage = Properties.Resources.Game_bg;
            enemy1 = Properties.Resources.Nau;
            index = 0;
            count = 0;
            MoveR = 90;
            MoveL = 70;
            MoveU = 120;
            MoveD = 110;

        }

        Image bgimage, enemy1;



        private void Form_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveL -= 10;
                MoveR += 10;
                if (MoveL < 0)
                {
                    pictureBox2.Left -= 0;
                    MoveR = 160;
                    MoveL = 0;
                }
                else
                {
                    pictureBox2.Left -= 10;

                }

            }
            else if (e.KeyCode == Keys.Right)
            {
                MoveR -= 10;
                MoveL += 10;
                if (MoveR < 0)
                {
                    pictureBox2.Left += 0;
                    MoveR = 0;
                    MoveL = 160;
                }
                else
                {
                    pictureBox2.Left += 10;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                MoveU -= 10;
                MoveD += 10;
                if (MoveU < 0)
                {
                    pictureBox2.Top -= 0;
                    MoveU = 0;
                    MoveD = 230;
                }
                else
                {
                    pictureBox2.Top -= 10;
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                MoveU += 10;
                MoveD -= 10;
                if (MoveD < 0)
                {
                    pictureBox2.Top += 0;
                    MoveD = 0;
                    MoveU = 230;

                }
                else
                {
                    pictureBox2.Top += 10;

                }

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            showchar();
            count++;
            count2++;
        }

        private void dubbleBufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bgimage, ClientRectangle);
        }


    }
}
