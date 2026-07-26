/*
Store student roll numbers and names.
Remove roll number 103.
Display all remaining students.

Concepts: Remove()
*/

using System;
using System.Collections.Generic;
using System.Text;

class Dict
{
    static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(101, "Mia");
        dict.Add(102, "Chris");
        dict.Add(103, "Tony");
        dict.Add(104, "Walter");

        dict.Remove(103);

        foreach (KeyValuePair<int, string> kvp in dict)
        {
            Console.WriteLine(kvp);
        }
    }
}