using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FormsSnake
{
    public class Snake
    {
        /// <summary>
        /// 0 = nach oben, 1 = nach rechts, 2 = nach unten, 3 = nach links
        /// </summary>
        public int Richtung { get; private set; }

        public int KopfX { get; private set; }
        public int KopfY { get; private set; }

        public int SchwanzX
        {
            get
            {
                if (_snakeSegmente.Count == 0) return KopfX;
                if (_snakeSegmente.Count - 1 < 0) return _snakeSegmente[0].X;
                return _snakeSegmente[_snakeSegmente.Count - 1].X;
            }
        }

        public int SchwanzY
        {
            get
            {
                if (_snakeSegmente.Count == 0) return KopfY;
                if (_snakeSegmente.Count - 1 < 0) return _snakeSegmente[0].Y;
                return _snakeSegmente[_snakeSegmente.Count - 1].Y;
            }
        }

        private Graphics _g;
        private List<SnakeSegment> _snakeSegmente;

        private int _segmentSize = 25;

        public Snake(Graphics g, int _x, int _y)
        {
            _g = g;
            KopfX = _x;
            KopfY = _y;

            _snakeSegmente = new List<SnakeSegment>();
        }

        public void ChangeRichtung(int richtung)
        {
            Richtung = richtung;
        }

        public void NeuesSegment()
        {
            _snakeSegmente.Add(new SnakeSegment(SchwanzX + _segmentSize, SchwanzY));
        }

        public void Draw()
        {
            _snakeSegmente[0].X -= 5;
            _snakeSegmente[0].Y -= 5;

            for (int i = 0; i + 1 < _snakeSegmente.Count; i++)
            {
                _snakeSegmente[i].X = _snakeSegmente[i + 1].X;
                _snakeSegmente[i].Y = _snakeSegmente[i + 1].Y;
            }

            foreach (SnakeSegment segment in _snakeSegmente)
            {
                _g.FillRectangle(Brushes.White,
                    new Rectangle(segment.X, segment.Y, _segmentSize, _segmentSize));
            }

            switch (Richtung)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }

            
        }
    }
}