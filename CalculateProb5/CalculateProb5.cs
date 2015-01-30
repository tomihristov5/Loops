﻿// Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class CalculateProb5
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int factorial = 1;
        double exp = 1;
        do
        {
            factorial *= n;
            sum = sum + (factorial / Math.Pow(x, n));
            n--;
        }
        while (n > 0);
        Console.WriteLine(sum);
    }
}

