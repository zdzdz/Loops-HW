//Problem 11. Random Numbers in Given Range

//    Write a program that enters 3 integers n, min and max (min != max) 
//    and prints n random numbers in the range [min...max].


using System;

class randomness
{
    static void Main()
    {
        Console.Write("Please insert a number of randomness: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please insert a min value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please insert a max value: ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        if (min != max && min < max)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", rnd.Next(min, max));
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid Numbers!");
        }
    }
}

