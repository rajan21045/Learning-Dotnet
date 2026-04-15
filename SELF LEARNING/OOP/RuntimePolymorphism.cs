//2. Runtime Polymorphism (Dynamic)
//Resolved at runtime. Achieved through method overriding + inheritance.

// Base class
class Father
{
    public virtual void makeHouse()
    {
        Console.WriteLine("I Am Father And Making House...");
    }
}

class Son1 : Father
{
    //    // override = replaces base class method
    public override void makeHouse()
    {
        Console.WriteLine("I Am First Son And Making House...");
    }
}

class Son2 : Father
{
    public override void makeHouse()
    {
        Console.WriteLine("I Am Second Son And Making House...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Father father;
        father = new Son1();
        father.makeHouse();
        father = new Son2();
        father.makeHouse();
    }
}