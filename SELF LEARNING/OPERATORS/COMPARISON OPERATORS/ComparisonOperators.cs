using System;
class Program
{
    static void Main()
    {
        
        /*
        Comparison Operators
        Comparison operators are used to compare two values (or variables). This is important in programming, because it helps us to find answers and make decisions.
        The return value of a comparison is either True or False. These values are known as Boolean values, and you will learn more about them in the Booleans and If..Else chapter.
        */

        int x =120;
        int y= 220;
        Console.WriteLine("Showing You The Example of Greater Than Operator(>): ");
        Console.WriteLine($"Is {x} Is Greater Than {y}: {x>y}");

        Console.WriteLine();
        Console.WriteLine("Showing You The Example of Equal To(==): ");
        Console.WriteLine($"Is {x} Is Equal To {y}: {x==y}");

        Console.WriteLine();
        Console.WriteLine("Showing You The Example of Not equal(!=): ");
        Console.WriteLine($"Is {x} Is Not Equal To {y}: {x!=y}");

        Console.WriteLine();
        Console.WriteLine("Showing You The Example of Less Than(<): ");
        Console.WriteLine($"Is {x} Is Smaller Than {y}: {x<y}");

        Console.WriteLine();
        Console.WriteLine("Showing You The Example of Greater Than Or Equal to(>=): ");
        Console.WriteLine($"Is {x} Is Greater Than Or Equal To {y}: {x>=y}");

        Console.WriteLine();
        Console.WriteLine("Showing You The Example of Less Than Or Equal to(<=): ");
        Console.WriteLine($"Is {x} Is Less Than Or Equal To {y}: {x<=y}");
    }
}