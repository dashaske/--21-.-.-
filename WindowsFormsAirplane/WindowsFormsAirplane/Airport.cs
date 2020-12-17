using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAirplane
{
    public class Airport<T, U> where T : class, ITransport
                               where U : class, IDopElements
    {
        //массив объектов
        private readonly List<T> _places;

        private int PictureWidth { get; set; }

        private int PictureHeight { get; set; }

        private readonly int _maxCount;

        //высота парковочного места
        private const int _placeSizeWidth = 210;

        //ширина парковочного места
        private const int _placeSizeHeight = 133;

        public Airport(int picWidth, int picHeight) 
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new List<T>();
            _maxCount = width * height;
            PictureWidth = picWidth;
            PictureHeight = picHeight;
        }
        public static bool operator +(Airport<T, U> p, T bomber)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(bomber);
            return true;
        }
        public static T operator -(Airport<T, U> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }

            else if (p._places.Count > index)
            {
                T aircraft = p._places[index];
                p._places.RemoveAt(index);
                return aircraft;
            }
            return null;
        }        
        //метод отрисовки парковки
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                {
                    _places[i].SetPosition(3 + i / 3 * _placeSizeWidth + 3, 
                    i % 3 * _placeSizeHeight + 15, PictureWidth,
                    PictureHeight);
                    _places[i]?.DrawFly(g);

                }
            }
        }
        //метод отрисовки разметки
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_places.Count / 15) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 3; i++)
            {
                for (int j = 0; j < 4; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 120, j * _placeSizeHeight);

                    g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
                }
            }
        }
        public T this[int ind]
        {
            get
            {
                if (ind > -1 && ind < _maxCount)
                {
                    return _places[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
