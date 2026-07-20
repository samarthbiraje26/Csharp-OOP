using System;

class Animal1
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal Sound");
    }
}

class Dogs : Animal
{
    public override void Sound()
    {
        // Call parent method first.
        base.Sound();

        // Then child method.
        Console.WriteLine("Dog Barks");
    }
}

class Program2
{
    static void Main()
    {
        Dogs dog = new Dogs();

        dog.Sound();
    }
}

// Output - 
// Animal Sound
// Dog Barks