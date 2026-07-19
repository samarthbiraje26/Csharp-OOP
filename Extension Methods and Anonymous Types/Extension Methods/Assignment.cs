/* 
1.  Create a Student class.
    It should contain:
    Name
    Marks

2.  Create two extension methods:
    1. GetStudentId()
    Output:
    STD - Rahul

    2. IsPassed()
    If marks are 35 or more, return:
    Pass
    Otherwise:
    Fail

3.  In Main():
    Create a Student object and call both extension methods.
*/

using System;
public class Student
{
    public string? Name;

    public int Marks;
}

public static class StudentExtensions
{
    public static string GetStudentId(this Student student)
    {
        return "STD-" + student.Name;
    }

    public static string IsPassed (this Student student)
    {
        if (student.Marks >= 35)
            return "Pass";

        return "Fail";
    } 
}

class Assignment
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.Name = "Rahul";
        s.Marks = 72;

        // Call extension methods just like normal methods.
        Console.WriteLine(s.GetStudentId());
        Console.WriteLine(s.IsPassed());
    }
}