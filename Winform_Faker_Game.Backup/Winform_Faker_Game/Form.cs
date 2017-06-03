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
        private int count3;
        private int count4;
        private int count5;
        private int count6;
        private int count7;
        private int count8;

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
            if (count > 6) //오른쪽 적
            {
                if (index < 1)
                {
                    EnemyBox1.Image = imageList.Images[1];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox1.Location.X <= 100)
                {
                    EnemyBox1.Location = new Point(488, 212);
                    EnemyBox1.Left += 0;
                    count = 0;
                    EnemyBox1.Image = imageList.Images[0];
                }
                else
                {
                    EnemyBox1.Left -= px;
                }
            } 


            if (count2 > 10) //오른쪽 아래의 적
            {
                if (index < 1)
                {
                    EnemyBox2.Image = imageList.Images[2];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox2.Location.X <= 120)
                {
                    EnemyBox2.Location = new Point(439, 382);
                    EnemyBox2.Left += 0;
                    count2 = 0;
                    EnemyBox2.Image = imageList.Images[0];
                }
                else
                {
                    EnemyBox2.Left -= px;
                    EnemyBox2.Top -= px;
                }
            }

            if (count3 > 15) // 왼쪽 아래의 적
            {
                if (index < 1)
                {
                    EnemyBox3.Image = imageList.Images[3];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox3.Location.X >= 450)
                {
                    EnemyBox3.Location = new Point(176, 438);
                    EnemyBox3.Left += 0;
                    count3 = 0;
                    EnemyBox3.Image = imageList.Images[0];
                }
                else
                {
                    EnemyBox3.Left += px;
                    EnemyBox3.Top -= px;
                }
            }


            if (count4 > 20) // 왼쪽 아래의 적2
            {
                if (index < 1)
                {
                    EnemyBox4.Image = imageList.Images[4];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox4.Location.X >= 350)
                {
                    EnemyBox4.Location = new Point(106, 344);
                    EnemyBox4.Left += 0;
                    count4 = 0;
                    EnemyBox4.Image = imageList.Images[0];
                }
                else
                {
                    EnemyBox4.Left += px;
                    EnemyBox4.Top -= px;
                }
            }

            if (count5 > 25) //왼쪽 적
            {
                if (index < 1)
                {
                    EnemyBox5.Image = imageList.Images[5];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox5.Location.X >= 250)
                {
                    EnemyBox5.Location = new Point(83, 215);
                    EnemyBox5.Left += 0;
                    count5 = 0;
                    EnemyBox5.Image = imageList.Images[0];
                }
                else
                {
                    EnemyBox5.Left += px;
                    EnemyBox5.Top += px;
                }
            }


            if (count6 > 30) // 왼위쪽 적
            {
                if (index < 1)
                {
                    EnemyBox6.Image = imageList.Images[6];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox6.Location.X >= 350)
                {
                    EnemyBox6.Location = new Point(121, 100);
                    EnemyBox6.Left += 0;
                    count6 = 0;
                    EnemyBox6.Image = imageList.Images[0];
                }
                else
                {
                    EnemyBox6.Left += px;
                    EnemyBox6.Top += px;
                }
            }
            if (count7 > 35) //  위의 적
            {
                if (index < 1)
                {
                    EnemyBox7.Image = imageList.Images[7];
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox7.Location.Y >= 440)
                {
                    EnemyBox7.Location = new Point(260, 77);
                    EnemyBox7.Left += 0;
                    count7 = 0;
                    EnemyBox7.Image = imageList.Images[0];
                }
                else
                {
                    EnemyBox7.Top += px;
                }

                if (count8 > 40) //왼위쪽 적
                {
                    if (index < 1)
                    {
                        EnemyBox8.Image = imageList.Images[8];
                    }
                    else
                    {
                        index = 0;
                    }

                    if (EnemyBox8.Location.X <= 150)
                    {
                        EnemyBox8.Location = new Point(403, 115);
                        EnemyBox8.Left += 0;
                        count8 = 0;
                        EnemyBox8.Image = imageList.Images[0];
                    }
                    else
                    {
                        EnemyBox8.Left -= px;
                        EnemyBox8.Top += px;
                    }
                }
            }

        }

        public Form()
        {
            InitializeComponent();
            bgimage = Properties.Resources.Game_bg;
            enemy1 = Properties.Resources.Nau;
            index = 0;
            count = 0;
            count2 =0;
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
                    mainchareBox.Left -= 0;
                    MoveR = 160;
                    MoveL = 0;
                }
                else
                {
                    mainchareBox.Left -= 10;

                }

            }
            else if (e.KeyCode == Keys.Right)
            {
                MoveR -= 10;
                MoveL += 10;
                if (MoveR < 0)
                {
                    mainchareBox.Left += 0;
                    MoveR = 0;
                    MoveL = 160;
                }
                else
                {
                    mainchareBox.Left += 10;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                MoveU -= 10;
                MoveD += 10;
                if (MoveU < 0)
                {
                    mainchareBox.Top -= 0;
                    MoveU = 0;
                    MoveD = 230;
                }
                else
                {
                    mainchareBox.Top -= 10;
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                MoveU += 10;
                MoveD -= 10;
                if (MoveD < 0)
                {
                    mainchareBox.Top += 0;
                    MoveD = 0;
                    MoveU = 230;

                }
                else
                {
                    mainchareBox.Top += 10;

                }

            }
        }
    

        private void timer_Tick(object sender, EventArgs e)
        {
            showchar();
            count++;
            count2++;
            count3++;
            count4++;
            count5++;
            count6++;
            count7++;
            count8++;
        }

        private void dubbleBufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bgimage, ClientRectangle);
        }


    }
}
