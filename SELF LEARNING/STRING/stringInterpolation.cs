using System;
class Program
{
    static void Main(string[] args)
    {
        /*
        String Interpolation
        Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string. 
        Note that you do not have to worry about spaces, like with concatenation:
        */
        string fname = "Rajan";
        string lname = "Poudel";
        string name = $"My full name is: {fname} {lname}";
        Console.WriteLine(name);

        /*
        Also note that you have to use the dollar sign ($) when using the string interpolation method.
        String interpolation was introduced in C# version 6.
        */
    }
}