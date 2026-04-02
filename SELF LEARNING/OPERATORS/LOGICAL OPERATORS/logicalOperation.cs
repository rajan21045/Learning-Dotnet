/*
Logical Operators
As with comparison operators, you can also test for True or False values with logical operators.
Logical operators are used to determine the logic between variables or values:
*/
using System;
class Program
{
    static void Main()
    {
        //1. && — Logical AND
        // Returns true only if both conditions are true.
        int age = 20;
        bool hasID = true;
        if (age >= 18 && hasID)
        {
            Console.WriteLine("Entry allowed.");
        }

        //2. || — Logical OR
        //Returns true if at least one condition is true.
        bool isWeekend = false;
        bool isHoliday = true;

        if (isWeekend || isHoliday)
        {
        Console.WriteLine("No school today!");
        }
        //3. ! — Logical NOT
        //Inverts a boolean value.
        bool isRaining = false;
        if (!isRaining)
        {
        Console.WriteLine("Go outside!");
        }

        //Combining Operators
        // You can chain multiple logical operators together. Use parentheses to control evaluation order:
        int marks = 75;
        bool isPresent = true;
        bool cheated = false;

        if ((marks >= 50 && isPresent) && !cheated)
        {
         Console.WriteLine("Student passed.");
        }
    }
}