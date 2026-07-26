/*
Create a Queue.

Add:

A
B
C
D
Remove the first element.
Display the remaining queue.

Concepts: Enqueue(), Dequeue()
*/


using System;
using System.Collections;
using System.Text;

class Program3
{
    static void Main ()
    {
        Queue queue = new Queue();

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");
        queue.Enqueue("D");

        queue.Dequeue();

        queue.Peek();

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}