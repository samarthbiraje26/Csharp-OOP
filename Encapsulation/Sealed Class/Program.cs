// A sealed class is a class that cannot be inherited.

using System;

sealed class Animal
{
    public void Sound ()
    {
        Console.WriteLine("Animal Sound");
    }
}

class Dog : Animal // This will give error
{

}


/* 
Can a sealed class inherit another class?
YES
This surprises beginners.

Example
class Person
{
}

sealed class Employee : Person
{
}

The sealed class can inherit from a parent, but nothing can inherit from the sealed class.
*/