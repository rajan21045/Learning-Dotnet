//C# Named Arguments
//Named Arguments
//It is also possible to send arguments with the key: value syntax.
//That way, the order of the arguments does not matter:
using System;
class Program
{
    static void MyMethod(string child1, string child2, string child3)
    {
        Console.WriteLine("Hello, Mr. {0}, Mr. {1}, Mr. {2}.", child1, child2, child3);
    }

    static void Main()
    {
        MyMethod(child1: "Rajan Poudel", child2: "Prabin Poudel", child3: "Raaj Poudel");
    }
}