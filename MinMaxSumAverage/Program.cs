//Problem 3. Min, Max, Sum and Average of N Numbers

//    Write a program that reads from the console a sequence of n integer numbers and 
//    returns the minimal, the maximal number, the sum and the average of all numbers 
//    (displayed with 2 digits after the decimal point).
//    The input starts by the number n (alone in a line) followed by n lines, 
//    each holding an integer number.
//    The output is like in the examples below.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter how many numbers you want to insert: ");
        int count = int.Parse(Console.ReadLine());

        int sum = 0;
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;

        for (int i = 1; i <= count; i++)
        {
            Console.Write("Please insert a number: ");
            int number = int.Parse(Console.ReadLine());

            sum += number;

            if (number > maxValue)
            {
                maxValue = number;
            }
            if (number < minValue)
            {
                minValue = number;
            }
        }

        double average = (double)sum / (double)count;
        Console.WriteLine("{0}  {1}  {2}  {3:0.00}", minValue, maxValue, sum, average);
    }
}

