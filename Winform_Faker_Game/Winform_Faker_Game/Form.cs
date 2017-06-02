using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Faker_Game
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int MoveR;
        private int MoveL;
        private int pX;
        private int MoveD;
        private int MoveU;

        public Form()
        {
            InitializeComponent();
            bgimage = Properties.Resources.Game_bg;

            MoveR = 110;
            MoveL = 70;
            MoveU = 120;
            MoveD = 110;

        }

        Image bgimage;

        private void Form_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveL -= 10;
                MoveR += 10;
                if (MoveL < 0)
                {
                    pictureBox2.Left -= 0;
                    MoveR = 180;
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
                    MoveL = 180;
                }
                else
                {
                    pictureBox2.Left +=10;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                MoveU -= 10;
                MoveD += 10;
                if(MoveU <0)
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
                if(MoveD < 0)
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

        private void dubbleBufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bgimage, ClientRectangle);
        }
    }
}
