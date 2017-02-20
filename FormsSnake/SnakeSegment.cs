using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsSnake
{
    public class SnakeSegment
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Direction Richtung { get; set; }

        public SnakeSegment(int x, int y)
        {
            X = x;
            Y = y;
        }

        public SnakeSegment(int x, int y, Direction richtung)
        {
            X = x;
            Y = y;
            Richtung = richtung;
        }
    }
}
