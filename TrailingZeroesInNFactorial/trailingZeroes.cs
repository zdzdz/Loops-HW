//Problem 18.* Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

class trailingZeroes
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        BigInteger number = int.Parse(Console.ReadLine());
        BigInteger zeros = 0;
        int powFive = 1;
        int denominator = 0;
        BigInteger factorial = 1;

        while (denominator <= number)
        {
            denominator = (int)Math.Pow(5, powFive);
            zeros += number / denominator;
            ++powFive;
        }

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("{0}! has {1} trailing zeros. Reason: {2}", number, zeros, factorial);
    }
}

