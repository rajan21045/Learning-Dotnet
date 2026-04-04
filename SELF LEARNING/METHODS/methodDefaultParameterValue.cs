//Default Parameter Value
using System;
class Program
{
    static void DetailInfo(string name = "Rajan Poudel", double salary = 124022, string address = "Gaindakot")
    {
        Console.WriteLine("Name: {0}, Salary: {1}, Address: {2}", name, salary, address);
    }

    static void Main(string[] args)
    {
        //You can also use a default parameter value, by using the equals sign (=). This way, when you call the method without passing any arguments, the default values will be used. If you pass arguments, the default values will be overridden.
        DetailInfo(); // Uses all default values
        DetailInfo("Alice Johnson"); // Overrides only the name
        DetailInfo("Bob Smith", 75000); // Overrides name and salary
        DetailInfo("Charlie Brown", 80000, "123 Main St"); // Overrides all parameters
    }
}