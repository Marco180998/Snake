using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsSnake
{
    public partial class FrmSnake : Form
    {
        Graphics g;
        Food _food;

        Game _game;

        public FrmSnake()
        {
            InitializeComponent();
        }

        private void FrmSnake_Load(object sender, EventArgs e)
        {
            SnakeTimer.Interval = 50;

            _game = new Game(pnlSnake);
        }

        private void ButtonSpieler1_Clicked(object sender, EventArgs e)
        {
            _game.Snakes[0].NeuesSegment();
            _game.Snakes[0].Draw();
        }

        private void SnakeTimer_Tick(object sender, EventArgs e)
        {
            _game.Move();
            _game.Draw();

            lblScore1.Text = $"Score: {_game.Snakes[0].Score}";
            lblScore2.Text = $"Score: {_game.Snakes[1].Score}";
        }

        private void ButtonTimer_Clicked(object sender, EventArgs e)
        {
            SnakeTimer.Enabled = !SnakeTimer.Enabled;
        }

        private void Form_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down && _game.Snakes[0].Richtung != Direction.Up)
            {
                _game.Snakes[0].Richtung = Direction.Down;
            }
            if (e.KeyCode == Keys.Up && _game.Snakes[0].Richtung != Direction.Down)
            {
                _game.Snakes[0].Richtung = Direction.Up;
            }
            if (e.KeyCode == Keys.Left && _game.Snakes[0].Richtung != Direction.Right)
            {
                _game.Snakes[0].Richtung = Direction.Left;
            }
            if (e.KeyCode == Keys.Right && _game.Snakes[0].Richtung != Direction.Left)
            {
                _game.Snakes[0].Richtung = Direction.Right;
            }


            if (e.KeyCode == Keys.S && _game.Snakes[1].Richtung != Direction.Up)
            {
                _game.Snakes[1].Richtung = Direction.Down;
            }
            if (e.KeyCode == Keys.W && _game.Snakes[1].Richtung != Direction.Down)
            {
                _game.Snakes[1].Richtung = Direction.Up;
            }
            if (e.KeyCode == Keys.A && _game.Snakes[1].Richtung != Direction.Right)
            {
                _game.Snakes[1].Richtung = Direction.Left;
            }
            if (e.KeyCode == Keys.D && _game.Snakes[1].Richtung != Direction.Left)
            {
                _game.Snakes[1].Richtung = Direction.Right;
            }
        }
    }
}
