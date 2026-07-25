/*
Question 1 - Multiple Conditions + Projection

Create an Employee class with:
Id
Name
Department
Age
Salary

Retrieve the Name and Salary of employees who:
belong to the IT department
are older than 25
earn more than ₹60,000

Sort them by salary in descending order.
*/

using System;
using System.Linq;

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
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Rahul", Department = "IT", Age = 28, Salary = 70000 },
            new Employee { Id = 2, Name = "Amit", Department = "HR", Age = 30, Salary = 65000 },
            new Employee { Id = 3, Name = "Neha", Department = "IT", Age = 24, Salary = 80000 },
            new Employee { Id = 4, Name = "Priya", Department = "IT", Age = 29, Salary = 55000 },
            new Employee { Id = 5, Name = "Karan", Department = "IT", Age = 32, Salary = 90000 },
            new Employee { Id = 6, Name = "Sneha", Department = "Finance", Age = 27, Salary = 85000 }


        };

        var result = employees.Where(e => e.Department == "IT" && e.Age > 25 && e.Salary > 60000)
        .OrderByDescending(e => e.Salary).Select(e => new { e.Name, e.Salary });

        foreach (var emp in result)
        {
            Console.WriteLine($"Name : {emp.Name}");
            Console.WriteLine($"Salary : {emp.Salary}");
            Console.WriteLine("-------------------------");
        }
    }

}