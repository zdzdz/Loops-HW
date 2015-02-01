//Problem 14. Decimal to Binary Number

//    Using loops write a program that converts an integer number to its binary representation.
//    The input is entered as long. The output should be a variable of type string.
//    Do not use the built-in .NET functionality.


using System;

class convertDecimalToBinary
{
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());
        string binary = " ";


        while (number > 0)
        {
            binary += (number % 2).ToString();
            number /= 2;
        }

        binary = Reverse(binary);
        Console.WriteLine("The binary numbere is: " + binary);
    }
}

