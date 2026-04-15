/* 
Polymorphism is one of the four pillars of OOP (along with Encapsulation, Inheritance, and Abstraction). 
It means "many forms" — the same method or interface behaves differently depending on the object using it.

Types of Polymorphism

1. Compile-time Polymorphism (Static)
Resolved at compile time. Achieved through method overloading.
Same method name add, but the compiler picks the right one based on arguments.
*/
using System;
class Program
{
    static void Main()
    {
        Calculator cal = new Calculator();
        Console.WriteLine($"The sum of 20 and 30 is {cal.add(20, 30)}");
        Console.WriteLine($"The sum of 20 and 30 is {cal.add(20, 30, 10)}");
        Console.WriteLine($"The sum of 20 and 30 is {cal.add(20.11, 30.23)}");
    }
}
class Calculator
{
    public int add(int num1, int num2)
    {
        return num1 + num2;
    }
    public double add(double num1, double num2) //Same name, different params
    {
        return num1 + num2;
    }
    public int add(int num1, int num2, int num3)// Same name, different params
    {
        return num1 + num2 + num3;
    }
}