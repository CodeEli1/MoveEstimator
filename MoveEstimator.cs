using System;

class Program
{
    const double baserate = 200;
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of hours:");
        string inputHours = Console.ReadLine();
        double hours = Convert.ToDouble(inputHours);
        hours = hours * 150;

        Console.WriteLine("Enter number of miles:");
        string inputMiles = Console.ReadLine();
        double miles = Convert.ToDouble(inputMiles);
        miles = miles * 2;

        double outcome = hours + miles + baserate;

        Console.WriteLine($"The total moving fee is: ${outcome}");
    }
}