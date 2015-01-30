// Problem 3. Min, Max, Sum and Average of N Numbers
// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
// the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
// The output is like in the examples below.

using System;
using System.Linq;

class MinMaxSumAvgOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter the number of integers: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter integer {0}: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int minNumber = arr.Min();
        int maxNumber = arr.Max();
        int sum = arr.Sum();
        double avgNumber = arr.Average();
        Console.WriteLine("\nmin= {0} \nmax= {1} \nsum= {2} \navg= {3}", minNumber, maxNumber, sum, Math.Round(avgNumber, 2));
    }
}

