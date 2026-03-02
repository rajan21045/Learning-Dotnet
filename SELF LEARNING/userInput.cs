using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Your Name: ");
        string myName = Console.ReadLine();

        Console.Write("Enter Your Age: ");
        int myAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your Age Is: " + myAge);
        Console.WriteLine("My Name Is " + myName);

    }
}