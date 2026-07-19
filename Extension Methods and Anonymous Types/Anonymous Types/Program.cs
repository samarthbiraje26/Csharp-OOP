/*
An Anonymous Type lets you create an object — without defining a class — quickly, for temporary use.


Syntax :
var var_name new 
{
    Name = "ABC",
    Dept = "IT"
};
Console.WriteLine(var_name.Name);


Why var ?
var lets the compiler infer the generated type for you.


Rules of anonymous type - 
1. No class needed.
2. Declared with var.
3. It has read-only properties. Value cannot be changed if assigned once.
4. Used for temporary and short lived use.


Why do we need anonymous type?
1. It builds only the fields we need.
2. Saves memory. 
*/

// Create an anonymous object for a Mobile Phone with these properties, and print all three:
// Company   ·   Model   ·   Price

var Mobile = new
{
    Company = "Samsung",
    Model = "S24",
    Price = 50000
};
Console.WriteLine(Mobile.Company);
Console.WriteLine(Mobile.Model);
Console.WriteLine(Mobile.Price);