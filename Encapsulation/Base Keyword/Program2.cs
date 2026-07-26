/*
Problem Statement
Design a Hospital Management System.

Requirements:
1. Create a class Hospital.
2. Add a method:DisplayHospitalInfo()
3. Print : City Care Hospital
4. Create a child class GeneralWard.
5. Add a method: AdmitPatient()
6. Inside AdmitPatient(), first call the parent method using base, then print - Patient admitted successfully.
*/

using System;

class Hospital
{
    public void DisplayHospitalInfo ()
    {
        Console.WriteLine("City Care Hospital.");
    }
}

class GeneralWrad : Hospital
{
    public void AdmitPatient ()
    {
        base.DisplayHospitalInfo ();

        Console.WriteLine("Patient Admitted successfully");
    }
}

class Prog
{
    static void Main ()
    {
        Hospital hospital = new Hospital();

        Console.ReadLine ();
    }
}