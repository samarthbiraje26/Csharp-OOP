/*
Create a Stack.

Push 10, 20, 30, 40
Remove the top element.
Display the remaining elements.

Concepts: Push(), Pop()
*/

using System;
using System.Collections;
using System.Text;

class Program2
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        stack.Pop();

        stack.Peek();

        foreach (int i in stack)
        {
            Console.WriteLine(i);
        }
    }
}