﻿// Problem 13. Binary to Decimal Number
// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter a binary integer number: ");
        string input = Console.ReadLine();
        long output = 0L;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[input.Length - i - 1] != '0')
            {
                output += (long)Math.Pow(2, i);
            }
        }
        Console.Write("The decimal number is: " + output);
        Console.WriteLine();
    }
}

