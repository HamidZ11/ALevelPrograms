using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the start year:");
        int startYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end year:");
        int endYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Leap years between " + startYear + " and " + endYear + " are:");

        for (int year = startYear; year <= endYear; year++)
        {
            if (IsLeapYear(year))
            {
                Console.WriteLine(year);
            }
        }
    }

    static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
    }
}
