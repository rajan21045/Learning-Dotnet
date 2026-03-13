// Namespace declaration - used to organize code into logical groups
namespace ArrayMultidimensionalPractice
{
    // Class declaration
    class ArrayMultidimensionalPractice
    {
        // Main method - entry point of the program
        static void Main()
        {
            // Declaring and initializing a 2D (multidimensional) array
            // 2 rows and 3 columns
            int[,] myNummbers = new int[2, 3]
            {
                {1, 2, 3},   // First row
                {4, 5, 6}    // Second row
            };

            // Accessing elements of the multidimensional array using nested loops
            // GetLength(0) returns number of rows
            for (int i = 0; i < myNummbers.GetLength(0); i++)
            {
                // GetLength(1) returns number of columns
                for (int j = 0; j < myNummbers.GetLength(1); j++)
                {
                    // Printing each element of the array
                    Console.Write(myNummbers[i, j] + " ");
                }

                // Move to the next line after each row
                Console.WriteLine();
            }

            // Jagged Array (array of arrays)
            // Each row can have a different number of elements
            int[][] myNumbers = new int[][]
            {
                new int[] {1, 2, 3},              // First array (3 elements)
                new int[] {4, 5},                 // Second array (2 elements)
                new int[] {6, 7, 8, 9},           // Third array (4 elements)
                new int[] {10, 11, 12, 13, 14}    // Fourth array (5 elements)
            };

            // Printing a blank line for separation
            Console.WriteLine();

            // Accessing jagged array elements using foreach loops
            foreach (int[] array in myNumbers) // Iterates through each inner array
            {
                foreach (int number in array)  // Iterates through each element of the inner array
                {
                    Console.Write(number + " ");
                }

                // Move to next line after printing one inner array
                Console.WriteLine();
            }

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}