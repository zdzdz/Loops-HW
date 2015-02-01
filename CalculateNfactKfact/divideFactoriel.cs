using System;
using System.Numerics;

class divideFactoriel
{
    static void Main()
    {
        Console.Write("Enter value of n > 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value of k < n < 100: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        if (0 < k && k < n && n < 100)
        {
            for (int i = 1 + k; i <= n; i++)
            {
                factorial *= i; 
            }
            Console.WriteLine(factorial);
        }
        else
        {
            Console.WriteLine("Invalid Number!");
        }
    }
}

