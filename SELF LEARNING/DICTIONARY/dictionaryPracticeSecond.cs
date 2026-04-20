using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, string> dObj = new Dictionary<string, string>();
        dObj.Add("rajan", "Pass");
        dObj.Add("prabin", "prabin@123");
        dObj.Add("admin", "admin");

        string username = "admin";
        string password = "admin";

        if (dObj.ContainsKey(username))
        {
            Console.WriteLine("User Already Exits");
        }

        if (dObj.ContainsValue(password))
        {
            Console.WriteLine("Password Found!!");
        }

        Dictionary<string, string> dObj2 = new Dictionary<string, string>();
        dObj.Add("Raaj", "Hello");
        dObj.Add("Ashok", "Ashok@123");
        dObj.Add("Sasin", "Sasin");

        var combined = dObj.Concat(dObj2);
        foreach(var item in combined)
        {
            Console.WriteLine(item.Key + " "+ item.Value);
        }

        var dict1 = new Dictionary<string, string>
        {
            {"Bruce Wayne", "Batman"},
            {"Harvey Dent", "Two Face"}
        };

        var dict2 = new Dictionary<string, string>
        {
            {"Oswald Chesterfield Cobblepot", "Penguin"},
            {"Edward Nygma", "Riddler"}
        };

        Console.WriteLine();
        var combined1 = dict1.Concat(dict2);
        foreach(var items in combined1)
        {
            Console.WriteLine(items.Key + " "+ items.Value);
        }
    }
}