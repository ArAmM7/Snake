﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food:Coordinates
    {
        public Food(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Coordinates cord
        {
            get => this;
        }
        public void Show()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write('f');
        }
    }
}
