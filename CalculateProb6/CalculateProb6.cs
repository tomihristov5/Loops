// Problem 6. Calculate N! / K!
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

using System;

class CalculateProb6
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        int factK = 1;
        int factN = 1;
        do
        {
            if (k == 0)
            {
                factN *= n;
                n--;
            }
            else
            {
                factN *= n;
                n--;
                factK *= k;
                k--;
            }
        }
        while (n > 0 || k > 0);
        Console.WriteLine("n! = " + factN);
        Console.WriteLine("k! = " + factK);
        Console.WriteLine("n!/k! = " + factN / factK);
    }
}

