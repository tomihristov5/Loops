// Problem 12.* Randomize the Numbers 1…N
// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Linq;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        foreach (int i in arr)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}
