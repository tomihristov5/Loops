// Problem 12.* Randomize the Numbers 1…N
// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Linq;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int counter = 0;
        Random rnd = new Random();
        for (int i = 1; i <= n; i++)
        {
            arr[counter] = i;
            counter++;
        }
        for (int i = 0; i < counter; i++)
        {
            int firstRndNumber = rnd.Next(0, counter);
            int secondRndNumber = rnd.Next(0, counter);
            int tempArr = arr[firstRndNumber];
            arr[firstRndNumber] = arr[secondRndNumber];
            arr[secondRndNumber] = tempArr;
        }
        for (int i = 0; i < counter; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
