// Auto implemented property - When you dont need any validation

using System;

public class Emp
{
    // Auto-implemented property
    public string Name { get; set; }
}

class Prog
{
    static void Main()
    {
        Emp emp = new Emp();

        emp.Name = "Rahul";

        Console.WriteLine(emp.Name);
    }
}