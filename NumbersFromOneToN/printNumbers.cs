//Problem 1. Numbers from 1 to N

//    Write a program that enters from the console a positive integer n and 
//    prints all the numbers from 1 to n, on a single line, separated by a space.


using System;

class printNumbers
{
    static void Main()
    {
        Console.Write("Please insert a number: ");
        int number = int.Parse(Console.ReadLine());

        int counter = 1;

        while (counter <= number)
        {
            Console.Write(counter + " ");
            counter++;
        }
        Console.WriteLine();

        //* Second Variant *
        //for (int i = 1; i <= number; i++)
        //{
        //    Console.Write(i + " ");
        //}

        //Console.WriteLine();
    }
}

