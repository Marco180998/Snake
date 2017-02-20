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
        Snake snake;

        public FrmSnake()
        {
            InitializeComponent();
        }

        private void FrmSnake_Load(object sender, EventArgs e)
        {
            SnakeTimer.Interval = 50;

            g = panel1.CreateGraphics();

            snake = new Snake(g, 20, 20, panel1.Height, panel1.Width);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            snake.NeuesSegment();
            snake.Draw();
        }

        private void SnakeTimer_Tick(object sender, EventArgs e)
        {
            //snake.Richtung = Direction.Down;
            snake.Move();
            snake.Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SnakeTimer.Enabled = !SnakeTimer.Enabled;
        }

        private void Form_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                snake.Richtung = Direction.Down;
            }
            if (e.KeyCode == Keys.Up)
            {
                snake.Richtung = Direction.Up;
            }
            if (e.KeyCode == Keys.Left)
            {
                snake.Richtung = Direction.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                snake.Richtung = Direction.Right;
            }
        }
    }
}
