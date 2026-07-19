/* 
Methods can also be sealed.
But only if
- method is override
- parent method is virtual
*/

using System;

class Person
{
    public virtual void Display()
    {
        Console.WriteLine("Person");
    }
}

class Employee : Person
{
    public sealed override void Display()
    {
        Console.WriteLine("Employee");
    }
}

class Manager : Employee
{
    // ERROR
    // public override void Display()
}