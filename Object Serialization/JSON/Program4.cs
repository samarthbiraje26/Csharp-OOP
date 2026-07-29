// read json utf-8 file

using System;
using System.IO;
using System.Text;
using System.Text.Json;

class Student2
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program4
{
    static void Main()
    {
        string json = File.ReadAllText("student.json", Encoding.UTF8);

        Student s = JsonSerializer.Deserialize<Student>(json);

        Console.WriteLine(s.Name);
        Console.WriteLine(s.Age);
    }
}