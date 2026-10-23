using System;

delegate void MyDelegate();

class Program
{
    static void Display()
    {
        Console.WriteLine("Hello C#");
    }

    static void Main()
    {
        MyDelegate d = Display;
        d();
    }
}
