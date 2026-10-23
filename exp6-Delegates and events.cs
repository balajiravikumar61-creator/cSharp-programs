delegates:

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


events:


using System;

class Test
{
    public event Action MyEvent;

    public void Show()
    {
        MyEvent?.Invoke();
    }
}

class Program
{
    static void Display()
    {
        Console.WriteLine("Event occurred");
    }

    static void Main()
    {
        Test t = new Test();
        t.MyEvent += Display;
        t.Show();
    }
}
