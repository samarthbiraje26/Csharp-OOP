/*
Design a Hospital Management System

Requirements

1. Create an interface IHospital having a method:AdmitPatient()
2. Create an abstract class Hospital implementing the interface.
3. Add one common method in the abstract class named: DisplayHospitalName() which prints Welcome to City Care Hospital
4. Create a class GeneralWard inheriting from Hospital.
5. Implement the AdmitPatient() method inside GeneralWard.
5. In Main() Create the object of GeneralWard
6. Call both methods.
*/

interface IHospital
{
    void AdmitPatient();
}

abstract class Hospital
{
    public void DisplayHospitalName ()
    {
        Console.WriteLine("Welcome to Care City Hospital");
    }
    public abstract void AdmitPatient();
}

class GeneralWard : Hospital
{
    public override void AdmitPatient()
    {
        Console.WriteLine("Patient admitted");
    }
}

class Program
{
    static void Main ()
    {
        GeneralWard ward = new GeneralWard();

        // Calling methods
        ward.DisplayHospitalName();
        ward.AdmitPatient();

        Console.ReadLine();
    }
}