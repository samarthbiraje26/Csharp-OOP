/*
Create

10
20
20
30
30
40
50

Store these numbers in a HashSet<int>.

Display the collection.

Explain why duplicates disappeared.
*/

using System;
using System.Collections.Generic;
using System.Text;

class Hash
{
    static void Main()
    {
        HashSet<int> hash = new HashSet<int> { 10, 20, 20, 30, 30, 40, 50 };

        foreach (int i in hash)
        {
            Console.WriteLine(i);
        }
    }
}

// Hashset only stores unique values. The duplicate values automatically get disappeared.