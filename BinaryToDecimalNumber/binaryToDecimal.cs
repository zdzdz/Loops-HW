//Problem 13. Binary to Decimal Number

//    Using loops write a program that converts a binary integer number to its decimal form.
//    The input is entered as string. The output should be a variable of type long.
//    Do not use the built-in .NET functionality.


using System;

class binaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();

        long decimalNumber = 0;

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            decimalNumber += long.Parse(binary[binary.Length - i - 1].ToString()) * (long)Math.Pow(2, i);
        }
        Console.WriteLine("Decimal: " + decimalNumber);

    }
}

