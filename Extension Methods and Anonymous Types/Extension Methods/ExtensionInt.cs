// Extension method with int

using System;

public static class StringExt
{
    public static int Square(this int number)
    {
        return number * number;
    }
}

class Prog
{
    static void Main()
    {
        int number = 6;

        Console.WriteLine(number.Square());
    }
}