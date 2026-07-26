/*
1. Create a hospital queue.

Add - 
Rahul
Amit
Neha
Priya

2. Treat two patients.

3. Display the remaining patients.

Concepts: Enqueue(), Dequeue()
*/

using System;
using System.Collections.Generic;
using System.Text;

class Prog
{
    static void Main(string[] args)
    {
        Queue<string> patients = new Queue<string>();

        patients.Enqueue("Rahul");
        patients.Enqueue("Amit");
        patients.Enqueue("Neha");
        patients.Enqueue("Priya");

        patients.Dequeue();
        patients.Dequeue();

        foreach (string patient in patients)
        {
            Console.WriteLine(patient);
            Console.ReadLine();
        }



    }
}