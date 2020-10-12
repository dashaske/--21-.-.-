using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAirplane
{
    class Boombs
    {
        private Boombsenum _countBoomb;

        public int CountBoomb
        {
            set
            {
                if (value < 6)
                {
                    _countBoomb = Boombsenum.six;
                }
                if (value == 8)
                {
                    _countBoomb = Boombsenum.eight;
                }
                if (value > 10)
                {
                    _countBoomb = Boombsenum.ten;
                }
                else
                {
                    _countBoomb = (Boombsenum)value;
                }                 
            }
        }
        public void DrawBoombs(Graphics g, float _startPosX, float _startPosY)
        {
            if(_countBoomb == Boombsenum.six)
            {
                Draw6Boombs(g, _startPosX, _startPosY);
            }
            if (_countBoomb == Boombsenum.eight)
            {
                Draw8Boombs(g, _startPosX, _startPosY);
            }
            if (_countBoomb == Boombsenum.ten)
            {
                Draw10Boombs(g, _startPosX, _startPosY);              
            }
        }
        public void Draw6Boombs(Graphics g, float _startPosX, float _startPosY)
        {
            for (int i = 0; i < 3; i++)
            {
                Brush brush = new SolidBrush(Color.Black);
                int X = i * 15;
                int Y = i * 20;
                g.FillRectangle(brush, _startPosX + 155 - X, _startPosY - 30 + Y, 20, 10);
                g.FillRectangle(brush, _startPosX + 155 - X, _startPosY - 30 + Y, 40, 5);
                g.FillRectangle(brush, _startPosX + 130 - X, _startPosY + 80 + Y, 20, 10);
                g.FillRectangle(brush, _startPosX + 130 - X, _startPosY + 80 + Y, 40, 5);
                brush.Dispose();
            }              
        }
        public void Draw8Boombs(Graphics g, float _startPosX, float _startPosY)
        {
            for (int i = 0; i < 4; i++)
            {
                Brush brush = new SolidBrush(Color.Black);
                int X = i * 15;
                int Y = i * 20;
                g.FillRectangle(brush, _startPosX + 170 - X, _startPosY - 50 + Y, 20, 10);
                g.FillRectangle(brush, _startPosX + 170 - X, _startPosY - 50 + Y, 40, 5);
                g.FillRectangle(brush, _startPosX + 130 - X, _startPosY + 80 + Y, 20, 10);
                g.FillRectangle(brush, _startPosX + 130 - X, _startPosY + 80 + Y, 40, 5);
                brush.Dispose();
            }
        }
        public void Draw10Boombs(Graphics g, float _startPosX, float _startPosY)
        {
            for (int i = 0; i < 5; i++)
            {
                Brush brush = new SolidBrush(Color.Black);
                int X = i * 15;
                int Y = i * 20;
                g.FillRectangle(brush, _startPosX + 185 - X, _startPosY - 70 + Y, 20, 10);
                g.FillRectangle(brush, _startPosX + 185 - X, _startPosY - 70 + Y, 40, 5);
                g.FillRectangle(brush, _startPosX + 130 - X, _startPosY + 80 + Y, 20, 10);
                g.FillRectangle(brush, _startPosX + 130 - X, _startPosY + 80 + Y, 40, 5);
                brush.Dispose();
            }
        }
    }
}
