// Problem 16. Decimal to Hexadecimal Number
// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
using System.Text;

class DecimalToHex
{
    static string DecToHex(long dec)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        var sbulder = new StringBuilder();
        while (dec > 0)
        {
            var rm = dec % 16;
            dec /= 16;
            sbulder.Insert(0, ((int)rm).ToString("X"));
        }
        return sbulder.ToString();
    }
    static void Main()
    {
        Console.Write("Enter an integer in decimal format: ");
        long input = long.Parse(Console.ReadLine());
        string output;
        output = DecToHex(input);
        Console.Write("The number in hexadecimal format is: " + output);
        Console.WriteLine();
    }
}

