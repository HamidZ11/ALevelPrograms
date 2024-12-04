using System;
namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's a prime: "); //prompts user to enter their number
            int num = Convert.ToInt32(Console.ReadLine()); //saves users number as an integer
            bool result = IsPrime(num, 2); //
            if (result == true)
                Console.WriteLine(num + " is a prime number.");
            else
                Console.WriteLine(num + " is not a prime number.");
            Console.ReadLine();
        }
        static bool IsPrime(int n, int i)
        {
            if (i > n / 2) return true; if (n % i == 0) return false; return IsPrime(n, i + 1);
        }
    }
}
