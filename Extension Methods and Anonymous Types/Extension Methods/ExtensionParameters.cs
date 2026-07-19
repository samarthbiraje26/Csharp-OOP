// Extension method with parameters

using System;
public static class StringExtension
{
    public static string Repeat(this string text, int times)
    {
        string result = "";

        for (int i = 1; i <= times; i++)
        {
            result += text;
        }

        return result;
    }
}
class Parameters
{
    static void Main()
    {
        Console.WriteLine("Hi".Repeat(3));
    }
}