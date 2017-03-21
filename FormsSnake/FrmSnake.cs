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

        bool spieler1 = true, spieler2 = false;

        public FrmSnake()
        {
            InitializeComponent();
        }

        private void FrmSnake_Load(object sender, EventArgs e)
        {
            Highscores.Load();

            SnakeTimer.Interval = 50;
            DifficultyCb.SelectedIndex = 1;

            tbPlayer.Text = Environment.MachineName;

            _game = new Game(pnlSnake);

            _game.Snakes[0].Enabled = spieler1;
            _game.Snakes[1].Enabled = spieler2;
        }

        private void ButtonSpieler1_Clicked(object sender, EventArgs e)
        {
            spieler1 = !spieler1;
            BtnPlayer1.BackColor = (spieler1) ? Color.Lime : Color.Red; // kurze IF abfrage

            if (spieler1 == false && spieler2 == false)
            {
                spieler2 = !spieler2;
                btnPlayer2.BackColor = (spieler2) ? Color.Lime : Color.Red; // kurze IF abfrage
            }

            _game.Snakes[0].Enabled = spieler1;
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            spieler2 = !spieler2;
            btnPlayer2.BackColor = (spieler2) ? Color.Lime : Color.Red; // kurze IF abfrage
            
            if (spieler1 == false && spieler2 == false)
            {
                spieler1 = !spieler1;
                BtnPlayer1.BackColor = (spieler1) ? Color.Lime : Color.Red; // kurze IF abfrage
            }

            _game.Snakes[1].Enabled = spieler2;
        }

        private void SnakeTimer_Tick(object sender, EventArgs e)
        {
            _game.Move();
            _game.Draw();

            lblScore1.Text = $"Score: {_game.Snakes[0].Score}";
            lblScore1.ForeColor = (_game.Snakes[0].Tod) ? Color.Red : Color.White;

            lblScore2.Text = $"Score: {_game.Snakes[1].Score}";
            lblScore2.ForeColor = (_game.Snakes[1].Tod) ? Color.Red : Color.White;
        }

        private void ButtonTimer_Clicked(object sender, EventArgs e)
        {
            _game.Restart();

            Highscores.Username = tbPlayer.Text;

            switch (DifficultyCb.SelectedIndex)
            {
                case (0): // leicht
                    _game.SegmentSize = 15;
                    break;
                case 1: // solala
                    _game.SegmentSize = 10;
                    break;
                case 2: // schwer
                    _game.SegmentSize = 5;
                    break;
            }

            SnakeTimer.Enabled = !SnakeTimer.Enabled;

            SpeedTb.Enabled = !SnakeTimer.Enabled;
            tbPlayer.Enabled = !SnakeTimer.Enabled;
            BtnPlayer1.Enabled = !SnakeTimer.Enabled;
            btnPlayer2.Enabled = !SnakeTimer.Enabled;
            DifficultyCb.Enabled = !SnakeTimer.Enabled;
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

        private void FrmSnake_FormClosing(object sender, FormClosingEventArgs e)
        {
            Highscores.Save();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            SnakeTimer.Enabled = !SnakeTimer.Enabled;
        }

        private void lblScore1_Click(object sender, EventArgs e)
        {

        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            FormHighscores form = new FormHighscores();
            form.ShowDialog();
        }

        private void SpeedTb_Scroll(object sender, EventArgs e)
        {
            SnakeTimer.Interval = SpeedTb.Value;
        }
    }
}
