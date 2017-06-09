using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public List<coordinates> Body = new List<coordinates>();
        public Snake(coordinates c)
        {
            Body.Add(c);
        }
        public coordinates head
        {
            get => Body[Body.Count-1];
        }
        public void eat(food f)
        {
            Body.Add(f.cord);
        }
        public void show()
        {
            Console.Clear();
            foreach(var t in Body)
            {
                Console.SetCursorPosition(t.X, t.Y);
                Console.Write('s');
            }
        }
        public void Move(ConsoleKey ck)
        {
            switch(ck)
            {
                case ConsoleKey.LeftArrow:
                    {
                        Body[Body.Count-1].X--;
                        if (Body.Count > 1)
                        {
                            for (int i = Body.Count - 2; i <= 0; i--)
                            {
                                if (Body[i].Y == Body[i + 1].Y)
                                {
                                    Body[i].X--;
                                }
                                else if (Body[i].Y > Body[i + 1].Y)
                                {
                                    Body[i].Y++;
                                }
                                else if (Body[i].Y < Body[i + 1].Y)
                                {
                                    Body[i].Y--;
                                }
                            } 
                        }
                        break;
                    };
                case ConsoleKey.RightArrow:
                    {
                        Body[Body.Count - 1].X++;
                        if (Body.Count>1)
                        {
                            for (int i = Body.Count - 2; i <= 0; i--)
                            {
                                if (Body[i].Y == Body[i + 1].Y)
                                {
                                    Body[i].X++;
                                }
                                else if (Body[i].Y > Body[i + 1].Y)
                                {
                                    Body[i].Y++;
                                }
                                else if (Body[i].Y < Body[i + 1].Y)
                                {
                                    Body[i].Y--;
                                }
                            } 
                        }
                        break;
                    };
                case ConsoleKey.UpArrow:
                    {
                        Body[Body.Count - 1].Y--;
                        if (Body.Count > 1)
                        {
                            for (int i = Body.Count - 2; i <= 0; i--)
                            {
                                if (Body[i].X == Body[i + 1].X)
                                {
                                    Body[i].Y--;
                                }
                                else if (Body[i].X > Body[i + 1].X)
                                {
                                    Body[i].X++;
                                }
                                else if (Body[i].X < Body[i + 1].X)
                                {
                                    Body[i].X--;
                                }
                            } 
                        }
                        break;
                    };
                case ConsoleKey.DownArrow:
                    {
                        Body[Body.Count - 1].Y++;
                        if (Body.Count > 1)
                        {
                            for (int i = Body.Count - 2; i <= 0; i--)
                            {
                                if (Body[i].X == Body[i + 1].X)
                                {
                                    Body[i].Y++;
                                }
                                else if (Body[i].X > Body[i + 1].X)
                                {
                                    Body[i].X++;
                                }
                                else if (Body[i].X < Body[i + 1].X)
                                {
                                    Body[i].X--;
                                }
                            } 
                        }
                        break;
                    };
            }
        }
        
    }
}
