/*
Problem Statement

Design a College Management System.

Requirements:

1. Create a class College.
2. Create a constructor in College that displays: Welcome to ABC College.
3. Create a child class Student.
4. Use the base keyword to call the parent constructor.
5. In Main(), create an object of Student.
6. Expected Output - Welcome to ABC College

Student object created.
Concept Tested: base() constructor call
*/

class College
{
    public College ()
    {
        Console.WriteLine("Welcome to ABC College");
    }
}

class Student : College
{
    public Student () : base()
    {
        Console.WriteLine("Student object created");
    }
}

class Program
{
    static void Main ()
    {
        Student student = new Student();

        Console.ReadLine ();
    }
}