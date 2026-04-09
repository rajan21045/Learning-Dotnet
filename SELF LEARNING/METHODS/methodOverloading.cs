using System;
class Program
{
    //Method Overloading
    //With method overloading, multiple methods can have the same name with different parameters:
    static int MyMethod(int a, int b)
    {
        return a+b;
    }

    static double MyMethod(double a, double b)
    {
        return a+b;
    }

    static double MyMethod(double a, int b)
    {
        return a+b;
    }

    static void Main()
    {
        int result1 = MyMethod(10, 20);
        double result2 = MyMethod(10.221, 20.22231);
        double result3 = MyMethod(10.221, 20);
        Console.Write(result2);
        Console.WriteLine("Hello, Adding 10 And 20 Is {0} And Adding 10.221 And 20.22231 Is {1} And Adding 10.221 And 20 Is {2}", result1, result2, result3);
    }
}