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
        public Form()
        {
            InitializeComponent();
            bg = Properties.Resources.bg1;
        }
        Image bg;

        private void dubbleBufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bg, ClientRectangle);
        }
    }
}
