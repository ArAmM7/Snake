using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class food:coordinates
    {
        public food(int x, int y)
        {
            X = x;
            Y = y;
        }
        public coordinates cord
        {
            get => new coordinates(X, Y);
        }
        public void Show()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write('f');
        }
    }
}
