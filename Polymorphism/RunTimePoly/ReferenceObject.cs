using System;

class Animals
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal Sound");
    }
}

class Cow : Animals
{
    public override void Sound()
    {
        Console.WriteLine("Cow Moos");
    }
}

class Cat : Animals
{
    public override void Sound()
    {
        Console.WriteLine("Cat Meows");
    }
}

class Program1
{
    static void Main()
    {
        Animals animal;

        animal = new Cow();
        animal.Sound();

        animal = new Cat();
        animal.Sound();
    }
}



/*
Why is it called Runtime?
Because the decision is made while the program is running.

Compile time - Animal animal;

Compiler only knows - Animal

Runtime - 
new Dog()
new Cat()

Now C# decides which method to call.
*/