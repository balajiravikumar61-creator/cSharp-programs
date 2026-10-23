using System;
using System.Threading;

class Program
{
    static void Display()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread: " + i);
        }
    }

    static void Main()
    {
        Thread t = new Thread(Display);
        t.Start();

        Console.WriteLine("Main Thread");
    }
}
