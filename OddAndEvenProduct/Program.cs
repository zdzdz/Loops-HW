/*
* You are given n integers (given in a single line, separated by a space).
* Write a program that checks whether
* the product of the odd elements is equal to the product of the even elements.
* Elements are counted from 1 to n,
* so the first element is odd, the second is even, etc.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Integers (given in a single line, separated by a space): ");
        string strNumbers = Console.ReadLine();
        string[] splitedNames = strNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < splitedNames.Length; i++)
        {
            int currentNumber = int.Parse(splitedNames[i]);
            if (i % 2 == 0)
            {
                evenProduct *= currentNumber;
            }
            else if (i % 2 != 0)
            {
                oddProduct *= currentNumber;
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("product = {0}, result: yes", oddProduct);
        }
        else
        {
            Console.WriteLine("odd_product = {0}, even_product = {1}, result: no", oddProduct, evenProduct);
        }
        
    }
}

