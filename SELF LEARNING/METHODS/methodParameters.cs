//Method Parameters
//They are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.

using System;
class Program
{
    static void MyMethod(string fname)
    {
        Console.WriteLine(fname + " Refsnes");
    }
    static void message(string mess)
    {
        Console.WriteLine("This Is A Message: " + mess);
    }

    //Multiple Parameters
    static void MyInfo(int id, double salary, string name, int age)
    {
        Console.WriteLine("Hello, {0}, Your ID is: {1}, Your Salary is: {2}, Your Age is: {3}", name, id, salary, age);
    }
    static void Main(string[] args)
    {
        message("Hello World!");

        //When a parameter is passed to the method, it is called an argument. So, from the example above: fname is a parameter, while Liam, Jenny and Anja are arguments.
        MyMethod("Liam");
        MyMethod("Jenny");
        MyMethod("Anja");

        //Note that when you are working with multiple parameters, the method call must have the same number of arguments as there are parameters, and the arguments must be passed in the same order.
        MyInfo(123, 50000.50, "John Doe", 30);

    }
}