using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Coordinates
    {
        public int X { set; get; }
        public int Y { set; get; }
        public Coordinates(int x=0,int y=0)
        {
            X = x;
            Y = y;
        }
        public static bool operator==(Coordinates a, Coordinates b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator!=(Coordinates a, Coordinates b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            if (obj is Coordinates)
            {
                return (obj as Coordinates).X==X && (obj as Coordinates).Y==Y;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (X+Y+21).GetHashCode();
        }
    }
}
