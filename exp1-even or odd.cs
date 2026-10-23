using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine("Even Number");
        else
            Console.WriteLine("Odd Number");
    }
}
