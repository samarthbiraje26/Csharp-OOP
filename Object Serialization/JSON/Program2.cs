// Deserialization - Converting json to object

using System;
using System.Text.Json;

class Students
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program2
{
    static void Main()
    {
        string json = "{\"Name\":\"Rahul\",\"Age\":20}";

        // Convert JSON back to object
        Student s = JsonSerializer.Deserialize<Student>(json);

        Console.WriteLine(s.Name);
        Console.WriteLine(s.Age);
    }
}