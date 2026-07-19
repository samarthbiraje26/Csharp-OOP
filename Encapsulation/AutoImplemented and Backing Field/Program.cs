// Encapsulation is the process of hiding the data and controlling access to it using properties or methods.


// Backing Field - When we need validation (like age cannot be negative or bank balance cannot be negative)


//Create an employee class with -
//1.A private field_salary 2.A Property Salary 3.Validation : Salary should be greater than 0

using System;

class Employee
{
    private int _salary;
    public int Salary
    {
        get { return _salary; }

        set
        {
            if (value > 0)
            {
                _salary = value;
            }

            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

class Program
{
    static void Main ()
    {
        Employee emp = new Employee();

        emp.Salary = 50000;
        Console.WriteLine("Salary: " + emp.Salary);
    }
}