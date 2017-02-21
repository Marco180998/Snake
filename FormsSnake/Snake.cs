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

        public bool Tod { get; private set; }
        public int Score { get; private set; }

        public SnakeSegment Kopf => _snakeSegmente[0];
        public SnakeSegment SchwanzSegment => _snakeSegmente.Last();

        private readonly Graphics _g;
        private readonly List<SnakeSegment> _snakeSegmente;

        private readonly int _segmentSize = 25, _snakeSpeed, _gameHeight, _gameWidth;

        public Snake(Graphics g, int x, int y, int gameHeight, int gameWidth, int snakeSize)
        {
            _g = g;
            _gameHeight = gameHeight;
            _gameWidth = gameWidth;
            _segmentSize = _snakeSpeed = snakeSize;

            _snakeSegmente = new List<SnakeSegment>();
            _snakeSegmente.Add(new SnakeSegment(x, y, Richtung));
        }

        public void NeuesSegment()
        {
            _snakeSegmente.Add(new SnakeSegment(SchwanzSegment.X + _segmentSize, SchwanzSegment.Y, SchwanzSegment.Richtung));
        }

        public void Move()
        {
            if (Tod) return;

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

                if (_snakeSegmente[i].Y > _gameHeight || _snakeSegmente[i].Y < 0)
                    Tod = true;

                if (_snakeSegmente[i].X > _gameWidth || _snakeSegmente[i].X < 0)
                    Tod = true;

                if (i > 0)
                    _snakeSegmente[i].Richtung = _snakeSegmente[i - 1].Richtung;

                foreach (SnakeSegment seg in _snakeSegmente)
                {
                    if (Tod) return;

                    if (seg.X == _snakeSegmente[i].X && seg.Y == _snakeSegmente[i].Y)
                        Tod = seg.Richtung != _snakeSegmente[i].Richtung;
                }
            }     
            
            Kopf.Richtung = Richtung;
        }

        public void Draw()
        {
            foreach (SnakeSegment segment in _snakeSegmente)
            {
                if (Tod)
                    _g.FillRectangle(Brushes.Red, new Rectangle(segment.X, segment.Y, _segmentSize, _segmentSize));
                else
                    _g.FillRectangle(Brushes.White, new Rectangle(segment.X, segment.Y, _segmentSize, _segmentSize));
            }
        }

        public bool CheckFood(Food food)
        {
            if ((Kopf.X >= food.X && Kopf.X <= food.X + _segmentSize) && 
                (Kopf.Y >= food.Y && Kopf.Y <= food.Y + _segmentSize))
            {
                food.Eaten = true;
                NeuesSegment();
                Score++;
            }

            return food.Eaten;
        }
    }
}