using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a decimal number:");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());

        string binary = DecimalToBinary(decimalNumber);
        Console.WriteLine("Binary representation: " + binary);

        Console.ReadLine();
    }

    static string DecimalToBinary(int decimalNumber)
    {
        string binary = string.Empty;

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binary = remainder.ToString() + binary;
            decimalNumber = decimalNumber / 2;
        }

        return binary;
    }
}
