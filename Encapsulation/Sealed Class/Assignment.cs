/*
Create sealed class Hospital

Methods
RegisterPatient()
DischargePatient()

Create object
Call both methods.
*/


using System;

sealed class Hospital
{
    public void RegisterPatient ()
    {
        Console.WriteLine("Patient registered.");
    }

    public void DischargePatient ()
    {
        Console.WriteLine("Patient discharged.");
    }
}

class Program
{
    static void Main (string[] args)
    {
        Hospital hospital = new Hospital();

        hospital.RegisterPatient();
        hospital.DischargePatient();
    }
}