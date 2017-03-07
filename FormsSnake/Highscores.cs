using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsSnake
{
    public static class Highscores
    {
        public static List<Highscore> Scores { get; set; }

        public static void Load()
        {
            Scores = new List<Highscore>();

            for (int i = 0; i < Scores.Count; i++)
            {

            }
        }

        public static void Save()
        {

        }

        public static void Check(int score)
        {

        }
    }
}
