using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.Marshalling;
using static System.Net.WebRequestMethods;

class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public int CourseId { get; set; }

    public int Age { get; set; }
}

class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int Fees { get; set; }
}

class Marks
{
    public int StudentId { get; set; }

    public string? Subject { get; set; }

    public int Score { get; set; }
}

class Trainer
{
    public int TrainerId { get; set; }

    public string? TrainerName { get; set; }

    public int CourseId { get; set; }
}
class Program
{
    static void Main()
    {

        List<Student> students = new List<Student>
{
    new Student { StudentId = 1, Name = "Rahul",   CourseId = 101, Age = 20 },
    new Student { StudentId = 2, Name = "Priya",   CourseId = 102, Age = 22 },
    new Student { StudentId = 3, Name = "Amit",    CourseId = 101, Age = 21 },
    new Student { StudentId = 4, Name = "Sneha",   CourseId = 103, Age = 23 },
    new Student { StudentId = 5, Name = "Rohan",   CourseId = 104, Age = 20 }
};


        List<Course> courses = new List<Course>
{
    new Course { CourseId = 101, CourseName = "C# Basics",     Fees = 5000  },
    new Course { CourseId = 102, CourseName = "SQL Server",    Fees = 4000  },
    new Course { CourseId = 103, CourseName = "ASP.NET",       Fees = 6000  },
    new Course { CourseId = 104, CourseName = "Azure",         Fees = 8000  }
};

        List<Marks> marksList = new List<Marks>
{
    new Marks { StudentId = 1, Subject = "C#",     Score = 85 },
    new Marks { StudentId = 2, Subject = "SQL",    Score = 90 },
    new Marks { StudentId = 3, Subject = "C#",     Score = 72 },
    new Marks { StudentId = 4, Subject = "ASP.NET",Score = 88 },
    new Marks { StudentId = 5, Subject = "Azure",  Score = 60 }
};

        List<Trainer> trainers = new List<Trainer>
{
    new Trainer { TrainerId = 1, TrainerName = "Mr. Sharma",  CourseId = 101 },
    new Trainer { TrainerId = 2, TrainerName = "Ms. Mehta",   CourseId = 102 },
    new Trainer { TrainerId = 3, TrainerName = "Mr. Verma",   CourseId = 103 }
};


        // Q1. Join students with courses and display StudentName and CourseName.
        //var result = courses.Join(
        //    students,
        //    c => c.CourseId,
        //    s => s.CourseId,
        //    (c, s) => new
        //    {
        //        CourseName = c.CourseName,
        //        StudentName = s.Name
        //    });
        //foreach (var detail in result)
        //{
        //    Console.WriteLine($"{detail.StudentName} - {detail.CourseName}");
        //}


        //Q2. Join students with their marks and display StudentName and Score.
        //var result = marksList.Join(
        //    students,
        //    m => m.StudentId,
        //    s => s.StudentId,
        //    (m, s) => new
        //    {
        //        ScoreMarks = m.Score,
        //        StudentName = s.Name
        //    });
        //foreach (var marks in result )
        //{
        //    Console.WriteLine($"{marks.StudentName} - {marks.ScoreMarks}");
        //}


        //Q3. Join students with courses and display StudentName, CourseName and Fees. Filter only those students whose course Fees are greater than 5000.
        //var result = courses.Join(
        //    students,
        //    c => c.CourseId,
        //    s => s.CourseId,
        //    (c, s) => new
        //    {
        //        StudentName = s.Name,
        //        CourseName = c.CourseName,
        //        Fees = c.Fees
        //    }).Where(c => c.Fees > 5000);
        //foreach (var fees in result)
        //{
        //    Console.WriteLine($"{fees.StudentName} - {fees.CourseName} - {fees.Fees}");
        //}


        //Q4. Join all three - students, courses and trainers. Display StudentName, CourseName and TrainerName.
        //var result = courses.Join(
        //    students,
        //    c => c.CourseId,
        //    s => s.CourseId,
        //    (c, s) => new {c, s})
        //    .Join(trainers, 
        //    sc => sc.c.CourseId,
        //    t => t.CourseId,
        //    (sc, t) => new
        //    {
        //        StudentName = sc.s.Name,
        //        CourseName = sc.c.CourseName,
        //        TrainerName = t.TrainerName
        //    });
        //foreach (var three in result) {
        //    Console.WriteLine($"{three.StudentName} - {three.CourseName} - {three.TrainerName}");
        //}


        //Q5. Join students with marks and display StudentName and Score.Order the result by Score in descending order.
        //var result = students.Join(
        //    marksList,
        //    s => s.StudentId,
        //    m => m.StudentId,
        //    (s, m) => new
        //    {
        //        StudentName = s.Name,
        //        Score = m.Score

        //    }).OrderByDescending(n => n.Score);
        //foreach (var score in result)
        //{
        //    Console.WriteLine($"{score.StudentName} - {score.Score}");
        //}


        //Q6. Join students with courses and find the total fees collected per course. Display CourseName and TotalFees.
        //var result = students.Join(
        //    courses,
        //    s => s.CourseId,
        //    c => c.CourseId,
        //    (s, c) => c).GroupBy(c => c.CourseName).Select(g => new
        //    {
        //        CourseName = g.Key,
        //        TotalFees = g.Sum (x => x.Fees)
        //    });
        //foreach (var fees in result)
        //{
        //    Console.WriteLine($"{fees.CourseName} - {fees.TotalFees}");
        //}


        //Q7. Left Join (GroupJoin) - Display all courses and the students enrolled in them. If no student is enrolled show StudentName as "No Student".
        //var result = courses.GroupJoin(
        //    students,
        //    c => c.CourseId,
        //    s => s.CourseId,
        //    (c, s) => new { c, s })
        //        .SelectMany(
        //        x => x.s.DefaultIfEmpty(),
        //        (x, s) => new
        //        {
        //            CourseName = x.c.CourseName,
        //            StudentName = s != null ? s.Name : "No Student"
        //        });

        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.CourseName} - {item.StudentName}");
        //}


