using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Random rd = new Random();
            Snake snake = new Snake();
            bool GameOver = false;
            try
            {
                while (!GameOver)
                {
                    List<Coordinates> ground = new List<Coordinates>();
                    for (int h = 1; h < Console.WindowHeight - 1; h++)
                    {
                        for (int w = 1; w < Console.WindowWidth - 1; w++)
                            ground.Add(new Coordinates(w, h));
                    }
                    foreach (var t in snake.Body)
                    {
                        ground.Remove(t);
                    }
                    int a = rd.Next(0, ground.Count);
                    Food f = new Food(ground[a].X, ground[a].Y);
                    snake.show();
                    f.Show();
                    while (f.cord != snake.head && !GameOver)
                    {
                        snake.show();
                        f.Show();
                        snake.Move(Console.ReadKey().Key);
                        for(int i=0;i<snake.Body.Count-1;i++)
                        {
                            if(snake.Body[i]==snake.head)
                            {
                                GameOver = true;
                                break;
                            }
                        }
                        //Thread.Sleep(100);
                    }
                    snake.eat(f);
                }
                throw new Exception();
            }
            catch
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("game over");
            }
            finally
            {
                Console.WriteLine("press any key to close");
                Console.ReadKey();
            }
        }
    }
}