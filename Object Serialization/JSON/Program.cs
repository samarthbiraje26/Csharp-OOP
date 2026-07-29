// Serialization - converting object to json

using System;
using System.Text.Json;

class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student()
        {
            Name = "Rahul",
            Age = 20
        };

        // Convert object into JSON
        string json = JsonSerializer.Serialize(s);

        Console.WriteLine(json);
    }
}