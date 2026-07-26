/*
Store

3 Mouse
1 Keyboard
5 Monitor
2 Printer

Display the data.

Explain why the output is automatically sorted.
*/

using System;
using System.Collections.Generic;
using System.Text;

class Program1
{
    static void Main()
    {
        SortedList<int, string> slist = new SortedList<int, string>();

        slist.Add(3, "Mouse");
        slist.Add(1, "Keyboard");
        slist.Add(5, "Monitor");
        slist.Add(2, "Printer");

        foreach (KeyValuePair<int, string> i in slist)
        {
            Console.WriteLine(i);
        }
    }
}

// The list is automatically sorted because SortedList has property of sorting the elements.