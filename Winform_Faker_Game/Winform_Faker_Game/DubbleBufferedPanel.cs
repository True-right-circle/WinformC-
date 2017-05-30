using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Faker_Game
{
    class DubbleBufferedPanel:System.Windows.Forms.Panel
    {
        public DubbleBufferedPanel()
        {
            DoubleBuffered = true;
        }
    }
}
