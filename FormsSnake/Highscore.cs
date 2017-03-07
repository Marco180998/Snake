using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsSnake
{
    public class Highscore
    {
        public int Score { get; private set; }
        public string Name { get; private set; }

        public Highscore(int score, string name)
        {
            Score = score;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Score}. {Name}";
        }
    }
}
