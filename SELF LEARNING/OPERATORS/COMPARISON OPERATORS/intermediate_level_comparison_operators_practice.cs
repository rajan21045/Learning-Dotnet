using System;
using System.Security.Cryptography;
class Program
{
    static void Main()
    {
        //4. Write a program that takes a user's age as input and uses comparison operators to categorize them as: Child (below 13), Teenager (13–17), Adult (18–59), or Senior (60 and above).
        Console.WriteLine("Enter The Age of Your: ");
        int age = Convert.ToInt32(Console.WriteLine());
        if (age < 13)
        {
            Console.WriteLine("You Are Child Because Your Age Is Less Than 13.");
        }
        else if (age >= 13 && age <= 17)
        {
            Console.WriteLine("You Are Teenager Because Your Age Is Greater Than 13 And Less Than 17.");
        }
        else if (age >= 18 && age <= 59)
        {
            Console.WriteLine("You Are Adult Because Your Age Is Greater Than 18 And Less Than 59.");
        }
        else if (age >= 60)
        {
            Console.WriteLine("You Are Senior Because Your Age Is Greater Than 60 And Above.");
        }

        //5. Given two double values representing product prices, write a program that prints the cheaper one. If both are equal, print "Same price".
        double product_price_first = 12.333;
        double product_price_second = 33.12;
        if (product_price_first < product_price_second)
        {
            Console.WriteLine($"Product Price First(Rs.{product_price_first}) Is Less Than Product Price Second (Rs.{product_price_second}).");
        }
        else if (product_price_second < product_price_first)
        {
            Console.WriteLine($"Product Price Second(Rs.{product_price_second}) Is Less Than Product Price First (Rs.{product_price_first}).");
        }
        else if (product_price_first == product_price_second)
        {
            Console.WriteLine("Both Price Are Equall. Same Price.");
        }



        //6. Write a program that compares two strings using == and also using .Equals(). Then test with a case where one string is assigned via new string(...) and observe whether == compares value or reference in C#.
        string a = "hello";
        string b = "hello";

        Console.WriteLine("=== Case 1: String Literals ===");
        Console.WriteLine($"a = \"{a}\"  |  b = \"{b}\"");
        Console.WriteLine($"a == b          : {a == b}");
        Console.WriteLine($"a.Equals(b)     : {a.Equals(b)}");

        string c = "world";
        string d = new string(new char[] { 'w', 'o', 'r', 'l', 'd' });

        Console.WriteLine("\n=== Case 2: new string(...) ===");
        Console.WriteLine($"c = \"{c}\"  |  d = \"{d}\"");
        Console.WriteLine($"c == d          : {c == d}");
        Console.WriteLine($"c.Equals(d)     : {c.Equals(d)}");
        Console.WriteLine($"ReferenceEquals : {ReferenceEquals(c, d)}");

        // ── Case 3: null safety difference ──────────────────────────────
        string e = null;
        string f = "test";

        Console.WriteLine("\n=== Case 3: Null Handling ===");
        Console.WriteLine($"e == f          : {e == f}");
        Console.WriteLine($"e == null       : {e == null}");
        Console.WriteLine($"string.Equals(e, f) : {string.Equals(e, f)}"); // safe way



        //7. Write a program that takes three integers and finds the largest one using only comparison operators (no Math.Max).
        Console.Write("Enter The First Number: ");
        int firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter The Second Number: ");
        int secondNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter The Third Number: ");
        int thirdNum = Convert.ToInt32(Console.ReadLine());
        if (firstNum > secondNum && firstNum > thirdNum)
        {
            Console.WriteLine("Largest Number Is " + firstNum);
        }
        else if (secondNum > firstNum && secondNum > thirdNum)
        {
            Console.WriteLine("Largest Number Is " + secondNum);
        }
        else if (thirdNum > firstNum && thirdNum > secondNum)
        {
            Console.WriteLine("Largest Number Is " + thirdNum);
        }

    }
}