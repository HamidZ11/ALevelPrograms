using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maximum number:");
            int max = int.Parse(Console.ReadLine());

            while (true)
            {
                Random rnd = new Random();

                Console.WriteLine("Random numbers:");
                for (int i = 0; i < 6; i++)
                {
                    int randomNumber = rnd.Next(1, max + 1);
                    Console.Write(randomNumber + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Would you like another go? (yes/no)");
                string response = Console.ReadLine();

                if (response.ToLower() == "no")
                {
                    break;
                }
            }
        }
    }
}