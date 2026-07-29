// xml deserialization

using System;
using System.IO;
using System.Xml.Serialization;

public class Student2
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program2
{
    static void Main()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Student));

        using (FileStream fs = new FileStream("student.xml", FileMode.Open))
        {
            Student s = (Student)serializer.Deserialize(fs);

            Console.WriteLine(s.Name);
            Console.WriteLine(s.Age);
        }
    }
}