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
        public Direction Richtung { get; set; }

        public SnakeSegment Kopf => _snakeSegmente[0];
        public SnakeSegment SchwanzSegment => _snakeSegmente.Last();

        private readonly Graphics _g;
        private readonly List<SnakeSegment> _snakeSegmente;

        private readonly int _segmentSize = 25, _snakeSpeed = 25;

        public Snake(Graphics g, int x, int y)
        {
            _g = g;

            _snakeSegmente = new List<SnakeSegment>();
            _snakeSegmente.Add(new SnakeSegment(x, y));
        }

        public void ChangeRichtung(Direction richtung)
        {
            Richtung = richtung;
        }

        public void NeuesSegment()
        {
            _snakeSegmente.Add(new SnakeSegment(SchwanzSegment.X + _segmentSize, SchwanzSegment.Y));
        }

        public void Move()
        {
            Kopf.Richtung = Richtung;

            for (int i = _snakeSegmente.Count - 1; i >= 0; i--)
            {
                switch (_snakeSegmente[i].Richtung)
                {
                    case Direction.Up:
                        _snakeSegmente[i].Y -= _snakeSpeed;
                        break;
                    case Direction.Right:
                        _snakeSegmente[i].X += _snakeSpeed;
                        break;
                    case Direction.Down:
                        _snakeSegmente[i].Y += _snakeSpeed;
                        break;
                    case Direction.Left:
                        _snakeSegmente[i].X -= _snakeSpeed;
                        break;
                }

                if (i > 0)
                    _snakeSegmente[i].Richtung = _snakeSegmente[i - 1].Richtung;
            }
        }

        public void Draw()
        {
            _g.Clear(Color.Black);

            foreach (SnakeSegment segment in _snakeSegmente)
            {
                _g.FillRectangle(Brushes.White,
                    new Rectangle(segment.X, segment.Y, _segmentSize, _segmentSize));
            }
        }
    }
}