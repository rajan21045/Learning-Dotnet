using System;
class Program
{
    static void Main()
    {
        string firstName = "Rajan";
        string secondName = "Poudel";
        //The + operator can be used between strings to combine them. This is called concatenation:
        string fullName = firstName + secondName;
        Console.WriteLine("Full Name: {0}", fullName);

        //Note that we have added a space after "John" to create a space between firstName and lastName on print.
        //You can also use the string.Concat() method to concatenate two strings:
        Console.WriteLine("After Using String Concat method, The String Is: {0}.", string.Concat(firstName, secondName));

        //Adding Numbers and Strings
        //If you add two numbers, the result will be a number:
        int x = 10;
        int y = 20;
        int z = x + y;  // z will be 30 (an integer/number)
        Console.WriteLine(z);

        //If you add two strings, the result will be a string concatenation:
        //Example
        string x1 = "10";
        string y1 = "20";
        string z1 = x1 + y1;  // z will be 1020 (a string)
        Console.WriteLine(z1);
    }
}