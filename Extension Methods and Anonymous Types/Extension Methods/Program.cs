/* Syntax of extension method - 

    public static class EmployeeExtensions
    {
    public static ReturnType MethodName(this Employee emp)
    {
        // Logic
    }
    }
*/



// Extension method with string

using System;

// Static class because extension methods must be inside a static class.
public static class StringExtensions
{
    // 'this string name' means this method extends the string class.
    public static string ToHospitalId(this string name)
    {
        return "HOSP-" + name.ToUpper();
    }
}

class Program
{
    static void Main()
    {
        string patient = "Rahul";

        // Looks like ToHospitalId() is a built-in string method.
        Console.WriteLine(patient.ToHospitalId());
    }
}