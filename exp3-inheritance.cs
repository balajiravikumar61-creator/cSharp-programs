single inheritance:

using System;

class A
{
    public void Display()
    {
        Console.WriteLine("Class A");
    }
}

class B : A
{
    public void Show()
    {
        Console.WriteLine("Class B");
    }
}

class Program
{
    static void Main()
    {
        B obj = new B();
        obj.Display();
        obj.Show();
    }
}

multilevel inheritance:

using System;

class A
{
    public void Display()
    {
        Console.WriteLine("Class A");
    }
}

class B : A
{
    public void Show()
    {
        Console.WriteLine("Class B");
    }
}

class C : B
{
    public void Print()
    {
        Console.WriteLine("Class C");
    }
}

class Program
{
    static void Main()
    {
        C obj = new C();
        obj.Display();
        obj.Show();
        obj.Print();
    }

  multiple inheritance:

  using System;

interface A
{
    void Display();
}

interface B
{
    void Show();
}

class C : A, B
{
    public void Display()
    {
        Console.WriteLine("Interface A");
    }

    public void Show()
    {
        Console.WriteLine("Interface B");
    }
}

class Program
{
    static void Main()
    {
        C obj = new C();
        obj.Display();
        obj.Show();
    }
}
}
