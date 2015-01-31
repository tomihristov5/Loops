// Problem 10. Odd and Even Product
// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;


class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter n numbers separated by space: ");
        string[] separator = {",", ".", "!", "?", ";", ":", " "};
        string numbers = Convert.ToString(Console.ReadLine());
        string[] words = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int n = words.Length;
        int evenProduct = 1;
        int oddProduct = 1;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                string numb = words[i];
                int num = int.Parse(numb);
                oddProduct *= num;
            }
            else
            {
                string numb = words[i];
                int num = int.Parse(numb);
                evenProduct *= num;
            }
        }
        Console.WriteLine("The even product is: " + evenProduct);
        Console.WriteLine("The odd product is: " + oddProduct);
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("{0} is equal with {1}!",evenProduct , oddProduct);
        }
        else
            Console.WriteLine("{0} is not equal with {1}!", evenProduct, oddProduct);
    }
}

