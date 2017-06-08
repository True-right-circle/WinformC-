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

namespace Faker
{

    public partial class Game : Form
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

        private bool paused; //일시정지 플래그
        private bool resume; //다시 시작 플래그

        private int index;
        private int px = 10;
        ImageList.ImageCollection Images
        {
            
            get
            {
                return imageList.Images;
            }
        }

        
        Point E1 = new Point(35, 244);
        private void showchar()
        {
            EnemyBox1.Visible = false;
            EnemyBox2.Visible = false;
            EnemyBox3.Visible = false;
            EnemyBox4.Visible = false;
            EnemyBox5.Visible = false;
            EnemyBox6.Visible = false;
            EnemyBox7.Visible = false;
            EnemyBox8.Visible = false;
           

            if (count > 6) //오른쪽 적
            {
                if (index < 1)
                {
                    
                    EnemyBox1.Image = imageList.Images[1];
                    EnemyBox1.Visible = true;
                    EnemyBox1.BackColor = Color.Transparent;
                    EnemyBox1.Parent = pictureBox1;
                }
                else
                {
                    index = 0;
                }


                if (EnemyBox1.Location.X <= 100)
                {
                    EnemyBox1.Location = new Point(693, 201);
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
                    EnemyBox2.Visible = true;
                    EnemyBox2.BackColor = Color.Transparent;
                    EnemyBox2.Parent = pictureBox1;
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox2.Location.Y <= 110)
                {
                    EnemyBox2.Location = new Point(513, 410);
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
                    EnemyBox3.Visible = true;
                    EnemyBox3.BackColor = Color.Transparent;
                    EnemyBox3.Parent = pictureBox1;
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox3.Location.Y <= 110)
                {
                    EnemyBox3.Location = new Point(266, 440);
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
                    EnemyBox4.Visible = true;
                    EnemyBox4.BackColor = Color.Transparent;
                    EnemyBox4.Parent = pictureBox1;
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox4.Location.Y <= 110)
                {
                    EnemyBox4.Location = new Point(196, 346);
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
                    EnemyBox5.Visible = true;
                    EnemyBox5.BackColor = Color.Transparent;
                    EnemyBox5.Parent = pictureBox1;
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox5.Location.Y >= 400)
                {
                    EnemyBox5.Location = new Point(182, 206);
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
                    EnemyBox6.Visible = true;
                    EnemyBox6.BackColor = Color.Transparent;
                    EnemyBox6.Parent = pictureBox1;
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox6.Location.Y >= 400)
                {
                    EnemyBox6.Location = new Point(211, 102);
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
                    EnemyBox7.Visible = true;
                    EnemyBox7.BackColor = Color.Transparent;
                    EnemyBox7.Parent = pictureBox1;
                }
                else
                {
                    index = 0;
                }

                if (EnemyBox7.Location.Y >= 440)
                {
                    EnemyBox7.Location = new Point(350, 79);
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
                        EnemyBox8.Visible = true;
                        EnemyBox8.BackColor = Color.Transparent;
                        EnemyBox8.Parent = pictureBox1;
                    }
                    else
                    {
                        index = 0;
                    }

                    if (EnemyBox8.Location.Y >= 400)
                    {
                        EnemyBox8.Location = new Point(493, 117);
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
        public Game()
        {
            InitializeComponent();
            bgimage = Properties.Resources.Game_bg;
            defeatimg = Properties.Resources.defeatimg;
            enemy1 = Properties.Resources.Nau;

            mainchareBox.BackColor = Color.Transparent;
            mainchareBox.Parent = pictureBox1;

            pictureBox1.Image = new Bitmap(bgimage);
            pictureBox1.SendToBack();
            index = 0;
            count = 0;
            count2 = 0;
            MoveR = 90;
            MoveL = 70;
            MoveU = 120;
            MoveD = 110;
        }
        Image enemy1, bgimage, defeatimg;

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

       
        public void Restart()
        {
            if (resume)
            {

                paused = false;

                EnemyBox1.Location = new Point(693, 201);       //여기 애들 초기화 하는데 자꾸 다른 위치로감;
                EnemyBox2.Location = new Point(513, 410);
                EnemyBox3.Location = new Point(266, 440);
                EnemyBox4.Location = new Point(196, 346);
                EnemyBox5.Location = new Point(182, 206);
                EnemyBox6.Location = new Point(211, 102);
                EnemyBox7.Location = new Point(350, 79);
                EnemyBox8.Location = new Point(493, 117);
                mainchareBox.Location = new Point(360,251);
                MoveR = 90;
                MoveL = 70;
                MoveU = 120;
                MoveD = 110;

                timer.Enabled = true;
                timer.Start();
     

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            showchar();
            count++;            //난이도
            count2++;
            count3++;
            count4++;
            count5++;
            count6++;
            count7++;
            count8++;

            retrybox.Visible = false;
            //failbox.Visible = false;


            if (mainchareBox.Bounds.IntersectsWith(EnemyBox1.Bounds))
            {

                paused = true;
                retrybox.Visible = true;
                //failbox.Visible = true;
                count = 0;            
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
                count8 = 0;

            }
            else if (mainchareBox.Bounds.IntersectsWith(EnemyBox2.Bounds))
            {
                paused = true;
                retrybox.Visible = true;
                //failbox.Visible = true;
                count = 0;            
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
                count8 = 0;

            }
            else if (mainchareBox.Bounds.IntersectsWith(EnemyBox3.Bounds))
            {
                paused = true;
                retrybox.Visible=true;
                //failbox.Visible = true;
                count = 0;            
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
                count8 = 0;

            }
            else if (mainchareBox.Bounds.IntersectsWith(EnemyBox4.Bounds))
            {
                paused = true;
                retrybox.Visible = true;
                //failbox.Visible = true;
                count = 0;            
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
                count8 = 0;

            }
            else if (mainchareBox.Bounds.IntersectsWith(EnemyBox5.Bounds))
            {
                paused = true;
                retrybox.Visible = true;
                //failbox.Visible = true;
                count = 0;            
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
                count8 = 0;

            }
            else if (mainchareBox.Bounds.IntersectsWith(EnemyBox6.Bounds))
            {
                paused = true;
                retrybox.Visible = true;
                //failbox.Visible = true;
                count = 0;            
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
                count8 = 0;

            }
            else if (mainchareBox.Bounds.IntersectsWith(EnemyBox7.Bounds))
            {
                paused = true;
                retrybox.Visible = true;
                //failbox.Visible = true;
                count = 0;           
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
                count8 = 0;

            }
            else if (mainchareBox.Bounds.IntersectsWith(EnemyBox8.Bounds))
            {
                paused = true;
                retrybox.Visible = true;
                //failbox.Visible = true;
                count = 0;            
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
                count8 = 0;

            }

            if (paused)
            {
                timer.Enabled = false;
                timer.Stop();
            }
           

        }


        public void retry_Click(object sender, MouseEventArgs e)
        {
            //Regame_Message();     
            resume = true;
            paused = false;
            Restart();
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bgimage, ClientRectangle);
        }

        private void retrybox_Click(object sender, EventArgs e)
        {
            resume = true;
            paused = false;
            Restart();
        }

        private void doubleBufferedPanel_Paint(object sender, PaintEventArgs e)
        {
           e.Graphics.DrawImage(bgimage, ClientRectangle);

        }


    }
}

  