        //Q8. Join students with marks and display only those students whose Score is greater than 80.Display StudentName, Subject and Score.
        //var result = students.Join(
        //    marksList,
        //    s => s.StudentId,
        //    m => m.StudentId,
        //    (s, m) => new
        //    {
        //        StudentName = s.Name,
        //        Subject = m.Subject,
        //        Score = m.Score
        //    }).Where(m => m.Score > 80);
        //foreach (var marks in result)
        //{
        //    Console.WriteLine($"{marks.StudentName} - {marks.Subject} - {marks.Score}");
        //}


        //Q9. Join students with courses and trainers. Display StudentName, CourseName, Fees and TrainerName. Filter only courses with Fees greater than 4000.
        //var result = students.Join(
        //    courses,
        //    s => s.CourseId,
        //    c => c.CourseId,
        //    (s, c) => new { s, c }).Join(trainers,
        //        sc => sc.c.CourseId,
        //        t => t.CourseId,
        //        (sc, t) => new
        //        {
        //            StudentName = sc.s.Name,
        //            CourseName = sc.c.CourseName,
        //            Fees = sc.c.Fees,
        //            TrainerName = t.TrainerName
        //        }).Where(x => x.Fees > 4000);

        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.StudentName} - {item.CourseName} - {item.Fees} - {item.TrainerName}");
        //}


        // Q10. Join students with marks, find the student with the highest score. Display StudentName and Score.
        var result = students.Join(
            marksList,
            s => s.StudentId,
            m => m.StudentId,
            (s, m) => new
            {
                StudentName = s.Name,
                Score = m.Score
            }).Max(x => x.Score);
        Console.WriteLine(result);
    }
}
