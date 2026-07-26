/*
1. Create Parent Class Employee Variable salary = 50000
2. Create Child Class Manager
3. Inside the child class
4. Print the salary using the base keyword.
5. Print: Manager Bonus : 10000
*/

using System;

class Employee
{
    public int salary = 50000;
}

class Manager : Employee
{
    public void DisplaySalary()
    {
        Console.WriteLine("Employee Salary : " + base.salary);
        Console.WriteLine("Manager Bonus : 10000");
    }
}

class Program3
{
    static void Main(string[] args)
    {
        // Creating object of Manager class
        Manager manager = new Manager();

        // Calling method
        manager.DisplaySalary();

        Console.ReadLine();
    }
}