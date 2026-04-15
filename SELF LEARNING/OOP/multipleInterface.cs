interface IAnimal
{
    void makeMethod();
}

interface IBird
{
    void makeAnotherMethod();
}

class child : IAnimal, IBird
{
    public void makeMethod()
    {
        Console.WriteLine("Hello, This Is Method.");
    }

    public void makeAnotherMethod()
    {
        Console.WriteLine("Hello, This Is Another Method.");
    }
}

class Program
{
    static void Main()
    {
        child Child = new child();
        Child.makeMethod();
        Child.makeAnotherMethod();

    }
}