using System;
using System.Linq;
 
class arrayPracticeSort
{
    static void Main()
    {
        //There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Array.Sort(cars);
        for (int i = 0; i < cars.Length; i++)
        {
            Console.Write(cars[i] + " ");
        }

        Console.WriteLine("\n");
        int[] num = { 10, 30, 20, 11 };
        Array.Sort(num);
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }

        //System.Linq Namespace
        // Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
        Console.WriteLine("\n");
        Console.WriteLine("Min: " + num.Min()); // returns the smallest value
        Console.WriteLine("Max: " + num.Max()); // returns the largest value
        Console.WriteLine("Sum: " + num.Sum()); // returns the sum of all values

    }
}