using System;

class Program
{
    static void Main()
    {
        int x = 10;
        int y = 5;

        // Simple assignment
        int a = x;
        Console.WriteLine("=  Operator : a = " + a);

        // Addition assignment
        x += y;   // x = x + y
        Console.WriteLine("+= Operator : x = " + x);

        // Subtraction assignment
        x -= y;   // x = x - y
        Console.WriteLine("-= Operator : x = " + x);

        // Multiplication assignment
        x *= y;   // x = x * y
        Console.WriteLine("*= Operator : x = " + x);

        // Division assignment
        x /= y;   // x = x / y
        Console.WriteLine("/= Operator : x = " + x);

        // Modulus assignment
        x %= y;   // x = x % y
        Console.WriteLine("%= Operator : x = " + x);

        // Left shift assignment
        x <<= 2;  // x = x << 2
        Console.WriteLine("<<= Operator : x = " + x);

        // Right shift assignment
        x >>= 1;  // x = x >> 1
        Console.WriteLine(">>= Operator : x = " + x);

        // Bitwise AND assignment
        x &= y;   // x = x & y
        Console.WriteLine("&= Operator : x = " + x);

        // Bitwise OR assignment
        x |= y;   // x = x | y
        Console.WriteLine("|= Operator : x = " + x);

        // Bitwise XOR assignment
        x ^= y;   // x = x ^ y
        Console.WriteLine("^= Operator : x = " + x);
    }
}