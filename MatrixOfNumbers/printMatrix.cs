//Problem 9. Matrix of Numbers

//    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
//    and prints a matrix like in the examples below. Use two nested loops.


using System;

class printMatrix
{
    static void Main()
    {
        Console.Write("Enter value of 1 <= n <= 20: ");
        int n = int.Parse(Console.ReadLine());

        int counter = 1;
        int counter2 = n;

        if (1 <= n && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = counter; col <= counter2; col++)
                {
                    Console.Write("   " + col);
                    
                }
                Console.WriteLine();
                counter++;
                counter2++;
            }
        }
        else
        {
            Console.WriteLine("Invalid Number!");
        }
    }
}

