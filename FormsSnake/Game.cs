using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FormsSnake
{
    class Game
    {
        public Snake[] Snakes = new Snake[2];
        public int SegmentSize { get { return Snakes[0].SegmentSize; } set { Snakes[0].SegmentSize = value; Snakes[1].SegmentSize = value; } }

        private Food _food;
        private Graphics _g;
        private int _gameWidth, _gameHeight;

        public Game(Panel panel)
        {
            _g = panel.CreateGraphics();

            _gameWidth = panel.Width;
            _gameHeight = panel.Height;

            //Restart();

            //Snakes[0] = new Snake(_g, Color.White, x, y, _gameHeight, _gameWidth, 10);
            //Snakes[0].Richtung = Direction.Down;
            //Snakes[1] = new Snake(_g, Color.Blue, x, y, _gameHeight, _gameWidth, 10);
            //Snakes[1].Richtung = Direction.Down;
            
            //RandomFood();
        }

        public void Restart()
        {
            int x = 20, y = 20;

            Snakes[0] = new Snake(_g, Color.White, x, y, _gameHeight, _gameWidth, 10);
            Snakes[0].Richtung = Direction.Down;
            Snakes[1] = new Snake(_g, Color.Blue, x * 2, y * 2, _gameHeight, _gameWidth, 10);
            Snakes[1].Richtung = Direction.Down;

            RandomFood();
        }

        private void RandomFood()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            int x = rnd.Next(0, _gameWidth - SegmentSize), y = rnd.Next(0, _gameHeight - SegmentSize);

            _food = new Food(x - (x % SegmentSize), y - (y % SegmentSize));
        }

        public void Move()
        {
            Snakes[0].Move();
            Snakes[1].Move();

            foreach (Snake snake in Snakes)
            {
                if (snake.CheckFood(_food))
                {
                    RandomFood();
                }
            }
        }

        public void Draw()
        {
            _g.Clear(Color.Black);

            _g.FillRectangle(Brushes.LightBlue, _food.X, _food.Y, SegmentSize, SegmentSize);

            Snakes[0].Draw();
            Snakes[1].Draw();
        }
    }
}
