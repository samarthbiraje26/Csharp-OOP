using System;

class Printer
{
    public void Print (string text)
    {
        Console.WriteLine(text);
    }

    public void Print (int a)
    {
        Console.WriteLine(a);
    }
}

class Prog
{
    static void Main(string[] args)
    {
        Printer p = new Printer ();

        p.Print("I am the best.");
        p.Print(7);
    }
}