using System;
class Program
{
    static void Main(string[] args)
    {
        /*
        C# Strings
        Strings are used for storing text.
        */
        string myString = "Rajan Poudel";
        string greeting2 = "Nice to meet you!";
        Console.WriteLine("The First String Is: " + myString);
        Console.WriteLine("The Second String Is: " + greeting2);

        /*
        String Length
        A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings. 
        For example, the length of a string can be found with the Length property:
        */
        int stringLength = myString.Length;
        Console.WriteLine("The Length of String \'myString\' is {0}.", stringLength);

        /*
        Other Methods
        There are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:
        */
        Console.WriteLine("Original String: {0}", greeting2);
        Console.WriteLine("After Uppercase The String \'{0}\' Is {1}", greeting2, greeting2.ToUpper());
        Console.WriteLine("After Lowercase The String \'{0}\' Is {1}", greeting2, greeting2.ToLower());
    }
}