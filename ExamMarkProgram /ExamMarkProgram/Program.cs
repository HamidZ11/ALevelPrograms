using System;

class Program
{
    static void Main()
    {
        int examMark;
        {
            Console.Write("Enter your exam mark: ");
            if (int.TryParse(Console.ReadLine(), out examMark))
            {
                if (examMark < 0 || examMark > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a mark between 0 and 100.");
                }
                else if (examMark >= 60)
                {
                    Console.WriteLine("Congratulations! You passed the exam.");
                }
                else
                {
                    Console.WriteLine("Sorry, you failed the exam.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric mark.");
            }
        } while (examMark < 0 || examMark > 100);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
