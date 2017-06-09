using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class coordinates
    {
        public int X { set; get; }
        public int Y { set; get; }
        public coordinates(int x=0,int y=0)
        {
            X = x;
            Y = y;
        }
        public static bool operator==(coordinates a, coordinates b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator!=(coordinates a, coordinates b)
        {
            return !(a == b);
        }
    }
}
