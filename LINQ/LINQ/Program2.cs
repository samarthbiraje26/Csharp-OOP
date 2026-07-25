/*
Create an Employee1 class and a list of employees.

Using LINQ, find:

1. Are there any employees whose salary is greater than 100000?
2. Are all employees older than 21?
3. Count employees from the HR department whose salary is greater than 50000.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPractice
{
    class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Department { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Rahul", Department = "IT", Age = 28, Salary = 70000 },
                new Employee { Id = 2, Name = "Amit", Department = "HR", Age = 30, Salary = 65000 },
                new Employee { Id = 3, Name = "Neha", Department = "IT", Age = 24, Salary = 80000 },
                new Employee { Id = 4, Name = "Priya", Department = "HR", Age = 26, Salary = 45000 },
                new Employee { Id = 5, Name = "Karan", Department = "IT", Age = 32, Salary = 90000 },
                new Employee { Id = 6, Name = "Sneha", Department = "Finance", Age = 27, Salary = 85000 }
            };

            // Question 1
            bool hasHighSalary = employees.Any(e => e.Salary > 100000);

            // Question 2
            bool allAbove21 = employees.All(e => e.Age > 21);

            // Question 3
            int hrCount = employees.Count(e => e.Department == "HR" &&
                                               e.Salary > 50000);

            Console.WriteLine("1. Any employee with salary > 100000 ?");
            Console.WriteLine(hasHighSalary);

            Console.WriteLine();

            Console.WriteLine("2. Are all employees older than 21 ?");
            Console.WriteLine(allAbove21);

            Console.WriteLine();

            Console.WriteLine("3. HR employees having salary > 50000");
            Console.WriteLine(hrCount);

            Console.ReadLine();
        }
    }
}