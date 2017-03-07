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
    public partial class FormHighscores : Form
    {
        public FormHighscores()
        {
            InitializeComponent();
        }

        private void FormHighscores_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Highscores.Scores.Count; i++)
            {
                lbHighscores.Items.Add($"{Highscores.Scores[i].Score} {Highscores.Scores[i].Name}");
            }
        }
    }
}
