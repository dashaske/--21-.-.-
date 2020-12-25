using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAirplane
{
    class BoombsStandart : IDopElements
    {
        private BoombsEnum _countBoomb;
        public int Number { set => _countBoomb = (BoombsEnum)value; }
        public Color DopColor { private set; get; }

        public BoombsStandart(int bombs, Color dopColor)
        {
            Number = bombs;
            DopColor = dopColor;
        }

        Pen pen = new Pen(Color.Black);
        public void Draw6Boombs(Graphics g, int PosX, int PosY)
        {
            for (int i = 0; i < 3; i++)
            {
                Brush brush = new SolidBrush(DopColor);
                int X = i * 15;
                int Y = i * 20;
                g.FillRectangle(brush, PosX + 155 - X, PosY - 30 + Y, 20, 10);
                g.FillRectangle(brush, PosX + 155 - X, PosY - 30 + Y, 40, 5);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 20, 10);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 40, 5);
                brush.Dispose();
            }
        }
        public void Draw8Boombs(Graphics g, int PosX, int PosY)
        {
            for (int i = 0; i < 4; i++)
            {
                Brush brush = new SolidBrush(DopColor);
                int X = i * 15;
                int Y = i * 20;
                g.FillRectangle(brush, PosX + 170 - X, PosY - 50 + Y, 20, 10);
                g.FillRectangle(brush, PosX + 170 - X, PosY - 50 + Y, 40, 5);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 20, 10);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 40, 5);
                brush.Dispose();
            }
        }
        public void Draw10Boombs(Graphics g, int PosX, int PosY)
        {

            for (int i = 0; i < 5; i++)
            {
                Brush brush = new SolidBrush(DopColor);
                int X = i * 15;
                int Y = i * 20;
                g.FillRectangle(brush, PosX + 185 - X, PosY - 70 + Y, 20, 10);
                g.FillRectangle(brush, PosX + 185 - X, PosY - 70 + Y, 40, 5);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 20, 10);
                g.FillRectangle(brush, PosX + 130 - X, PosY + 80 + Y, 40, 5);
                brush.Dispose();
            }
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
    }
}