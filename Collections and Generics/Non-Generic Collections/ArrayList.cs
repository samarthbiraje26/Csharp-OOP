// ArrayList

/*
Create an ArrayList.

Add 10, 20, 30, 40
Insert 25 at index 2.
Display the updated list.

Concepts: Insert()
*/

using System;
using System.Collections;


class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        list.Insert(2, 25);

        list.Remove(10);

        list.RemoveAt(2);

        foreach (int num in list)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}