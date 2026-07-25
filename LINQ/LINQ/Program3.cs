// given a list = {1, 2, 3, 3, 4, 4, 5, 6, 7, 8}

using System;
using System.Linq;

class LinqProgram
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 3, 4, 4, 5, 6, 7, 8 };

        var result = numbers.Distinct().Skip(3).Take(4);

        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}
