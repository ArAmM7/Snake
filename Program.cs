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
            Random rd = new Random();
            Snake snake = new Snake(new coordinates(2,2));
            bool GameOver = false;
            try
            {
                while (!GameOver)
                {
                    List<coordinates> ground = new List<coordinates>();
                    for (int h = 1; h < Console.WindowHeight-1; h++)
                    {
                        for (int w = 1; w < Console.WindowWidth-1; w++)
                            ground.Add(new coordinates(w, h));
                    }
                    foreach (var t in snake.Body)
                    {
                        ground.Remove(t);
                    }
                    int a = rd.Next(0, ground.Count);
                    food f = new food(ground[a].X, ground[a].Y);
                    snake.show();
                    f.Show();
                    while (f.cord != snake.head && !GameOver)
                    {
                        snake.show();
                        f.Show();
                        snake.Move(Console.ReadKey().Key);
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
                Console.ReadLine();
            }
        }
    }
}