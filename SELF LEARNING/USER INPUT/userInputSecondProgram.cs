using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter two numbers: ");
        string input = Console.ReadLine();

        string[] values = input.Split(' ');
 
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);

        Console.WriteLine("First Number: " + a);
        Console.WriteLine("Second Number: " + b);
    }
}