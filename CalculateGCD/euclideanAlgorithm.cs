using System;

class euclideanAlgorithm
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int c = 0;
        int GCD = 0;

        if (a > b)
        {
            c = b;
            b = a;
            a = c;
        }

        while (b != 0)
        {
            GCD = a % b;
            a = b;
            if (GCD == 0)
            {
                GCD = b;
                b = 0;
                break;
            }
            else
            {
                b = GCD; // do this only if we need to loop again
            }
        }
        Console.WriteLine("GCD = {0}", GCD);
    }
}
