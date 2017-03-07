using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FormsSnake
{
    public static class Highscores
    {
        public static List<Highscore> Scores { get; set; }

        public static void Load()
        {
            Scores = new List<Highscore>();

            try
            {
                foreach (string line in File.ReadAllLines("highscores.txt"))
                {
                    string[] split = line.Split(';');

                    Scores.Add(new Highscore(Convert.ToInt32(split[0]), split[1]));
                }
            }
            catch (Exception)
            {
            }
        }

        public static void Save()
        {
            try
            {
                using (StreamWriter peter = new StreamWriter("highscores.txt"))
                {
                    foreach (Highscore hs in Scores)
                    {
                        peter.WriteLine($"{hs.Score};{hs.Name}");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static void Check(int score)
        {

        }
    }
}
