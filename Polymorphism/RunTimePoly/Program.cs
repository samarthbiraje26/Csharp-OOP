// Run Time Polymorphism / Method Overriding 
// Same Method , Different Implementation 

// Keywords -
// Parent - virtual
// Child - override

using System;

class Animal
{
    public virtual void Sound ()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public override void Sound ()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main ()
    {
        Dog d = new Dog();

        d.Sound();
    }
}