using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirplane
{
    public interface IDopElements
    {
        int Number { set; }
        void DrawElements(Graphics g, int PosX, int PosY);
    }
}
