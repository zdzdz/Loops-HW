//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;

class randomNumbers
{
    static void Main()
    {
        Console.Write("Please insert a number n: ");
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        int tempNumber;

        Random rnd = new Random();
        ;
        for (int i = 1; i <= n; i++)
        {
            do
            {
                tempNumber = rnd.Next(1, n + 1);
            } while (list.Contains(tempNumber));
            list.Add(tempNumber);
        }

        foreach (int i in list)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}

