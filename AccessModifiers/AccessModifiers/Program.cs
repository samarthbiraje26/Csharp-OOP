// Assignment : 
// 1. Create a class named Person and add the following - 
// Member                  Access Modifier
// PatientName              Public
// PatientId                Public
// Diagnosis                Protected
// HospitalPolicy           Internal

// 2. Create the 2 classes - Patient and Doctor. Both classes should inherit from Person class.

// 3. Inside Doctor class, create a method named - DisplayPatientDiagnosis. 
// Display - PatientName, Diagnosis, Void

// 4. Inside the Patient.cs, create a Patient object. 
// Try accessing - PatientName, PatientId, Diagnosis. Observe which members are accessible.

// 5. Check HospitalPolicy for public, private, protected and protected internal.



using AccessModifiers;
using System;

namespace AccessModifiers
{

    public class Person
    {
        public string PatientName;

        public int PatientId;

        protected string Diagnosis;

        internal string HospitalPolicy;
    }

}

class Hospital
{
    static void Main (string[] args)
    {
        Patient patient = new Patient();

        patient.PatientName = "Rahul";
        patient.PatientId = 1;

        Console.WriteLine(patient.PatientName);
        Console.WriteLine(patient.PatientId);
        //Console.WriteLine(patient.Diagnosis);
        // "Diagnosis is inaccessible due to its access modifier level of "internal". The code will not compile in such case.
    }
}

