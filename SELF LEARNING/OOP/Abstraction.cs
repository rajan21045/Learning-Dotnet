/*
Abstract Classes and Methods
Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces (which you will learn more about in the next chapter).

The abstract keyword is used for classes and methods:

Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
*/
abstract class Animal
{
    public abstract void makeSound();

    public void sleep()
    {
        Console.WriteLine("Hello, I Am Sleeping. Sorry.");
    }
}
class Pig : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Hello.");
    }
}

class Program
{
    static void Main()
    {
        Pig pig = new Pig();
        pig.makeSound();
        pig.sleep();
    }
}

/*
Why And When To Use Abstract Classes and Methods?
To achieve security - hide certain details and only show the important details of an object.
*/