using System;

class Program
{
    static void Main()
    {
        int a, b;

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
            Console.WriteLine("Largest = " + a);
        else if (b > a)
            Console.WriteLine("Largest = " + b);
        else
            Console.WriteLine("Both numbers are equal");
    }
}
