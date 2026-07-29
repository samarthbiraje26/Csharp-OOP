// save json to utf-8 file

using System;
using System.IO;
using System.Text;
using System.Text.Json;

class Student1
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program3
{
    static void Main()
    {
        Student s = new Student
        {
            Name = "Rahul",
            Age = 20
        };

        string json = JsonSerializer.Serialize(s);

        // Save using UTF-8 encoding
        File.WriteAllText("student.json", json, Encoding.UTF8);

        Console.WriteLine("File Saved");
    }
}