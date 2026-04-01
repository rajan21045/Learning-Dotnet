using System;
class Program
{
    static void Main()
    {
        //1. Write a program that takes two integers as input and prints whether the first number is greater than, less than, or equal to the second number using comparison operators.
        Console.Write("Enter First Number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int y = Convert.ToInt32(Console.ReadLine());

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

        //2. Given int a = 15, b = 20, c = 15; — write expressions using ==, !=, <, >, <=, >= and predict the boolean result of each.
        int a =15, b=20, c=15;
        Console.WriteLine();
        Console.WriteLine($"Value of A Is {a}, Value of B Is {b}, Value of C Is {c}");
        Console.WriteLine($"Is {a} Greater Than {b} And {c}: {a>b && a>c}.");
        Console.WriteLine($"Is {b} Less Than {a} And {c}: {b<a && b<c}.");
        Console.WriteLine($"Is {a} Equal To {b} And {c}: {a==b && a==c}.");
        Console.WriteLine($"Is {c} Not Equal To {a} And {b}: {c!=a && c!=b}.");
        Console.WriteLine($"Is {a} Is Greater Than Or Equal To {b} And {c}: {a>=b && a>=c}");
        Console.WriteLine($"Is {a} Is Less Than Or Equal To {b} And {c}: {a<=b && a<=c}");

        //3. Write a program that checks whether a given number is between 1 and 100 (inclusive) using comparison operators and prints true or false.
        Console.WriteLine();
        Console.Write("Enter Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Is Given Number({num}) Between 1 And 100 (Inclusive): {num>1 && num<=100}");
    }
}