/*
Create a Hashtable.
Store employee IDs and employee names.
Check whether employee ID 102 exists.

Print:
Employee Found
or
Employee Not Found

Concepts: ContainsKey()
*/


using System;
using System.Collections;
using System.Text;

class Program1
{
    static void Main()
    {
        Hashtable hash = new Hashtable();

        hash.Add(101, "Adam Johns");
        hash.Add(102, "Sarah Liam");
        hash.Add(103, "Cristiano Ronaldo");
        hash.Add(104, "Jessy Jones");

        // Checking whether employee ID 102 exists
        if (hash.ContainsKey(102))
        {
            Console.WriteLine("Employee Found");
        }
        else
        {
            Console.WriteLine("Employee Not Found");
        }

        Console.ReadLine();
    }
}