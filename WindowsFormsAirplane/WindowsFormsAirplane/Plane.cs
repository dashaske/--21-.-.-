using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirplane
{
    public abstract class Plane : ITransport
    {
        protected int PosX;

        protected int PosY;

        protected int pictureWidth;

        protected int pictureHeight;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            PosX = x;
            PosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        public abstract void DrawFly(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
