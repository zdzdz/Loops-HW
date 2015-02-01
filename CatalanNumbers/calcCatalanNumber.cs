//Problem 8. Catalan Numbers

//    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).



using System;
using System.Numerics;

class calcCatalanNumber
{
    static void Main()
    {
        Console.Write("Enter value of 0 <= n <= 100: ");
        int n = int.Parse(Console.ReadLine());

        int doubleN = n * 2;
        int plusN = n + 1;
        BigInteger nFactorial = 1;
        BigInteger doubleFactorial = 1;
        BigInteger plusFactorial = 1;

        if (0 <= n && n <= 100)
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            for (int i = 1; i <= plusN; i++)
            {
                plusFactorial *= i;
            }

            for (int i = 1; i <= doubleN; i++)
            {
                doubleFactorial *= i;
            }

            BigInteger catalan = doubleFactorial / (nFactorial * plusFactorial);
            Console.WriteLine(catalan);
        }
        else
        {
            Console.WriteLine("Invalid Number!");
        }
    }
}

