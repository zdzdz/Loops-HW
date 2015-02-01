﻿//Problem 7. Calculate N! / (K! * (N-K)!)

//    In combinatorics, the number of ways to choose k different members out of a group of 
//    n different elements (also known as the number of combinations) 
//    is calculated by the following formula:  
//    For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n 
//    and k (1 < k < n < 100). Try to use only two loops.


using System;
using System.Numerics;

class combinations
{
    static void Main()
    {
        Console.Write("Enter value of n > 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value of k < n < 100: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        int difference = n - k;
        BigInteger diffFactorel = 1;

        if (0 < k && k < n && n < 100)
        {
            for (int i = 1 + k; i <= n; i++)
            {
                factorial *= i;
            }

            for (int i = 1; i <= difference; i++)
            {
                diffFactorel *= i;
            }
            Console.WriteLine(factorial / diffFactorel);
        }
        else
        {
            Console.WriteLine("Invalid Number!");
        }
    }
}

