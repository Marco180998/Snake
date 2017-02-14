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
            g = panel1.CreateGraphics();

            snake = new Snake(g, 20, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            snake.NeuesSegment();
            snake.Draw();
        }
    }
}
