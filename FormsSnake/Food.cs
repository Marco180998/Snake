using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsSnake
{
    public class Food
    {
        public bool Eaten { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Food(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
