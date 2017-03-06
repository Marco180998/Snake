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
        public int SegmentSize { get; set; }

        public SnakeSegment Kopf => _snakeSegmente[0]; // => get
        public SnakeSegment SchwanzSegment => _snakeSegmente.Last();

        private readonly Graphics _g;
        private readonly List<SnakeSegment> _snakeSegmente;
        private readonly SolidBrush _snakeFarbe;

        private readonly int _gameHeight, _gameWidth;

        public Snake(Graphics g, Color color, int x, int y, int gameHeight, int gameWidth, int snakeSize)
        {
            _g = g;
            _gameHeight = gameHeight;
            _gameWidth = gameWidth;

            SegmentSize = snakeSize;

            _snakeSegmente = new List<SnakeSegment>();
            _snakeSegmente.Add(new SnakeSegment(x, y, Richtung));

            _snakeFarbe = new SolidBrush(color);
        }

        public void NeuesSegment()
        {
            switch (SchwanzSegment.Richtung)
            {
                case (Direction.Down):
                    _snakeSegmente.Add(new SnakeSegment(SchwanzSegment.X, SchwanzSegment.Y - SegmentSize, SchwanzSegment.Richtung));
                    break;
                case (Direction.Up):
                    _snakeSegmente.Add(new SnakeSegment(SchwanzSegment.X, SchwanzSegment.Y + SegmentSize, SchwanzSegment.Richtung));
                    break;
                case (Direction.Left):
                    _snakeSegmente.Add(new SnakeSegment(SchwanzSegment.X + SegmentSize, SchwanzSegment.Y, SchwanzSegment.Richtung));
                    break;
                case (Direction.Right):
                    _snakeSegmente.Add(new SnakeSegment(SchwanzSegment.X - SegmentSize, SchwanzSegment.Y, SchwanzSegment.Richtung));
                    break;
            }        
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
                        _snakeSegmente[i].Y -= SegmentSize;
                        break;
                    case Direction.Right:
                        _snakeSegmente[i].X += SegmentSize;
                        break;
                    case Direction.Down:
                        _snakeSegmente[i].Y += SegmentSize;
                        break;
                    case Direction.Left:
                        _snakeSegmente[i].X -= SegmentSize;
                        break;
                }

                if (_snakeSegmente[i].Y >= _gameHeight || _snakeSegmente[i].Y <= 0)
                    Tod = true;

                if (_snakeSegmente[i].X >= _gameWidth || _snakeSegmente[i].X <= 0)
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
                    _g.FillRectangle(Brushes.Red, new Rectangle(segment.X, segment.Y, SegmentSize, SegmentSize));
                else
                    _g.FillRectangle(_snakeFarbe, new Rectangle(segment.X, segment.Y, SegmentSize, SegmentSize));
            }
        }

        public bool CheckFood(Food food)
        {
            if ((Kopf.X >= food.X && Kopf.X <= food.X + SegmentSize) && 
                (Kopf.Y >= food.Y && Kopf.Y <= food.Y + SegmentSize))
            {
                food.Eaten = true;
                NeuesSegment();
                Score++;
            }

            return food.Eaten;
        }
    }
}