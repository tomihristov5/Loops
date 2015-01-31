// Problem 17.* Calculate GCD
// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        int b = int.Parse(Console.ReadLine());
        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        Console.WriteLine("GCD of a and b is: " + Math.Max(a, b));
    }
}

