using System;

class decToHex
{
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long num = long.Parse(Console.ReadLine());
        string hex = "";
        string temp;

        while (num > 0)
        {
            temp = (num % 16).ToString();
            switch (temp)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    hex += temp;
                    break;
                case "10":
                    hex += "A";
                    break;
                case "11":
                    hex += "B";
                    break;
                case "12":
                    hex += "C";
                    break;
                case "13":
                    hex += "D";
                    break;
                case "14":
                    hex += "E";
                    break;
                case "15":
                    hex += "F";
                    break;
                default:
                    break;
            }
            num /= 16;
        }
        hex = Reverse(hex);
        Console.WriteLine("Result: " + hex);
    }
}

