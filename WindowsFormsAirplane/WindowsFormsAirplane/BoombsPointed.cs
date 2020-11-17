using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirplane
{
    class PointedBoombs : IDopElements
    {
        private BoombsEnum _countBoomb;
        public int Number { set => _countBoomb = (BoombsEnum)value; }

        public Color DopColor { private set; get; }

        public PointedBoombs(int bombs, Color dopColor)
        {
            Number = bombs;
            DopColor = dopColor;
        }
        public void DrawElements(Graphics g, int PosX, int PosY)
        {
            switch (_countBoomb)
            {
                case BoombsEnum.six:
                    Draw6Boombs(g, PosX, PosY);
                    break;

                case BoombsEnum.eight:
                    Draw8Boombs(g, PosX, PosY);
                    break;

                case BoombsEnum.ten:
                    Draw10Boombs(g, PosX, PosY);
                    break;
            }
        }
        Pen pen = new Pen(Color.Black);
        private void Draw6Boombs(Graphics g, int PosX, int PosY)
        {
            for (int i = 0; i < 3; i++)
            {
                Brush brush = new SolidBrush(Color.Black);
                int X = i * 15;
                int Y = i * 20;
                g.FillEllipse(brush, PosX + 155 - X, PosY - 30 + Y, 30, 10);
                g.FillRectangle(brush, PosX + 155 - X, PosY - 30 + Y, 15, 12);
                g.FillEllipse(brush, PosX + 130 - X, PosY + 80 + Y, 30, 10);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 15, 12);
                brush.Dispose();
            }

        }
        private void Draw8Boombs(Graphics g, int PosX, int PosY)
        {
            for (int i = 0; i < 4; i++)
            {
                Brush brush = new SolidBrush(Color.Black);
                int X = i * 15;
                int Y = i * 20;
                g.FillEllipse(brush, PosX + 170 - X, PosY - 40 + Y, 30, 10);
                g.FillRectangle(brush, PosX + 170 - X, PosY - 40 + Y, 15, 12);
                g.FillEllipse(brush, PosX + 130 - X, PosY + 80 + Y, 30, 10);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 15, 12);
                brush.Dispose();
            }
        }
        private void Draw10Boombs(Graphics g, int PosX, int PosY)
        {
            for (int i = 0; i < 5; i++)
            {
                Brush brush = new SolidBrush(Color.Black);
                int X = i * 15;
                int Y = i * 20;
                g.FillEllipse(brush, PosX + 190 - X, PosY - 60 + Y, 30, 10);
                g.FillRectangle(brush, PosX + 190 - X, PosY - 60 + Y, 15, 12);
                g.FillEllipse(brush, PosX + 130 - X, PosY + 80 + Y, 30, 10);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 15, 12);
                brush.Dispose();
            }
        }
    }
}
