using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rock, Paper, Scissors!"); //welcome message
            Console.WriteLine("Choose: 1 - Rock, 2 - Paper, 3 - Scissors, 4 - Quit"); //asks user to select choice

            int userChoice;
            while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }

            if (userChoice == 4)
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }

            string[] choices = { "Rock", "Paper", "Scissors" }; //in the string rock is stored as 1, paper as 2 and scissors as 3
            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            Console.WriteLine($"You chose: {choices[userChoice - 1]}");
            Console.WriteLine($"Computer chose: {choices[computerChoice - 1]}");

            int result = DetermineWinner(userChoice, computerChoice);

            if (result == 0)
                Console.WriteLine("It's a tie!");
            else if (result == 1)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("Computer wins!");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static int DetermineWinner(int user, int computer)
    {
        if (user == computer)
            return 0; // It's a tie
        if ((user == 1 && computer == 3) || (user == 2 && computer == 1) || (user == 3 && computer == 2))
            return 1; // User wins
        return -1; // Computer wins
    }
}
