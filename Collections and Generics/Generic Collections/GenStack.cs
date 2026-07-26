/*
Create

RollNo
Name
Marks

Store 5 students.

Display only students whose marks are greater than 75.

Calculate the average marks.
*/

using System;
using System.Collections.Generic;

namespace StudentManagement
{
    // Student Class
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating Generic List
            List<Student> students = new List<Student>()
            {
                new Student { RollNo = 1, Name = "Rahul", Marks = 80 },
                new Student { RollNo = 2, Name = "Amit", Marks = 65 },
                new Student { RollNo = 3, Name = "Neha", Marks = 90 },
                new Student { RollNo = 4, Name = "Priya", Marks = 75 },
                new Student { RollNo = 5, Name = "Karan", Marks = 85 }
            };

            Console.WriteLine("Students having Marks greater than 75\n");

            int totalMarks = 0;

            foreach (Student student in students)
            {
                // Calculate total marks
                totalMarks += student.Marks;

                // Display students with marks > 75
                if (student.Marks > 75)
                {
                    Console.WriteLine("Roll No : " + student.RollNo);
                    Console.WriteLine("Name    : " + student.Name);
                    Console.WriteLine("Marks   : " + student.Marks);
                    Console.WriteLine("-------------------------");
                }
            }

            // Calculate Average
            double average = (double)totalMarks / students.Count;

            Console.WriteLine("Average Marks = " + average);

            Console.ReadLine();
        }
    }
}