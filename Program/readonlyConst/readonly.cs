using System;
using System.Collections.Generic;
using System.Text;

namespace Program;

class @readonly
{
    readonly int x = 5;
    static void Main (string[] args)
    {
        Program obj = new Program ();
        Console.WriteLine(obj.x);
        Console.Read();
    }
}
