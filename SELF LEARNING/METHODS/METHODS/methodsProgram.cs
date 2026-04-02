//C# Methods
/*
A method is a block of code which only runs when it is called.

You can pass data, known as parameters, into a method.

Methods are used to perform certain actions, and they are also known as functions.

Why use methods? To reuse code: define the code once, and use it many times.
*/

using System;
class Program
{
    static void myMethod()
    {
        Console.WriteLine("I just got executed!");
    }
    static void Main(string[] args)
    {
        myMethod();
    }
}

/*
Explained
MyMethod() is the name of the method
static means that the method belongs to the Program class and not an object of the Program class. You will learn more about objects and how to access methods through objects later in this tutorial.
void means that this method does not have a return value. You will learn more about return values later in this chapter
*/