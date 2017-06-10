using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public List<Coordinates> Body = new List<Coordinates>();
        public Snake()
        {
            Body.Add(new Coordinates(1, 1));
            Body.Add(new Coordinates(1, 2));
            Body.Add(new Coordinates(1, 3));
            Body.Add(new Coordinates(1, 4));
            Body.Add(new Coordinates(2, 4));
            Body.Add(new Coordinates(3, 4));
        }
        public Coordinates head
        {
            get => Body[Body.Count-1];
        }
        public void eat(Food f)
        {
            Body.Add(f.cord);
        }
        public void show()
        {
            Console.Clear();
            for(int i=0;i<Body.Count;i++)
            {
                Console.SetCursorPosition(Body[i].X, Body[i].Y);
                Console.Write('s');
            }
        }

        public void Move(ConsoleKey ck)
        {
            switch(ck)
            {
                case ConsoleKey.LeftArrow:
                    {
                        Body.Remove(Body[0]);
                        Coordinates temp = new Coordinates(Body[Body.Count - 1].X - 1, Body[Body.Count - 1].Y);
                        Body.Add(temp);
                        return;
                    }

                case ConsoleKey.RightArrow:
                    {
                        Body.Remove(Body[0]);
                        Coordinates temp = new Coordinates(Body[Body.Count - 1].X + 1, Body[Body.Count - 1].Y);
                        Body.Add(temp);
                        return;
                    }

                case ConsoleKey.UpArrow:
                    {
                        Body.Remove(Body[0]);
                        Coordinates temp = new Coordinates(Body[Body.Count - 1].X, Body[Body.Count - 1].Y - 1);
                        Body.Add(temp);
                        return;
                    }

                case ConsoleKey.DownArrow:
                    {
                        Body.Remove(Body[0]);
                        Coordinates temp = new Coordinates(Body[Body.Count - 1].X, Body[Body.Count - 1].Y + 1);
                        Body.Add(temp);
                        return;
                    }
            }
        }
        
    }
}
