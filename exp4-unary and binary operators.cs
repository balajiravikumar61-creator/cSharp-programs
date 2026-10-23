unary:

using System;

class Number
{
    public int x;

    public Number(int a)
    {
        x = a;
    }

    public static Number operator -(Number n)
    {
        return new Number(-n.x);
    }
}

class Program
{
    static void Main()
    {
        Number n = new Number(10);
        Number result = -n;

        Console.WriteLine("Result = " + result.x);
    }
}

binary:

using System;

class Number
{
    public int x;

    public Number(int a)
    {
        x = a;
    }

    public static Number operator +(Number a, Number b)
    {
        return new Number(a.x + b.x);
    }
}

class Program
{
    static void Main()
    {
        Number n1 = new Number(10);
        Number n2 = new Number(20);
        Number result = n1 + n2;

        Console.WriteLine("Sum = " + result.x);
    }
}
