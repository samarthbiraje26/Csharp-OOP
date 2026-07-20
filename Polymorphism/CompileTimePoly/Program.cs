// Compile Time Polymorphism / Method Overloading - 
// Same Name , Different Parameters

using System;
using System.ComponentModel;

class Calculator
{
    public void Add (int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public void Add (int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }
}

class Program
{
    static void Main (string[] args)
    {
        Calculator cal = new Calculator();

        cal.Add(10, 50);
        cal.Add(5, 40, 50);
    }
}


/*
How does C# know which Add() to call?

When you write - cal.Add(10,20);

Compiler checks - 
Add(int,int)

Exists?
Yes

↓

Call it.

When you write - cal.Add(10,20,30);

Compiler finds -
Add(int,int,int)

Call it.

Decision made before the program runs.

Hence, Compile Time Polymorphism.
*/



/* 
Invalid Overloading - 

class Demo
{
    public int Show()
    {
        return 10;
    }

    public string Show()
    {
        return "Hello";
    }
}

Because - Only return type changed. Parameters are the same.
*/