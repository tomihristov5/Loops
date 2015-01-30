// Problem 7. Calculate N! / (K! * (N-K)!)
// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as 
// the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to 
// withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only 
// two loops.

using System;

class CalculateProb7
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        int factK = 1;
        int factN = 1;
        int subtract = n-k;
        int factNMinusK = 1;
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
        do
        {
            factNMinusK *= subtract;
            subtract--;
        } 
        while (subtract > 0);
        Console.WriteLine("n!/(k!*(n-k)!) = " + factN / (factK * factNMinusK));
    }
}

