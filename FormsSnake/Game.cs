using System;
using System.Windows.Forms;
using System.Drawing;

namespace FormsSnake
{
    class Game
    {
        public Snake[] Snakes = new Snake[2];
        public int SegmentSize
        {
            get
            {
                return Snakes[0].SegmentSize;
            }
            set
            {
                Snakes[0].SegmentSize = value;
                Snakes[1].SegmentSize = value;
            }
        }

        private Food _food;
        private Graphics _g;
        private int _gameWidth, _gameHeight;
        
        public Game(Panel panel)
        {
            _g = panel.CreateGraphics();

            _gameWidth = panel.Width;
            _gameHeight = panel.Height;
            
            Snakes[0] = new Snake(_g, Color.White, 0, 0, _gameHeight, _gameWidth, 10);
            Snakes[1] = new Snake(_g, Color.Blue, 0, 0, _gameHeight, _gameWidth, 10);
        }

        /// <summary>
        /// Startet das Spiel neu, setzt die Snakes zurück und erzeugt ein neues Essen
        /// </summary>
        public void Restart()
        {
            int x = 20, y = 20;

            if (Snakes[0].Enabled)
            {
                Snakes[0] = new Snake(_g, Color.White, x, y, _gameHeight, _gameWidth, 10, Snakes[0].Enabled);
                Snakes[0].Richtung = Direction.Down;
            }

            if (Snakes[1].Enabled)
            {
                Snakes[1] = new Snake(_g, Color.Blue, x * 2, y * 2, _gameHeight, _gameWidth, 10, Snakes[1].Enabled);
                Snakes[1].Richtung = Direction.Down;
            }

            RandomFood();
        }

        /// <summary>
        /// Erstellt Essen zufällig irgendwo auf dem Feld
        /// </summary>
        private void RandomFood()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            int x = rnd.Next(0, _gameWidth - SegmentSize), y = rnd.Next(0, _gameHeight - SegmentSize);

            _food = new Food(x - (x % SegmentSize), y - (y % SegmentSize));
        }

        public void Move()
        {
            if (Snakes[0].Enabled) Snakes[0].Move();
            if (Snakes[1].Enabled) Snakes[1].Move();

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

            if (Snakes[0].Enabled) Snakes[0].Draw();
            if (Snakes[1].Enabled) Snakes[1].Draw();
        }
    }
}
