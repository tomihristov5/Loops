// Problem 14. Decimal to Binary Number
// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        long input = long.Parse(Console.ReadLine());
        string output = "";
        do
        {
            output = input % 2 + output;
            input = input / 2;
        } 
        while (input > 0);
        Console.Write("The binary number is: " + output);
        Console.WriteLine();
    }
}

