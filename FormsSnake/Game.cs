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
        private Food _food;
        private Graphics _g;
        private int _gameWidth, _gameHeight, _size;

        public Game(Panel panel)
        {
            _g = panel.CreateGraphics();
            int x = 20, y = 20, size = _size = 10;

            _gameWidth = panel.Width;
            _gameHeight = panel.Height;

            Snakes[0] = new Snake(_g, x, y, _gameHeight, _gameWidth, size);
            Snakes[0].Richtung = Direction.Down;
            Snakes[1] = new Snake(_g, x, y, _gameHeight, _gameWidth, size);
            Snakes[1].Richtung = Direction.Down;

            RandomFood();
        }

        private void RandomFood()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            _food = new Food(rnd.Next(0, _gameWidth - _size), rnd.Next(0, _gameHeight - _size));
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

            _g.FillRectangle(Brushes.LightBlue, _food.X, _food.Y, _size, _size);

            Snakes[0].Draw();
            Snakes[1].Draw();
        }
    }
}
