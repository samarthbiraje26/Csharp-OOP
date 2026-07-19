// Design a simple using the concept of operator overloading.

using System;

public class Calculator
{
    public int Number;
    public Calculator(int number)
    {
        Number = number;
    }

    public static Calculator operator + (Calculator c1, Calculator c2)
    {
        return new Calculator(c1.Number + c2.Number);
    }

    public static Calculator operator - (Calculator c1, Calculator c2)
    {
        return new Calculator(c1.Number - c2.Number);
    }

    public static Calculator operator * (Calculator c1, Calculator c2)
    {
        return new Calculator(c1.Number * c2.Number);
    }

    public static Calculator operator / (Calculator c1, Calculator c2)
    {
        return new Calculator(c1.Number / c2.Number);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(50);
            Calculator c2 = new Calculator(25);

            Calculator add = c1 + c2;
            Calculator sub = c1 - c2;
            Calculator mul = c1 * c2;
            Calculator div = c1 / c2;

            Console.WriteLine(add.Number);
            Console.WriteLine(sub.Number);
            Console.WriteLine(mul.Number);
            Console.WriteLine(div.Number);
        }
    }
}