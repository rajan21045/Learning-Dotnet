using System;
class arrayPracticeSecond
{
    static void Main()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        // Loop Through an Array
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        Console.WriteLine();
        // The foreach Loop
        // The foreach loop is used to loop through the elements of an array:
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
}