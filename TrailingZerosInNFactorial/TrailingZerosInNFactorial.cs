// Problem 18.* Trailing Zeroes in N!
// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.

using System;

class TrailingZerosInNFactorial
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        long factorial = 1;
        do
        {
            factorial *= n;
            n--;
            Convert.ToString(factorial);
        } while (n>0);
        Console.WriteLine(factorial);
    }
}

