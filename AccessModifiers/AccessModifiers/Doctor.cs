using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
        public class Doctor : Person
        {
            public void DisplayPatientDiagnosis()
            {
                Console.WriteLine("Patient Name : " + PatientName);
                Console.WriteLine("Diagnosis Report : " + Diagnosis);
            }
        }
}
