// xml serialization

using System;
using System.IO;
using System.Xml.Serialization;

public class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student
        {
            Name = "Rahul",
            Age = 20
        };

        XmlSerializer serializer = new XmlSerializer(typeof(Student));

        using (FileStream fs = new FileStream("student.xml", FileMode.Create))
        {
            serializer.Serialize(fs, s);
        }

        Console.WriteLine("XML File Created");
    }
}