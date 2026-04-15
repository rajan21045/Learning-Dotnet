/*
    Why And When To Use "Inheritance"?
    - It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.


    Inheritance (Derived and Base Class)
    In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

    Derived Class (child) - the class that inherits from another class
    Base Class (parent) - the class being inherited from
    To inherit from a class, use the : symbol.
*/

class Vechile
{
    public string name = "Rajan Poudel";
    public void Sound()
    {
        Console.WriteLine("Hello, Vechile");
    }
}

class Car : Vechile
{
    public string brandName = "Toyota";
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Console.WriteLine(car.brandName);
        Console.WriteLine(car.name);
        car.Sound();
    }
}