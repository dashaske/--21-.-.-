using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirplane
{
    class Bomber : WarPlane
    {
        private IDopElements boomb;

        /// Признак наличия звезды
        public bool Star { private set; get; }

        /// Признак наличия бомб
        public bool Bomb { private set; get; }

        /// Признак наличия ракет
        public bool Rocket { private set; get; }

        public int Bombs { private set; get; }

        public string BombsForm { private set; get; }

        public Color DopColor { protected set; get; }
        public void SetDopColor(Color color)
        {
            DopColor = color;
            SetBomb();
        }
        public void SetBombs(IDopElements bombs)
        {
            boomb = bombs;
            BombsForm = boomb.GetType().Name;
        }
        public void SetBombsNumber(int bombNumber)
        {
            Bombs = bombNumber;
        }
        public Bomber(int maxSpeed, float weight, Color mainColor, Color dopColor, 
        bool rocket, bool bomb, bool star, int bombs, string bombsForm)
            : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Star = star;
            Bomb = bomb;
            Rocket = rocket;
            Bombs = bombs;
            BombsForm = bombsForm;
            SetBomb();
        }
        public Bomber(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 9)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Star = Convert.ToBoolean(strs[4]);
                Bomb = Convert.ToBoolean(strs[5]);
                Rocket = Convert.ToBoolean(strs[6]);
                Bombs = Convert.ToInt32(strs[7]);
                BombsForm = strs[8];
                SetBomb();
            }
        }
        public void SetBomb()
        {
            if (BombsForm == "BoombsStandart")
            {
                boomb = new BoombsStandart(Bombs, DopColor);
            }
            else if (BombsForm == "PointedBoombs")
            {
                boomb = new BoombsCircular(Bombs, DopColor);
            }
            else if (BombsForm == "BoombsCircular")
            {
                boomb = new PointedBoombs(Bombs, DopColor);
            }
        }
        public override void DrawFly(Graphics g)
        {
            if (boomb != null)
            {
                boomb.DrawElements(g, PosX, PosY);
            }            
            Pen pen = new Pen(Color.Black);
            //рисуем звезду

            if (Rocket)
            {
                g.DrawRectangle(pen, PosX + 80, PosY + 10, 40, 10);
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, PosX + 80, PosY + 10, 40, 10);
                g.DrawRectangle(pen, PosX + 80, PosY + 80, 40, 10);
                g.FillRectangle(spoiler, PosX + 80, PosY + 80, 40, 10);
            }
            //рисуем бомбы
            if (Bomb)
            {
                g.DrawEllipse(pen, PosX + 90, PosY, 30, 10);
                Brush spoiler = new SolidBrush(DopColor);
                g.FillEllipse(spoiler, PosX + 90, PosY, 30, 10);
                g.DrawEllipse(pen, PosX + 90, PosY + 90, 30, 10);
                g.FillEllipse(spoiler, PosX + 90, PosY + 90, 30, 10);
            }
            //отрисовка тела
            base.DrawFly(g);
            if (Star)
            {
                Point point1 = new Point((int)PosX + 85, (int)PosY + 60);
                Point point2 = new Point((int)PosX + 90, (int)PosY + 65);
                Point point3 = new Point((int)PosX + 95, (int)PosY + 60);
                Point point4 = new Point((int)PosX + 95, (int)PosY + 90);
                Point point5 = new Point((int)PosX + 90, (int)PosY + 85);
                Point point6 = new Point((int)PosX + 85, (int)PosY + 90);
                Point[] board = { point1, point2, point3, point4, point5, point6 };
                g.DrawPolygon(pen, board);
                Point point7 = new Point((int)PosX + 85, (int)PosY + 10);
                Point point8 = new Point((int)PosX + 90, (int)PosY + 15);
                Point point9 = new Point((int)PosX + 95, (int)PosY + 10);
                Point point10 = new Point((int)PosX + 95, (int)PosY + 40);
                Point point11 = new Point((int)PosX + 90, (int)PosY + 35);
                Point point12 = new Point((int)PosX + 85, (int)PosY + 40);
                Point[] board1 = { point7, point8, point9, point10, point11, point12 };
                g.DrawPolygon(pen, board1);
            }           
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}" +
                   $"{separator}{Star}{separator}{Bomb}" +
                   $"{separator}{Rocket}{separator}{Bombs}" +
                   $"{separator}{BombsForm}";
        }
    }
}