// A partial class allows one class to be divided into multiple files.
// At compile time, C# combines them into a single class.

/*
Syntax :

File 1 - 
public partial class Employee
{
    public string Name;
}

File 2
public partial class Employee
{
    public int Age;
}

Compiler combines
↓
Employee
{
    Name
    Age
}
*/

using System;

class Program
{
    static void Main()
    {
        Employee employee = new Employee();

        employee.Name = "Rahul";
        employee.Department = "IT";

        employee.DisplayName();
        employee.DisplayDept();
    }
}