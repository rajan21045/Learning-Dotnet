using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int[] intArray = {1, 2, 3, 4, 5};
        double[] doubleArray = {1.33, 2.12, 3.123, 4.75, 5.45};
        String[] stringArray = {"Rajan", "Prabin", "Raaj"};

        displayElements(intArray);
        displayElements(doubleArray);
        displayElements(stringArray);
    }

    public static void displayElements<Thing>(Thing[] array)
    {
        foreach(Thing items in array)
        {
            Console.Write(items + " ");
        }
        Console.WriteLine();
    }
}