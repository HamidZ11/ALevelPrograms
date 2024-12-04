using System;
using System.Collections.Generic;
using System.Linq;

class SnakeGame
{
    static void Main(string[] args)
    {
        //  settings
        const int screenWidth = 80;
        const int screenHeight = 25;
        const int startingSnakeLength = 3;
        const char snakeSymbol = 'O';
        const char foodSymbol = 'X';
        const int scoreIncreasePerFood = 10;
        const int fps = 10;

        // initalize game 
        var random = new Random();
        var snake = new List<(int x, int y)>();
        for (int i = 0; i < startingSnakeLength; i++)
        {
            snake.Add((screenWidth / 2 - i, screenHeight / 2));
        }
        var direction = "right";
        var score = 0;
        var foodX = random.Next(0, screenWidth);
        var foodY = random.Next(0, screenHeight);

        // loop
        while (true)
        {
            // Clear screen
            Console.Clear();

            // move snake
            var head = snake.Last();
            switch (direction)
            {
                case "up":
                    head = (head.x, head.y - 1);
                    break;
                case "down":
                    head = (head.x, head.y + 1);
                    break;
                case "left":
                    head = (head.x - 1, head.y);
                    break;
                case "right":
                    head = (head.x + 1, head.y);
                    break;
            }
            snake.Add(head);

            // Check for collision
            if (head.x < 0 || head.x >= screenWidth || head.y < 0 || head.y >= screenHeight || snake.Take(snake.Count - 1).Contains(head))
            {
                Console.WriteLine("Game over!");
                Console.WriteLine($"Score: {score}");
                Console.ReadKey();
                return;
            }

            // Check for food
            if (head.x == foodX && head.y == foodY)
            {
                score += scoreIncreasePerFood;
                foodX = random.Next(0, screenWidth);
                foodY = random.Next(0, screenHeight);
            }
            else
            {
                snake.RemoveAt(0);
            }

            // draw game pictures
            Console.SetCursorPosition(foodX, foodY);
            Console.Write(foodSymbol);
            foreach (var part in snake)
            {
                Console.SetCursorPosition(part.x, part.y);
                Console.Write(snakeSymbol);
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Score: {score}");

            // Wait for next frame
            System.Threading.Thread.Sleep(1000 / fps);

            // Check for input
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow && direction != "down")
                {
                    direction = "up";
                }
                else if (key == ConsoleKey.DownArrow && direction != "up")
                {
                    direction = "down";
                }
                else if (key == ConsoleKey.LeftArrow && direction != "right")
                {
                    direction = "left";
                }
                else if (key == ConsoleKey.RightArrow && direction != "left")
                {
                    direction = "right";
                }
            }
        }
    }
}