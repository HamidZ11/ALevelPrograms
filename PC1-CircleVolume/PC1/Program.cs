using System.IO;

namespace CircleVolume;

class Program
{
    static void Main(string[] args)
    {
        double radius; //declaring the radius as a variable
        Console.WriteLine("Enter radius: ");
        radius = Convert.ToDouble(Console.ReadLine()); //saves user input as the radius
        double volume = (1.33333333) * (Math.PI) * (radius * radius * radius);
        Console.WriteLine("The volume is " + volume); //output the volume
        Console.ReadKey();
    }
}
