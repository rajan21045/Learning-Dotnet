//Return Values
using System;
//In the previous page, we used the void keyword in all examples, which indicates that the method should not return a value.

// If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:
class Program
{
    static int MyMethod(int x)
    {
        return 5 + x;
    }
    static int MyMethod2(int x, int y)
    {
        return x + y;
    }

    static int MyMethod3(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyMethod(3));
        Console.WriteLine(MyMethod2(5, 3));
        int z = MyMethod3(5, 3);
        Console.WriteLine(z);
    }
}