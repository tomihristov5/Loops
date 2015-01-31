// Problem 11. Random Numbers in Given Range
// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersFromGivenRange
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Random rnd = new Random();
        Console.Write("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter integer min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter integer max: ");
        int max = int.Parse(Console.ReadLine());
        Console.Write("Random numbers:");
        for (int i = 0; i < n; i++)
        {
            int range = rnd.Next(min, max);
            Console.Write(" " + range);
        }
        Console.WriteLine();
    }
}

