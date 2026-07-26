/*
1. Create an Employee class:
    Id
    Name
    Salary

2. Store 5 employees.

3. Display employees whose salary is greater than 60000.
*/

using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a Generic List of Employees
        List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 101, Name = "Rahul", Salary = 50000 },
                new Employee { Id = 102, Name = "Amit", Salary = 65000 },
                new Employee { Id = 103, Name = "Neha", Salary = 70000 },
                new Employee { Id = 104, Name = "Priya", Salary = 55000 },
                new Employee { Id = 105, Name = "Karan", Salary = 80000 }
            };

        // Display employees whose salary is greater than 60000
        var result = employees.Where(emp => emp.Salary > 60000);

        Console.WriteLine("Employees having Salary > 60000\n");

        foreach (Employee emp in result)
        {
            Console.WriteLine("ID     : " + emp.Id);
            Console.WriteLine("Name   : " + emp.Name);
            Console.WriteLine("Salary : " + emp.Salary);
            Console.WriteLine("-------------------------");
        }

        Console.ReadLine();
    }
}



/*
Create a List<int> containing:

10, 15, 20, 25, 30, 35, 40
Remove all numbers greater than 25.
Display the updated list.
*/

class P
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 15, 20, 25, 30, 35, 40 };

        numbers.RemoveAll(n => n > 25);

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}