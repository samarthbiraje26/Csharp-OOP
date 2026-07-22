using System;

class Animal
{
    public virtual void Speak ()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Speak ()
    {
        Console.WriteLine("Dog barks");
    }
}

class Prog
{
    static void Main (string[] args)
    {
        Animal obj = new Dog();

        obj.Speak ();
    }
}