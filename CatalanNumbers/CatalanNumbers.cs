// Problem 8. Catalan Numbers
// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula.
// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        long factN = 1L;
        int nPlus1 = n + 1;
        long factNPlus1 = 1L;
        int nByN = 2 * n;
        long fact2N = 1L;
        do
        {
            if (n == 0)
            {
                factN *= n;
                n--;
            }
            else
            {
                factNPlus1 *= nPlus1;
                nPlus1--;
                factN *= n;
                n--;
            }
        }
        while (n > 0);
        Console.WriteLine("n! = " + factN);
        Console.WriteLine("(n+1)! = " + factNPlus1);
        do
        {
            fact2N *= nByN;
            nByN--;
        }
        while (nByN > 0);
        Console.WriteLine("2n! = " + fact2N);
        Console.WriteLine("2n!/(n+1)!n! = " + (long)(fact2N / (factNPlus1 * factN)));
    }
}

