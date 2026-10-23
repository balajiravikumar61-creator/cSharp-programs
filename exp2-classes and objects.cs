using System;

class Student
{
    public string name = "Balaji";
    public int age = 19;

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Display();
    }
}
