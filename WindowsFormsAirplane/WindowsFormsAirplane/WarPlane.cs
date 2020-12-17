using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirplane
{
    public class WarPlane : Plane
    {
        protected readonly int planeWidth = 180;
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected readonly int planeHeight = 60;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        public WarPlane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        //Конструктор с изменением размеров самолета
        protected WarPlane(int maxSpeed, float weight, Color mainColor, int planeWidth, int planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step1 = MaxSpeed * 40 / Weight;
            int step = Convert.ToInt32(step1);
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (PosX + step < pictureWidth - planeWidth)
                    {
                        PosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (PosX - step > 0)
                    {
                        PosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (PosY - step > 0)
                    {
                        PosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (PosY + step < pictureHeight - planeHeight)
                    {
                        PosY += step;
                    }
                    break;
            }
        }
        public override void DrawFly(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            //границы самолета
            Brush brGray = new SolidBrush(MainColor);
            g.FillEllipse(brGray, PosX + 80, PosY + 40, 90, 20);
            g.DrawEllipse(pen, PosX + 80, PosY + 40, 90, 20);   //нос

            g.DrawRectangle(pen, PosX, PosY + 40, 130, 20);
            g.DrawRectangle(pen, PosX + 75, PosY - 10, 25, 120);   //границы самолета

            Brush brRed = new SolidBrush(MainColor);
            g.FillRectangle(brRed, PosX, PosY + 40, 130, 20);    //закрас тела

            Brush brGreen = new SolidBrush(MainColor);
            g.FillRectangle(brGreen, PosX + 75, PosY - 10, 25, 120);
            g.DrawRectangle(pen, PosX + 5, PosY + 25, 15, 50);           //тело
            g.FillRectangle(brGreen, PosX + 5, PosY + 25, 15, 50);

            Brush brBrown = new SolidBrush(MainColor);
            g.FillEllipse(brBrown, PosX + 95, PosY, 10, 30);
            g.DrawEllipse(pen, PosX + 95, PosY, 10, 30);
            g.FillEllipse(brBrown, PosX + 95, PosY + 70, 10, 30);     //круги около бомб
            g.DrawEllipse(pen, PosX + 95, PosY + 70, 10, 30);

            Brush brBlue = new SolidBrush(MainColor);
            g.FillEllipse(brBlue, PosX + 70, PosY + 42, 30, 15);           //центральный круг
            g.DrawEllipse(pen, PosX + 70, PosY + 42, 30, 15);
        }
    }
}
